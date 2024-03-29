﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        public static Version version;

        public static string appVersion;
        public static string AppDataDirectory;
        public static string ColorHistoryFilePath;
        public static string ColorPickerSettingsFilePath;

        //public static History history;

        static Program()
        {
            Program.version = Assembly.GetExecutingAssembly().GetName().Version;
            Program.AppDataDirectory = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Color Picker\\");
            Program.ColorHistoryFilePath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Color Picker\\.history");
            Program.ColorPickerSettingsFilePath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Color Picker\\.settings");

            //history = new History();
        }

        public static void EnsureAppDataDirectoryExists()
        {
            if (!Directory.Exists(Program.AppDataDirectory))
            {
                Directory.CreateDirectory(Program.AppDataDirectory);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);

            // Do Terminal work.



            // End Terminal work.

            Program.appVersion = Application.ProductVersion;
            Program.EnsureAppDataDirectoryExists();

            if (AppSettings.Exists(ColorPickerSettingsFilePath))
            {
                AppSettings.Load(ColorPickerSettingsFilePath);
            }

            //if (History.Exists(Program.ColorHistoryFilePath))
            //{
            //    History.Load(Program.ColorHistoryFilePath);
            //}

            AppSettings.GetStrips(Program.AppDataDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
