﻿using Color_Picker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Window : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public Bitmap screenBitmap = new Bitmap(1, 1);

        public enum VisibilityTypes
        {
            Hidden,
            PartiallyVisible,
            Visible
        }

        public Timer timer = new Timer();
        public ColorDialog colorDialog;

        private bool mouseMoved;

        public static VisibilityTypes Visibility { get; set; }

        public Size defaultSize;
        public Point lastMouseLocation;
        public bool pressing;
        private bool pickingColor;

        public void SetLocation()
        {
            switch (Visibility)
            {
                case VisibilityTypes.Hidden:
                    // Hide everything.
                    exitPanel.Hide();
                    pickColorPanel.Hide();
                    informationPanel.Hide();
                    colorHistoryPanel.Hide();

                    this.Size = new Size(32, 32);
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Right - 32), (Screen.PrimaryScreen.WorkingArea.Bottom / 2) - this.Height / 2);
                    break;
                case VisibilityTypes.PartiallyVisible:
                    this.Size = new Size(42, 32);
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Right - 42), (Screen.PrimaryScreen.WorkingArea.Bottom / 2) - this.Height / 2);
                    break;
                case VisibilityTypes.Visible:
                    // Show everything.
                    exitPanel.Show();
                    pickColorPanel.Show();
                    informationPanel.Show();
                    colorHistoryPanel.Show();

                    this.Size = defaultSize;
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Right - defaultSize.Width), (Screen.PrimaryScreen.WorkingArea.Bottom / 2) - this.Height / 2);
                    break;
            }
        }

        public Window()
        {
            timer.Interval = 1;
            timer.Tick += Timer_Tick;

            colorDialog = new ColorDialog();

            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.AnyColor = true;

            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            defaultSize = new Size(275, 32);
            SetLocation();
        }

        private void eyedropper_MouseEnter(object sender, EventArgs e)
        {
            /* When the Form is not Activated/is Deactivated, 
             * it does not open correctly on MouseEnter. To resolve this, 
             * I Activate the Form on MouseEnter.
            */
            if (!this.Focused)
            {
                this.Activate();
            }

            eyedropper.BackColor = Color.FromArgb(224, 225, 227);

            if (Visibility != VisibilityTypes.Visible)
            {
                Visibility = VisibilityTypes.PartiallyVisible;
                SetLocation();
            }
        }

        private void Window_Deactivate(object sender, EventArgs e)
        {
            Visibility = VisibilityTypes.Hidden;
            SetLocation();

            if (pickingColor)
            {
                PickColorFromScreen();
                timer.Stop();
                pickingColor = false;

                Visibility = VisibilityTypes.Visible;
                SetLocation();
            }
        }

        private void PickColorFromScreen()
        {
            Color selectedColor = GetColorAt(Cursor.Position.X, Cursor.Position.Y);

            if (selectedColor != null)
            {
                ColorPallette colorPallette = new ColorPallette()
                {
                    Color = selectedColor
                };

                //Program.history = new History();
                History.Pallette.Add(colorPallette);

                CreateColorPanel(selectedColor);
            }
        }

        private void openClosePanel_MouseDown(object sender, MouseEventArgs e)
        {
            openClosePanel.BackColor = Color.FromArgb(184, 185, 187);

            pressing = true;
            lastMouseLocation = e.Location;
        }

        private void openClosePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressing)
            {
                mouseMoved = true;

                Visibility = VisibilityTypes.Visible;

                if (Visibility == VisibilityTypes.Visible)
                {
                    // Make sure we can't resize more than the width of the current working area.
                    if (this.Width != Screen.PrimaryScreen.WorkingArea.Width)
                    {
                        this.Size = new Size((this.Width + lastMouseLocation.X - e.X), this.Height);
                        this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Right - this.Width), this.Location.Y);
                    }
                }
            }
            else
            {
                mouseMoved = false;
            }
        }

        private void openClosePanel_Click(object sender, EventArgs e)
        {
            if (Visibility == VisibilityTypes.PartiallyVisible)
            {
                Visibility = VisibilityTypes.Visible;
                SetLocation();
            }
            else
            {
                // It must already be Visible.
                Visibility = VisibilityTypes.Hidden;
                SetLocation();
            }
        }

        private void eyedropper_MouseDown(object sender, MouseEventArgs e)
        {
            eyedropper.BackColor = Color.FromArgb(204, 205, 207);
        }

        private void eyedropper_MouseUp(object sender, MouseEventArgs e)
        {
            eyedropper.BackColor = Color.FromArgb(224, 225, 227);
        }

        private void eyedropper_MouseLeave(object sender, EventArgs e)
        {
            eyedropper.BackColor = Color.FromArgb(244, 245, 247);
        }

        private void exitPanel_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(229, 54, 35);
        }

        private void exitPanel_MouseUp(object sender, MouseEventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(229, 54, 35);
        }

        private void exitPanel_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(249, 74, 55);
        }

        private void exitPanel_MouseDown(object sender, MouseEventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(209, 34, 15);
        }

        private void exitPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Save changes.

                colorDialog.Dispose();

                timer.Stop();
                timer.Enabled = false;
                timer.Dispose();

                this.Close();
            }
        }

        private void openClosePanel_MouseEnter(object sender, EventArgs e)
        {
            openClosePanel.BackColor = Color.FromArgb(204, 205, 207);
        }

        private void openClosePanel_MouseLeave(object sender, EventArgs e)
        {
            openClosePanel.BackColor = Color.FromArgb(224, 225, 227);
        }

        private void pickColorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Assume that we have a color.
                if (colorDialog.Color != null)
                {
                    Color pickedColor = colorDialog.Color;

                    ColorPallette colorPallette = new ColorPallette()
                    {
                        Color = pickedColor
                    };

                    //Program.history = new History();
                    History.Pallette.Add(colorPallette);

                    CreateColorPanel(pickedColor);

                    // We're done. Show the window again.
                    Visibility = VisibilityTypes.Visible;
                    SetLocation();
                }
                else
                {
                    // Figure out what to do here.

                }
            }
        }

        private void CreateColorPanel(Color pickedColor)
        {
            if (pickedColor != null)
            {
                Panel pickedColorPanel = new Panel();
                pickedColorPanel.BackColor = pickedColor;
                pickedColorPanel.Width = 10;
                pickedColorPanel.Height = this.Height;
                pickedColorPanel.Margin = new Padding(0, 0, 0, 0);

                // TODO: Add event handlers for clicking and dragging.
                //pickedColorPanel.MouseDown += PickedColorPanel_MouseDown;
                //pickedColorPanel.MouseMove += PickedColorPanel_MouseMove;
                //pickedColorPanel.MouseUp += PickedColorPanel_MouseUp;
                pickedColorPanel.MouseEnter += PickedColorPanel_MouseEnter;
                pickedColorPanel.MouseLeave += PickedColorPanel_MouseLeave;

                pickedColorPanel.ContextMenu = colorOptionsContextMenu;

                colorHistoryPanel.Controls.Add(pickedColorPanel);
            }
        }

        private void PickedColorPanel_MouseLeave(object sender, EventArgs e)
        {
            eyedropper.BackColor = Color.FromArgb(244, 245, 247);
        }

        private void PickedColorPanel_MouseEnter(object sender, EventArgs e)
        {
            eyedropper.BackColor = (sender as Panel).BackColor;
        }

        //private void PickedColorPanel_MouseUp(object sender, MouseEventArgs e)
        //{
        //    pressing = false;

        //    if((sender as Panel).Dock == DockStyle.None)
        //    {
        //        (sender as Panel).Dock = DockStyle.Left;
        //    }
        //}

        //private void PickedColorPanel_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if(pressing)
        //    {
        //        foreach(Panel panel in colorHistoryPanel.Controls)
        //        {
        //            panel.Location = new Point(panel.Location.X - (lastMouseLocation.X - e.X), panel.Location.Y);
        //        }
        //    }
        //}

        //private void PickedColorPanel_MouseDown(object sender, MouseEventArgs e)
        //{
        //    pressing = true;

        //    lastMouseLocation = e.Location;

        //    if ((sender as Panel).Dock.HasFlag(DockStyle.Left))
        //    {
        //        (sender as Panel).Dock = DockStyle.None;
        //    }
        //}

        private void openClosePanel_MouseUp(object sender, MouseEventArgs e)
        {
            openClosePanel.BackColor = Color.FromArgb(204, 205, 207);

            pressing = false;

            if (mouseMoved)
            {
                if (this.Size.Width > 275)
                {
                    Visibility = VisibilityTypes.Visible;
                    defaultSize = this.Size;
                }
            }
        }

        private void eyedropper_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Visibility = VisibilityTypes.Hidden;
                SetLocation();
            }

            pickingColor = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Color color = GetColorAt(Cursor.Position.X, Cursor.Position.Y);
            eyedropper.BackColor = color;
        }

        public Color GetColorAt(int x, int y)
        {
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics graphics = Graphics.FromImage(screenBitmap))
                graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return screenBitmap.GetPixel(0, 0);
        }

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                PickColorFromScreen();
                pickingColor = false;
                timer.Stop();

                Visibility = VisibilityTypes.Visible;
                SetLocation();
            }
        }

        private void eyedropper_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PickColorFromScreen();
                pickingColor = false;
                timer.Stop();

                Visibility = VisibilityTypes.Visible;
                SetLocation();
            }
        }

        private void informationPanel_MouseEnter(object sender, EventArgs e)
        {
            informationPanel.BackColor = Color.FromArgb(212, 216, 220);
        }

        private void informationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            informationPanel.BackColor = Color.FromArgb(192, 196, 200);
        }

        private void informationPanel_MouseUp(object sender, MouseEventArgs e)
        {
            informationPanel.BackColor = Color.FromArgb(212, 216, 220);
        }

        private void informationPanel_MouseLeave(object sender, EventArgs e)
        {
            informationPanel.BackColor = Color.FromArgb(232, 236, 240);
        }

        private void informationPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Visibility = VisibilityTypes.Hidden;
                SetLocation();

                using (About aboutDialog = new About())
                {
                    if (aboutDialog.ShowDialog(this) == DialogResult.OK)
                    {
                    }

                    Visibility = VisibilityTypes.Visible;
                    SetLocation();
                }
            }
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            // Save Color Pallette.
            if ((Program.history == null ? false : History.Pallette.Count >= 1))
            {
                History.Save(Program.ColorHistoryFilePath);
            }

            // Dispose of unused resources.

            // Allow the program to exit.
            e.Cancel = false;
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            if (History.Pallette != null && History.Pallette.Count >= 1)
            {
                foreach (ColorPallette pallette in History.Pallette)
                {
                    CreateColorPanel(pallette.Color);
                }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            menuItem3.Checked = false;
            menuItem4.Checked = false;
            menuItem5.Checked = false;
            menuItem2.Checked = true;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            menuItem4.Checked = false;
            menuItem2.Checked = false;
            menuItem5.Checked = false;
            menuItem3.Checked = true;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            menuItem3.Checked = false;
            menuItem2.Checked = false;
            menuItem5.Checked = false;
            menuItem4.Checked = true;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear your History?", "Clear History Confirmation", buttons: MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                // Clear the history.
                Program.history = null;
                colorHistoryPanel.Controls.Clear();

                History.Pallette.Clear();
                History.Delete(Program.ColorHistoryFilePath);
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

            menuItem3.Checked = false;
            menuItem2.Checked = false;
            menuItem4.Checked = false;
            menuItem5.Checked = true;
        }
    }
}