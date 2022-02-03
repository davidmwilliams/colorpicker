using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class Strip
    {
        public List<Color> Colors { get; set; }

        public Point StripLocation { get; set; }
        public Size StripSize { get; set; }

        public Strip()
        {
            Colors = new List<Color>();
        }

        public static void Save(List<Color> colors, string filePath)
        {
            string colorString = "";

            foreach (Color color in colors)
            {
                colorString += color.A + "," + color.R + "," + color.G + "," + color.B + ";";
            }

            colorString = colorString.TrimEnd(';');

            File.WriteAllText(Program.AppDataDirectory + "colorpicker.strip", colorString);
        }
    }
}
