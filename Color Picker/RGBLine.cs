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
    public partial class RGBLine : Control
    {
        private int sliderXLocation;
        public Bitmap screenBitmap = new Bitmap(1, 1);
        private bool pressing;
        private Point lastMouseLocation,
            currentLocation,
            lastGuideLocation;
        private bool moving;

        private Color selectedColor { get; set; }

        public enum Colors
        {
            Red = 0,
            Green,
            Blue,
            Shade
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Line Color")]
        public Colors SelectedColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Line Thickness")]
        public float LineThickness { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Color")]
        public Color ChosenColor { get; set; }

        public RGBLine()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            sliderXLocation = this.Width - (int)1.0f;

            InitializeComponent();

            this.Height = 10;
            this.Size = new Size(255, this.Height);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            switch (SelectedColor)
            {
                case Colors.Red:
                    using (Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(255, (int)LineThickness), Color.Black, Color.Red))
                    {
                        using (Pen aGradientPen = new Pen(aGradientBrush))
                        {
                            pe.Graphics.DrawLine(aGradientPen, new Point(0, 0), new Point(255, 0));
                        }
                    }
                    break;
                case Colors.Green:
                    using (Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(255, (int)LineThickness), Color.Black, Color.Green))
                    {
                        using (Pen aGradientPen = new Pen(aGradientBrush))
                        {
                            pe.Graphics.DrawLine(aGradientPen, new Point(0, 0), new Point(255, 0));
                        }
                    }
                    break;
                case Colors.Blue:
                    using (Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(255, (int)LineThickness), Color.Black, Color.Blue))
                    {
                        using (Pen aGradientPen = new Pen(aGradientBrush))
                        {
                            pe.Graphics.DrawLine(aGradientPen, new Point(0, 0), new Point(255, 0));
                        }
                    }
                    break;
                case Colors.Shade:
                    using (Brush shadedGradientBrush = new LinearGradientBrush(new Point(0, (this.Height / 2) - (int)(LineThickness / 2)), new PointF(255, (int)LineThickness), Color.White, ChosenColor))
                    {
                        using (Pen shadedGradientPen = new Pen(shadedGradientBrush))
                        {
                            pe.Graphics.DrawLine(shadedGradientPen, new Point(0, (this.Height / 2) - (int)(LineThickness / 2)), new Point(255, (this.Height / 2) - (int)(LineThickness / 2)));
                        }
                    }

                    if (pressing)
                    {
                        if (moving)
                        {
                            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                            Point[] points2 = { new Point(currentLocation.X + lastMouseLocation.X, 0), new Point(currentLocation.X + lastMouseLocation.X + 5, 5), new Point(currentLocation.X + lastMouseLocation.X + 10, 0) };
                            pe.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(11, 109, 255)), points2);

                            // Get the color below the tip of the triangle.
                        }
                        else
                        {
                            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                            Point[] points2 = { new Point(lastMouseLocation.X, 0), new Point(lastMouseLocation.X + 5, 5), new Point(lastMouseLocation.X + 10, 0) };
                            pe.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(11, 109, 255)), points2);
                        }
                    }
                    else
                    {
                        pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        Point[] points2 = { new Point(this.Width - 10 | 0, 0), new Point(this.Width - 10 + 5, 5), new Point(this.Width - 10 + 10, 0) };
                        pe.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(11, 109, 255)), points2);
                    }
                    break;
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

        private void RGBLine_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pressing)
                pressing = true;

            lastMouseLocation = e.Location;

            this.Refresh();
        }

        private void RGBLine_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressing)
            {
                moving = true;
                currentLocation = e.Location;
                this.Refresh();
            }
        }

        private void RGBLine_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;
        }
    }
}
