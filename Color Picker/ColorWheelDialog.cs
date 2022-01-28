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
        public Panel currentColorPanel;

        public ColorWheelDialog()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

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
            panel.ContextMenu = colorPanelContextMenu;
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseClick += Panel_MouseClick;

            addedColorsPanel.Controls.Add(panel);

            rgbLine1.ChosenColor = selectedColor;
            rgbLine1.Refresh();

            Colors.Add(selectedColor);
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            colorPanel.BackColor = color;
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            currentColorPanel = (sender as Panel);
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
            addedColorsPanel.Location = new Point(12, 367);
        }

        private void applyButton_Confirmed(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void removeContextMenuItem_Click(object sender, EventArgs e)
        {
            addedColorsPanel.Controls.Remove(currentColorPanel);
        }

        private void clearColorsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Colors.Clear();
            addedColorsPanel.Controls.Clear();
        }

        private void rgbLine1_MouseMove(object sender, MouseEventArgs e)
        {
            if(rgbLine1.ManuallySelectedColor != Color.Empty)
            {
                colorPanel.BackColor = rgbLine1.ManuallySelectedColor;
            }
        }

        private void rgbLine1_MouseUp(object sender, MouseEventArgs e)
        {
            // Add the selected color to the color panel.
            Color selectedColor = colorPanel.BackColor;

            Panel panel = new Panel();
            panel.BackColor = selectedColor;
            panel.Width = 10;
            panel.Height = 32;
            panel.ContextMenu = colorPanelContextMenu;
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseClick += Panel_MouseClick;

            addedColorsPanel.Controls.Add(panel);

            rgbLine1.ChosenColor = selectedColor;
            rgbLine1.Refresh();

            Colors.Add(selectedColor);
        }

        private void colorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                FullScreenWindow.SelectedColor = (sender as Panel).BackColor;

                using (FullScreenWindow fullScreenWindow = new FullScreenWindow())
                {
                    if(fullScreenWindow.ShowDialog(this) == DialogResult.OK)
                    {

                    }
                }
            }
        }
    }
}
