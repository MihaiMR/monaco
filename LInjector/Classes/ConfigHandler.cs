﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LInjector.Classes
{
    public static class ConfigHandler
    {
        private static readonly string ConfigPath = ".\\config.json";
        private static application GetApplication = new application();

        public static void DoConfig()
        {
            if (!File.Exists(ConfigPath))
            {
                var config = new Dictionary<string, bool>
                {
                    { "autoattach", false },
                    { "nosplash", false },
                    { "metalpipe", false },
                    { "bamboopipe", false },
                    { "sizable", false },
                    { "debug", false }
                };

                string jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);

                File.WriteAllText(ConfigPath, jsonString);
            }
            else if (File.Exists(ConfigPath))
            {
                string jsonString = File.ReadAllText(ConfigPath);

                var config = JsonConvert.DeserializeObject<Dictionary<string, bool>>(jsonString);

                if (config.TryGetValue("autoattach", out bool autoAttachValue) && autoAttachValue)
                {
                    var Timer = new System.Windows.Forms.Timer();
                    Timer.Enabled = true;
                    Timer.Interval = 100;

                    Timer.Tick += (sender, e) =>
                    {
                        Process[] Roblox = Process.GetProcessesByName("Windows10Universal");
                        if (Roblox.Length > 0)
                        {
                            FluxusAPI.create_files(Path.GetFullPath("Resources\\libs\\Module.dll"));
                            if (!FluxusAPI.is_injected(FluxusAPI.pid))
                            {
                                GetApplication.Inject();
                            }
                            bool flag = FluxusAPI.is_injected(FluxusAPI.pid);
                            if (flag)
                            {
                                Timer.Stop();
                            }
                        }
                    };


                }

                if (config.TryGetValue("nosplash", out bool noSplashValue) && noSplashValue)
                {
                    ArgumentHandler.splashEnabled = false;
                }

                if (config.TryGetValue("metalpipe", out bool metalPipeValue) && metalPipeValue)
                {
                    DoPipe.doMetalPipeAsync();
                }

                if (config.TryGetValue("bamboopipe", out bool bambooPipeValue) && bambooPipeValue)
                {
                    DoPipe.doBambooPipeAsync();
                }

                if (config.TryGetValue("sizable", out bool sizableValue) && sizableValue)
                {
                    ArgumentHandler.SizableBool = true;
                }

                if (config.TryGetValue("debug", out bool debugValue) && debugValue)
                {
                    ConsoleManager.Initialize();
                    ConsoleManager.ShowConsole();
                }
            }
        }
    }
}

// is this among us imposter