﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using DiscordRPC;
using KrnlAPI;
using LInjector;
using LInjector.Classes;

namespace LInjector
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public const string currentVersion = "v10.06.2023"; 
        // Put "f81fb0e34f313b6cf0d0fc345890a33f" for skipping isOutdated MessageBox. 
        // The versions are in format dd/MM/yyy. (adding the v), if it's December 31, 1969, the version is "v31.12.1969"


        [STAThread]
        static void Main()
        {
            DiscordRPCManager discordRPCManager = new DiscordRPCManager();

            if (GitHubVersionChecker.IsOutdatedVersion(currentVersion))
            {
                MessageBox.Show("LInjector is outdated, please, re-run LInjector Updating System or download the latest release via GitHub.",
                    "LInjector | Outdated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start("https://github.com/ItzzExcel/LInjector/releases");
            }

            
            discordRPCManager.InitRPC();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleInstanceChecker.CheckInstance();
        }
    }
}
