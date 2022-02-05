using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Color_Picker
{
    public class StripParser
    {
        public static List<Color> Parse(string input)
        {
            if (input == null) return null;

            List<Color> colors = new List<Color>();
            string[] colorArray = { };
            char[] parts = input.ToCharArray();

            string supposedColor = "";
            bool valid;

            string[] colorsArray = input.Split(';');

            foreach (string array in colorsArray)
            {
                colorArray = array.Split(',');

                int numbera, numberr, numberg, numberb;
                Int32.TryParse(colorArray[0], out numbera);
                Int32.TryParse(colorArray[1], out numberr);
                Int32.TryParse(colorArray[2], out numberg);
                Int32.TryParse(colorArray[3], out numberb);

                Color color = Color.FromArgb(numbera, numberr, numberg, numberb);
                colors.Add(color);
                Console.WriteLine(color.ToString());

            }

            return colors;
        }

        public static string Peek(string input, int index, int nextIndex = 1)
        {
            return input.Substring(index, nextIndex);
        }
    }
}
