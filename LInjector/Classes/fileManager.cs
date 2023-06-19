﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LInjector.Classes
{
    public static class TypeWriteManager
    {
        private static bool isBusy;

        public static async Task DoTypeWrite<T>(string message, T targetControl) where T : Control
        {
            if (isBusy)
            {
                while (isBusy)
                {
                    await Task.Delay(100);
                }
            }

            isBusy = true;

            string originalText = targetControl.Text;

            targetControl.Invoke((MethodInvoker)(async () =>
            {
                targetControl.Text = "";

                if (message.Length < 50)
                {
                    foreach (char character in message)
                    {
                        targetControl.Text += character;
                        targetControl.Refresh();
                        await Task.Delay(30);
                        DiscordRPCManager.SetRpcFile(message);
                    }
                } 
                else
                {
                    string cutMessage = message.Substring(0, Math.Min(50, message.Length));
                    foreach (char character in cutMessage)
                    {
                        targetControl.Text += character;
                        targetControl.Refresh();
                        await Task.Delay(30);
                        DiscordRPCManager.SetRpcFile(message);
                    }
                }
            }));

            isBusy = false;
        }
    }
}