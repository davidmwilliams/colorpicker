﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class AppSettings
    {
        [Serializable]
        public class LocalSettings
        {
            public int ColorPanelWidth { get; set; }

            public Size DefaultWindowSize { get; set; }

            public bool OpenOnStart { get; set; }
        }

        public AppSettings()
        {
            
        }

        public static List<Color> GetStrips(string colorStripStorageDirectory)
        {
            if(Directory.Exists(colorStripStorageDirectory))
            {
                foreach(var file in Directory.GetFiles(colorStripStorageDirectory, searchPattern: "*.strip"))
                {
                    if (File.Exists(file))
                    {
                        string content = File.ReadAllText(file);

                        if (content != null && !String.IsNullOrEmpty(content))
                        {
                            // Parse the content.
                            return StripParser.Parse(content);
                        }
                    }
                }
            }

            return new List<Color>();
        }

        public static bool Exists(string filePath)
        {
            return File.Exists(filePath) ? true : false;
        }

        public static void Load(string filePath)
        {
            MemoryStream memoryStream = new MemoryStream();
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(LocalSettings));

            if(!(new FileInfo(filePath)).IsReadOnly)
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    fileStream.CopyTo(memoryStream);
                }

                memoryStream.Position = 0;

                LocalSettings localSettings = (LocalSettings)dataContractJsonSerializer.ReadObject(memoryStream);
            }
        }
    }
}
