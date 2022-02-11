using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Shader : Control
    {
        public class CustomColor
        {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public List<CustomColor> customColors = new List<CustomColor>();

        public Color StartingColor { get; set; }
        public Color EndingColor { get; set; }

        public Shader()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            for(int i = 0; i < 255; i = i + 5)
            {
                customColors.Add(new CustomColor()
                {
                    R = i,
                    G = i,
                    B = i
                });
            }

            foreach(CustomColor color in customColors)
            {
                pe.Graphics.FillRectangle(new SolidBrush(EndingColor), new RectangleF());
            }

            base.OnPaint(pe);
        }
    }
}
