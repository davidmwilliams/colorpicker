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
    public partial class ColorSlider : Control
    {
        [Category("Appearance")]
        [DisplayName("Slider Color")]
        [Browsable(true)]
        public Colors SliderColor { get; set; }

        public enum Colors
        {
            Red,
            Green,
            Blue
        }

        public ColorSlider()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Draw(pe);

            base.OnPaint(pe);
        }

        private void Draw(PaintEventArgs paintEventArgs)
        {
            // Determine which color to render.
            switch(SliderColor)
            {
                case Colors.Red:

                    break;
                case Colors.Blue:

                    break;
                case Colors.Green:

                    break;
            }
        }
    }
}
