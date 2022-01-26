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
    public partial class CustCont : Control
    {
        public CustCont()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Point[] points2 = { new Point(0, 0), new Point(5, 5), new Point(10, 0) };
            pe.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(11, 109, 255)), points2);

            base.OnPaint(pe);
        }
    }
}
