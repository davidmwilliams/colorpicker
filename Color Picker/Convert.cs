using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class Convert
    {
        public static string ToCMYK(int r, int g, int b)
        {
            float cyan;
            float magenta;
            float yellow;
            float black;
            float red;
            float green;
            float blue;

            red = r / 255F;
            green = g / 255F;
            blue = b / 255F;

            black = ClampCmyk(1 - Math.Max(Math.Max(red, green), blue));
            cyan = ClampCmyk((1 - red - black) / (1 - black));
            magenta = ClampCmyk((1 - green - black) / (1 - black));
            yellow = ClampCmyk((1 - blue - black) / (1 - black));

            string result = cyan + "," + magenta + "," + yellow + "," + black;

            return result;
        }

        private static float ClampCmyk(float value)
        {
            if (value < 0 || float.IsNaN(value))
            {
                value = 0;
            }

            return value;
        }
    }
}
