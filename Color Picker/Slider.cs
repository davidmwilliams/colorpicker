using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Slider : Control
    {
        public Color SelectedColor { get; set; }
        public Color StartingColor { get; set; }
        public Color EndingColor { get; set; }

        private bool pressing, moving;
        private Point lastMouseLocation, mouseMoveLocation;
        private Bitmap screenBitmap = new Bitmap(1, 1);

        public Slider()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            this.Size = new Size(255, 20);
            this.MinimumSize = new Size(255, 20);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Rectangle barRectangle = new Rectangle(3, 6, 255 - 14, 12);

            LinearGradientMode gradientMode = LinearGradientMode.Horizontal;

            pe.Graphics.DrawRectangle(new Pen(Color.Black, 1.0f), barRectangle);

            if (pressing && moving)
            {
                Point[] trianglePoints =
                {
                    new Point(mouseMoveLocation.X - 4, 0),
                    new Point(mouseMoveLocation.X + 4, 0),
                    new Point(mouseMoveLocation.X + 0, 4)
                };

                Color color = GetColorAt(Cursor.Position.X, Cursor.Position.Y);

                pe.Graphics.DrawPolygon(new Pen(color, 1.0f), trianglePoints);
                pe.Graphics.DrawLine(new Pen(color, 3.0f), new Point(3, 21), new Point(255 - 11, 21));
            }
            else
            {
                Point[] trianglePoints =
                {
                    new Point(0, 0),
                    new Point(8, 0),
                    new Point(4, 4)
                };

                pe.Graphics.DrawPolygon(new Pen(Color.Black, 1.0f), trianglePoints);
            }

            using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                new Point(4, 7),
                new Point(255, 11),
                Color.White,
                Color.Blue
                )
            )
            {
                pe.Graphics.DrawLine(
                    new Pen(linearGradientBrush, 11.0f),
                    4,
                    12,
                    255 - 11,
                    12
                    );
            }

            base.OnPaint(pe);
        }

        public Color GetColorAt(int x, int y)
        {
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics graphics = Graphics.FromImage(screenBitmap))
                graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return screenBitmap.GetPixel(0, 0);
        }

        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            pressing = true;
        }

        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressing)
            {
                mouseMoveLocation = e.Location;
                moving = true;

                if (e.Location.X >= 256)
                {
                    moving = false;
                    pressing = false;
                }

                this.Refresh();
            }
        }

        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;
            moving = false;
        }
    }
}
