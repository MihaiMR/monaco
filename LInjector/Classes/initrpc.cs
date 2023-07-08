﻿using DiscordRPC;
using System;
using System.Windows.Forms;

namespace LInjector.Classes
{
    public static class DiscordRPCManager
    {
        public static DiscordRpcClient client;

        public static void InitRPC()
        {
            var baseRichPresence = new RichPresence()
            {
                Details = "Using LInjector UWP",
                State = "Exploiting",
                Assets = new Assets()
                {
                    LargeImageKey = "https://lexploits.netlify.app/extra/cdn/LInjector%20ico.png",
                    LargeImageText = "by The LExploits Project.",
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Download", Url = "https://github.com/ItzzExcel/LInjector/releases/latest" },
                    new DiscordRPC.Button() { Label = "Join Discord", Url = "https://discord.gg/NQY28YSVAb" }
                }
            };

            client = new DiscordRpcClient("1104489169314660363");
            client.Initialize();
            client.SetPresence(baseRichPresence);
        }

        public static void SetRpcFile(string currentFile)
        {
            if (client.IsInitialized)
            {
                try
                {
                    var state = "Editing File: " + currentFile;
                    var presence = new RichPresence()
                    {
                        Details = "Using LInjector UWP",
                        State = state,
                        Assets = new Assets()
                        {
                            LargeImageKey = "https://lexploits.netlify.app/extra/cdn/LInjector%20ico.png",
                            LargeImageText = "by The LExploits Project.",
                        },
                        Buttons = new DiscordRPC.Button[]
                        {
                            new DiscordRPC.Button() { Label = "Download", Url = "https://github.com/ItzzExcel/LInjector/releases/latest" },
                            new DiscordRPC.Button() { Label = "Join Discord", Url = "https://discord.gg/NQY28YSVAb" }
                        }
                    };

                    client.SetPresence(presence);
                }
                catch (Exception ex)
                {
                    createThreadMsgBox.createMsgThread("Couldn't update LInjector State (RPC)\nException:\n" + ex.Message, "[WARNING] LInjector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void SetBaseRichPresence()
        {
            if (client.IsInitialized)
            {
                try
                {
                    var baseRichPresence = new RichPresence()
                    {
                        Details = "Using LInjector UWP",
                        State = "Exploiting",
                        Assets = new Assets()
                        {
                            LargeImageKey = "https://lexploits.netlify.app/extra/cdn/LInjector%20ico.png",
                            LargeImageText = "by The LExploits Project.",
                        },
                        Buttons = new DiscordRPC.Button[]
                        {
                            new DiscordRPC.Button() { Label = "Download", Url = "https://github.com/ItzzExcel/LInjector/releases/latest" },
                            new DiscordRPC.Button() { Label = "Join Discord", Url = "https://discord.gg/NQY28YSVAb" }
                        }
                    };

                    client.SetPresence(baseRichPresence);
                }
                catch (Exception ex)
                {
                    createThreadMsgBox.createMsgThread("Couldn't set base Rich Presence (RPC)\nException:\n" + ex.Message, "[WARNING] LInjector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}