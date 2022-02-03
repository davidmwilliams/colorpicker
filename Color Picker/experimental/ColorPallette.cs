using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker.experimental
{
    public class ColorPallette
    {
        [DataMember]
        public List<Color> Colors;

        [DataMember]
        public Color Color { get; set; }

        private int colorPanelWidth;

        [DataMember]
        public int ColorPanelWidth
        {
            get
            {
                return this.colorPanelWidth;
            }
            set
            {
                colorPanelWidth = value | 10;
            }
        }

        public ColorPallette()
        {
            Colors = new List<Color>();
        }
    }
}
