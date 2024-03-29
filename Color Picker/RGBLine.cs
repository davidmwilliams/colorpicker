﻿using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public Color ManuallySelectedColor;
        private int currentPosition;
        private bool positionChanged;

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

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Starting Color")]
        public Color StartingColor { get; set; }

        public RGBLine()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            this.BackColor = Color.Transparent;
            sliderXLocation = this.Width - (int)1.0f;

            InitializeComponent();

            this.Height = 10;
            this.Size = new Size(255, this.Height);
        }

        public void ChangePositionOnSlider(int position)
        {
            currentPosition = position;
            positionChanged = true;

            this.Refresh();
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
                    using (Brush shadedGradientBrush = new LinearGradientBrush(new Point(0, (this.Height / 2) - (int)(LineThickness / 2)), new PointF(255, (int)LineThickness), StartingColor, ChosenColor))
                    {
                        using (Pen shadedGradientPen = new Pen(shadedGradientBrush, LineThickness))
                        {
                            pe.Graphics.DrawLine(shadedGradientPen, new Point(0, (this.Height / 2) - (int)(LineThickness / 2) + 5), new Point(255, (this.Height / 2) - (int)(LineThickness / 2) + 5));
                        }
                    }

                    if (positionChanged)
                    {
                        Point[] points2 =
                        {
                            new Point(currentPosition - 5 | 0, -2),
                            new Point(currentPosition - 5 + 5, 3),
                            new Point(currentPosition - 5 + 10, -2)
                        };

                        pe.Graphics.FillPolygon(new SolidBrush(Color.Black), points2);

                        positionChanged = false;
                    }
                    else
                    {
                        if (pressing)
                        {
                            // Get the color below the tip of the triangle.
                            // Please help, I am having difficulty here.
                            Color color = GetColorAt(Cursor.Position.X, Cursor.Position.Y);

                            ManuallySelectedColor = color;

                            if (moving)
                            {
                                Point[] points2 =
                                {
                                new Point(currentLocation.X - 5, -3),
                                new Point(currentLocation.X, 3),
                                new Point(currentLocation.X + 5, -3)
                            };

                                pe.Graphics.FillPolygon(new SolidBrush(ManuallySelectedColor), points2);

                            }
                            else
                            {
                                Point[] points2 =
                                {
                                new Point(currentLocation.X - 5, -3),
                                new Point(currentLocation.X, 3),
                                new Point(currentLocation.X + 5, -3)
                                //new Point(lastMouseLocation.X, -3), 
                                //new Point(lastMouseLocation.X + 5, 3), 
                                //new Point(lastMouseLocation.X + 10, -3)
                            };

                                pe.Graphics.FillPolygon(new SolidBrush(ManuallySelectedColor), points2);
                            }
                        }
                        else
                        {
                            Point[] points2 =
                            {
                                new Point(currentPosition - 5 | 0, -2),
                                new Point(currentPosition - 5 + 5, 3),
                                new Point(currentPosition - 5 + 10, -2)
                            };

                            pe.Graphics.FillPolygon(new SolidBrush(ManuallySelectedColor), points2);

                            positionChanged = false;

                            //Point[] points2 =
                            //{
                            //new Point(this.Width - 10 | 0, -2),
                            //new Point(this.Width - 10 + 5, 3),
                            //new Point(this.Width - 10 + 10, -2)
                            //};
                            //pe.Graphics.FillPolygon(new SolidBrush(ManuallySelectedColor), points2);
                        }
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
