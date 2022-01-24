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
    public partial class ColorWheel : Control
    {
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Outline Color")]
        public Color OutlineColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Line Thickness")]
        public float LineThickness { get; set; }

        public Color SelectedColor { get; set; }
        public Bitmap screenBitmap = new Bitmap(1, 1);


        public ColorWheel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Draw(pe, OutlineColor, 0, 0, this.Width - (int)LineThickness, this.Height - (int)LineThickness);

            base.OnPaint(pe);
        }

        private void Draw(PaintEventArgs paintEventArgs, Color outlineColor, int xMinimum, int yMinimum, int width, int height)
        {
            Graphics graphics = paintEventArgs.Graphics;

            graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectangle = new Rectangle(
                xMinimum,
                yMinimum,
                width,
                height
                );

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(rectangle);
            graphicsPath.Flatten();

            float numberOfPoints = (graphicsPath.PointCount - 1) / 6;
            Color[] surroundColors = new Color[graphicsPath.PointCount];

            int index = 0;

            InterpolateColors(
                surroundColors,
                ref index,
                1 * numberOfPoints, 
                255, 
                255, 
                0, 
                0, 
                255, 
                255, 
                0, 
                255
                );
            InterpolateColors(surroundColors, 
                ref index,
                2 * numberOfPoints, 
                255, 
                255, 
                0, 
                255, 
                255, 
                0, 
                0, 
                255
                );
            InterpolateColors(surroundColors, 
                ref index,
                3 * numberOfPoints, 
                255, 
                0, 
                0, 
                255, 
                255, 
                0, 
                255, 
                255
                );
            InterpolateColors(surroundColors, 
                ref index,
                4 * numberOfPoints, 
                255, 
                0, 
                255, 
                255, 
                255, 
                0, 
                255, 
                0
                );
            InterpolateColors(surroundColors, 
                ref index,
                5 * numberOfPoints, 
                255, 
                0, 
                255, 
                0, 
                255, 
                255, 
                255, 
                0
                );
            InterpolateColors(surroundColors, 
                ref index,
                graphicsPath.PointCount, 
                255, 
                255, 
                255, 
                0, 
                255, 
                255, 
                0, 
                0
                );

            using (PathGradientBrush pathBrush = new PathGradientBrush(graphicsPath))
            {
                pathBrush.CenterColor = Color.White;
                pathBrush.SurroundColors = surroundColors;

                graphics.FillPath(pathBrush, graphicsPath);

                // It looks better if we outline the wheel.
                using (Pen thickPen = new Pen(OutlineColor, LineThickness))
                {
                    graphics.DrawPath(thickPen, graphicsPath);
                }
            }
        }

        private void InterpolateColors(Color[] surroundColors,
            ref int index, float stop_pt,
            int from_a, int from_r, int from_g, int from_b,
            int to_a, int to_r, int to_g, int to_b)
        {
            int numberOfPoints = (int)stop_pt - index;
            float a = from_a, r = from_r, g = from_g, b = from_b;
            float da = (to_a - from_a) / (numberOfPoints - 1);
            float dr = (to_r - from_r) / (numberOfPoints - 1);
            float dg = (to_g - from_g) / (numberOfPoints - 1);
            float db = (to_b - from_b) / (numberOfPoints - 1);

            for (int i = 0; i < numberOfPoints; i++)
            {
                surroundColors[index++] =
                    Color.FromArgb((int)a, (int)r, (int)g, (int)b);
                a += da;
                r += dr;
                g += dg;
                b += db;
            }
        }

        private void ColorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            SelectedColor = GetColorAt(Cursor.Position.X, Cursor.Position.Y);
        }

        public Color GetColorAt(int x, int y)
        {
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics graphics = Graphics.FromImage(screenBitmap))
                graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return screenBitmap.GetPixel(0, 0);
        }
    }
}