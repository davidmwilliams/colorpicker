using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker.experimental
{
    public class History
    {
        [DataMember]
        public static List<ColorPallette> Pallettes;

        static History()
        {
            History.Pallettes = new List<ColorPallette>();
        }

        public static bool Exists(string filePath) { return false; }
        public static void Load(string filePath) { }
        public static void Delete(string filePath) { }
        public static void Save(string filePath) { }
    }
}
