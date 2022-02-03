using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class History
    {
        [DataMember]
        public static List<ColorPallette> Pallettes;

        static History()
        {
            History.Pallettes = new List<ColorPallette>();
        }

        public static bool Exists(string filePath)
        {
            return (File.Exists(filePath) ? true : false);
        }

        public static void Load(string filePath)
        {
            MemoryStream memoryStream = new MemoryStream();
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<ColorPallette>));

            if (!(new FileInfo(filePath)).IsReadOnly)
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    fileStream.CopyTo(memoryStream);
                }

                memoryStream.Position = 0;

                History.Pallettes = (List<ColorPallette>)dataContractJsonSerializer.ReadObject(memoryStream);
            }
        }

        public static void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        public static void Save(string filePath)
        {
            MemoryStream memoryStream = new MemoryStream();
            (new DataContractJsonSerializer(typeof(List<ColorPallette>))).WriteObject(memoryStream, History.Pallettes);
            memoryStream.Position = (long)0;


            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
