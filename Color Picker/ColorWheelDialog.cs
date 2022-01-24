/*
 * Color Wheel by http://csharphelper.com/blog/2015/09/draw-a-colorful-color-wheel-in-c/
*/
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
    public partial class ColorWheelDialog : Form
    {
        public Bitmap screenBitmap = new Bitmap(1, 1);
        bool pressing;
        Point lastMouseLocation;
        public List<Color> Colors;

        public ColorWheelDialog()
        {
            InitializeComponent();
            lastMouseLocation = new Point();
            Colors = new List<Color>();
        }

        public Color GetColorAt(int x, int y)
        {
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics graphics = Graphics.FromImage(screenBitmap))
                graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return screenBitmap.GetPixel(0, 0);
        }

        private void colorWheel_MouseClick(object sender, MouseEventArgs e)
        {
            // Add the selected color to the color panel.
            Color selectedColor = GetColorAt(Cursor.Position.X, Cursor.Position.Y);

            Panel panel = new Panel();
            panel.BackColor = selectedColor;
            panel.Width = 10;
            panel.Height = 32;
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;

            addedColorsPanel.Controls.Add(panel);

            rgbLine1.ChosenColor = selectedColor;
            rgbLine1.Refresh();

            Colors.Add(selectedColor);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(pressing)
            {
                addedColorsPanel.Left = (addedColorsPanel.Left - lastMouseLocation.X + e.X);
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            pressing = true;
            lastMouseLocation = e.Location;
        }

        private void colorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            colorPanel.BackColor = colorWheel.SelectedColor;
        }

        private void ColorWheelDialog_MouseClick(object sender, MouseEventArgs e)
        {
            addedColorsPanel.Location = new Point(12, 324);
        }

        private void applyButton_Confirmed(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
