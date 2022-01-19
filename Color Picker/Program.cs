﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    internal static class Program
    {
        public static Version version;

        public static string appVersion;
        public static string AppDataDirectory;
        public static string ColorHistoryFilePath;

        public static History history;

        static Program()
        {
            Program.version = Assembly.GetExecutingAssembly().GetName().Version;
            Program.AppDataDirectory = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Color Picker\\");
            Program.ColorHistoryFilePath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Color Picker\\.history");
            history = new History();
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
        static void Main()
        {
            Program.appVersion = Application.ProductVersion;
            Program.EnsureAppDataDirectoryExists();
            if (History.Exists(Program.ColorHistoryFilePath))
            {
                History.Load(Program.ColorHistoryFilePath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}