﻿using LInjector;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace LInjector
{
    public static class SingleInstanceChecker
    {
        private static Mutex mutex;
        private static bool isNewInstance;

        public static void CheckInstance()
        {
            bool createdNew;
            mutex = new Mutex(true, "LInjector", out createdNew);
            isNewInstance = createdNew;

            if (!isNewInstance)
            {
                // Cerrar el proceso si ya hay una instancia en ejecución
                Process currentProcess = Process.GetCurrentProcess();
                foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
                {
                    if (process.Id != currentProcess.Id)
                    {
                        process.CloseMainWindow();
                        process.WaitForExit();
                    }
                }
                Application.Exit();
                return;
            }

            Application.Run(new splashscr());

            Release();
        }

        private static void Release()
        {
            if (mutex != null)
            {
                if (isNewInstance)
                {
                    mutex.ReleaseMutex();
                }
                mutex.Close();
                mutex = null;
            }
        }
    }
}