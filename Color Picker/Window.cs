using Color_Picker.Properties;
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

        public static AppSettings.LocalSettings localSettings;
        public Timer timer = new Timer();
        public ColorDialog colorDialog;
        public static Color selectedColor;
        private Panel selectedColorPanel;
        private bool mouseMoved;
        public int defaultColorPanelWidth;
        public static List<Color> selectedColors;
        public static VisibilityTypes Visibility { get; set; }
        public int transparency;
        public Size defaultSize;
        public Point lastMouseLocation;
        public bool pressing;
        private bool pickingColor;
        private bool inSelectMode;
        private bool shiftDown;
        private bool moving;
        private bool assumeClicked;

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
            selectedColors = new List<Color>();
            localSettings = new AppSettings.LocalSettings();

            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.AnyColor = true;

            defaultColorPanelWidth = 10;

            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            if (localSettings.DefaultWindowSize.Width > 275)
            {
                defaultSize = new Size(localSettings.DefaultWindowSize.Width, 32);
            }
            else
            {
                defaultSize = new Size(275, 32);
            }

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

        private static string HexConverter(Color c)
        {
            byte r = c.R;
            string str = r.ToString("X2");
            r = c.G;
            string str1 = r.ToString("X2");
            r = c.B;
            string str2 = string.Concat(str, str1, r.ToString("X2"));
            return str2;
        }

        private void PickColorFromScreen()
        {
            Color selectedColor = GetColorAt(Cursor.Position.X, Cursor.Position.Y);

            if (selectedColor != null)
            {
                //ColorPallette colorPallette = new ColorPallette()
                //{
                //    Color = selectedColor,
                //    ColorPanelWidth = defaultColorPanelWidth
                //};

                //Program.history = new History();
                //History.Pallettes.Add(colorPallette);

                CreateColorPanel(selectedColor, defaultColorPanelWidth);
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
            using (ColorWheelDialog dialog = new ColorWheelDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (dialog.Colors != null)
                    {
                        foreach (Color color in dialog.Colors)
                        {
                            CreateColorPanel(color, defaultColorPanelWidth);
                        }
                    }
                }
            }

            // We're done. Show the window again.
            Visibility = VisibilityTypes.Visible;
            SetLocation();
        }

        private void CreateColorPanel(Color pickedColor, int colorPanelWidth)
        {
            if (pickedColor != null)
            {
                Panel pickedColorPanel = new Panel();
                pickedColorPanel.BackColor = pickedColor;
                pickedColorPanel.Width = colorPanelWidth;
                pickedColorPanel.Height = this.Height;
                pickedColorPanel.Margin = new Padding(0, 0, 0, 0);

                pickedColorPanel.MouseEnter += PickedColorPanel_MouseEnter;
                pickedColorPanel.MouseLeave += PickedColorPanel_MouseLeave;
                pickedColorPanel.MouseClick += PickedColorPanel_MouseClick;
                pickedColorPanel.MouseWheel += PickedColorPanel_MouseWheel;
                pickedColorPanel.PreviewKeyDown += PickedColorPanel_PreviewKeyDown;
                pickedColorPanel.MouseDown += PickedColorPanel_MouseDown;
                pickedColorPanel.MouseMove += PickedColorPanel_MouseMove;
                pickedColorPanel.MouseUp += PickedColorPanel_MouseUp;

                pickedColorPanel.ContextMenu = colorOptionsContextMenu;

                colorHistoryPanel.Controls.Add(pickedColorPanel);
            }
        }

        private void PickedColorPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;
            moving = false;
            assumeClicked = false;
        }

        private void PickedColorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressing)
            {
                moving = true;

                colorHistoryPanel.Left = colorHistoryPanel.Left - (lastMouseLocation.X - e.Location.X) + 5;
            }
        }

        private void PickedColorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int left = colorHistoryPanel.Left;

            if (e.Clicks == 2)
            {
                pressing = true;
                if (colorHistoryPanel.Dock != DockStyle.None)
                {
                    colorHistoryPanel.Dock = DockStyle.None;
                }

                colorHistoryPanel.AutoSize = true;
                colorHistoryPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                colorHistoryPanel.Left = left + 5;
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                foreach (Panel panel in colorHistoryPanel.Controls)
                {
                    if (panel.Height == 20)
                    {
                        RemoveColorPanel(panel);
                    }
                }
            }

            return true;
        }

        private void PickedColorPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Hi.");
        }

        private void PickedColorPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            selectedColor = (sender as Panel).BackColor;
            transparency = (int)selectedColor.A;
            Color oldColor = selectedColor;

            if (e.Delta == 120)
            {
                if (transparency < 255)
                {
                    // Change the transparency.
                    transparency++;

                    // Update it with selected Color and BackColor of panel.
                    selectedColor = Color.FromArgb(transparency, oldColor.R, oldColor.G, oldColor.B);
                    (sender as Panel).BackColor = Color.FromArgb(transparency, oldColor.R, oldColor.G, oldColor.B);
                    eyedropper.BackColor = selectedColor;

                    this.tip.ToolTipTitle = "Transparency:";
                    this.tip.SetToolTip((sender as Panel), transparency.ToString());
                }
            }
            else
            {
                if (transparency > 0)
                {
                    transparency--;

                    // Update it with selected Color and BackColor of panel.
                    selectedColor = Color.FromArgb(transparency, oldColor.R, oldColor.G, oldColor.B);
                    (sender as Panel).BackColor = Color.FromArgb(transparency, oldColor.R, oldColor.G, oldColor.B);
                    eyedropper.BackColor = selectedColor;

                    this.tip.ToolTipTitle = "Transparency:";
                    this.tip.SetToolTip((sender as Panel), transparency.ToString());
                }
            }
        }

        public void PickedColorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            assumeClicked = true;
            if (e.Button == MouseButtons.Right)
            {
                selectedColor = (sender as Panel).BackColor;
                selectedColorPanel = (sender as Panel);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (inSelectMode)
                {
                    if ((sender as Panel).Height <= 20)
                    {
                        (sender as Panel).Height = this.Height;
                    }
                    else
                    {
                        (sender as Panel).Height = 20;
                    }
                }
                else
                {
                    if ((sender as Panel).Height <= 20)
                    {
                        (sender as Panel).Height = this.Height;
                    }
                }

                shiftDown = false;

                selectedColor = (sender as Panel).BackColor;
                selectedColorPanel = (sender as Panel);

                foreach (MenuItem item in menuItem1.MenuItems)
                {
                    if (item.Checked)
                    {
                        switch (item.Text)
                        {
                            case "CMYK":
                                Clipboard.SetText(Convert.ToCMYK(selectedColor.R, selectedColor.G, selectedColor.B));
                                break;
                            case "HEX":
                                Clipboard.SetText(HexConverter(selectedColor));
                                break;
                            case "HSB":
                                Clipboard.SetText(selectedColor.GetHue() + "," + selectedColor.GetSaturation() + "," + selectedColor.GetBrightness());
                                break;
                            case "RGB":
                                int aValue = selectedColor.A;

                                if (aValue < 255)
                                {
                                    Clipboard.SetText(selectedColor.A + ", " + selectedColor.R + ", " + selectedColor.G + ", " + selectedColor.B);
                                }
                                else
                                {
                                    Clipboard.SetText(selectedColor.R + ", " + selectedColor.G + ", " + selectedColor.B);
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void PickedColorPanel_MouseLeave(object sender, EventArgs e)
        {
            eyedropper.BackColor = Color.FromArgb(244, 245, 247);

            this.tip.ToolTipTitle = "Hint:";
        }

        private void PickedColorPanel_MouseEnter(object sender, EventArgs e)
        {
            eyedropper.BackColor = (sender as Panel).BackColor;
        }

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

            // Save settings.
            string settings = defaultColorPanelWidth + "," + defaultSize.Width + ";";
            File.WriteAllText(Program.AppDataDirectory + "colorpicker.settings", settings);

            List<Color> colors = new List<Color>();

            foreach (Panel panel in colorHistoryPanel.Controls)
            {
                colors.Add(Color.FromArgb(panel.BackColor.A, panel.BackColor.R, panel.BackColor.G, panel.BackColor.B));
            }

            Strip.Save(colors, Program.ColorPickerSettingsFilePath);


            // Allow the program to exit.
            e.Cancel = false;
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            List<Color> colors = AppSettings.GetStrips(Program.AppDataDirectory);

            if (File.Exists(Program.AppDataDirectory + "colorpicker.settings"))
            {
                string settings = File.ReadAllText(Program.AppDataDirectory + "colorpicker.settings");

                if(!String.IsNullOrEmpty(settings))
                {
                    string[] parts = settings.Split(',');

                    int width = 275;
                    parts[1] = parts[1].TrimEnd(';');

                    Int32.TryParse(parts[0], out defaultColorPanelWidth);
                    Int32.TryParse(parts[1], out width);

                    defaultSize = new Size(width, 32);
                }
            }
            else
            {
                defaultSize = new Size(275, 32);
                this.Size = defaultSize;
                defaultColorPanelWidth = 10;
            }

            if (colors != null)
            {
                foreach (Color color in colors)
                {
                    CreateColorPanel(color, 10);
                }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            /*HEXMenuItem.Checked = false;*/
            CMYKMenuItem.Checked = false;
            HSBMenuItem.Checked = false;
            RGBMenuItem.Checked = true;

            // Copy the RGB value to the user's Clipboard.
            if(selectedColor != null)
            {
                int aValue = selectedColor.A;

                if (aValue < 255)
                {
                    Clipboard.SetText(selectedColor.A + ", " + selectedColor.R + ", " + selectedColor.G + ", " + selectedColor.B);
                }
                else
                {
                    Clipboard.SetText(selectedColor.R + ", " + selectedColor.G + ", " + selectedColor.B);
                }

            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            CMYKMenuItem.Checked = false;
            RGBMenuItem.Checked = false;
            HSBMenuItem.Checked = false;
            /*HEXMenuItem.Checked = true;*/

            string hexCode = HexConverter(selectedColor);
            Clipboard.SetText(hexCode);
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            /*HEXMenuItem.Checked = false;*/
            RGBMenuItem.Checked = false;
            HSBMenuItem.Checked = false;
            CMYKMenuItem.Checked = true;

            string result = Convert.ToCMYK(selectedColor.R, selectedColor.G, selectedColor.B);
            Clipboard.SetText(result);
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            /*HEXMenuItem.Checked = false;*/
            RGBMenuItem.Checked = false;
            CMYKMenuItem.Checked = false;
            HSBMenuItem.Checked = true;

            Clipboard.SetText(selectedColor.GetHue() + "," + selectedColor.GetSaturation() + "," + selectedColor.GetBrightness());

        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear your History?", "Clear History Confirmation", buttons: MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                // Clear the history.
                colorHistoryPanel.Controls.Clear();
            }
        }

        private void useWideColorPanelsMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as MenuItem).Checked)
            {
                defaultColorPanelWidth = 10;
                (sender as MenuItem).Checked = false;

                ChangeColorPanelWidth();
            }
            else
            {
                defaultColorPanelWidth = 24;
                (sender as MenuItem).Checked = true;

                ChangeColorPanelWidth();
            }
        }

        private void ChangeColorPanelWidth()
        {
            foreach (Panel colorPanel in colorHistoryPanel.Controls)
            {
                if (!colorPanel.IsDisposed)
                {
                    colorPanel.Width = defaultColorPanelWidth;
                }
            }
        }

        private void eyedropper_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.Copy;
                
                string input = e.Data.GetData(DataFormats.Text).ToString();
                if (!string.IsNullOrEmpty(input))
                {
                    if (input.StartsWith("#"))
                    {
                        if (input.Length == 7 || input.Length == 9 || input.Length == 8)
                        {
                            // Test: #ee55cc ee44cc #cc3366
                            // It's probably hex.
                            // I'll make a better solution later.
                            Color droppedColor = ColorTranslator.FromHtml(input);
                            eyedropper.BackColor = droppedColor;
                        }
                    }
                    else
                    {
                        if (input.Length == 6)
                        {
                            // It's probably hex.
                            // Prepend a hash.

                            input = "#" + e.Data.GetData(DataFormats.Text).ToString();
                            Color droppedColor = ColorTranslator.FromHtml(input);

                            eyedropper.BackColor = droppedColor;
                        }
                    }
                }
            }
        }

        public void eyedropper_DragDrop(object sender, DragEventArgs e)
        {
            string input = e.Data.GetData(DataFormats.Text).ToString();
            if (!string.IsNullOrEmpty(input))
            {
                if (input.StartsWith("#"))
                {
                    if(input.Length == 7 || input.Length == 9 || input.Length == 8)
                    {
                        // Test: #ee55cc ee44cc
                        // It's probably hex.
                        // I'll make a better solution later.
                        Color droppedColor = ColorTranslator.FromHtml(input);

                        CreateColorPanel(droppedColor, defaultColorPanelWidth);
                    }
                }
                else
                {
                    if(input.Length == 6)
                    {
                        // It's probably hex.
                        // Prepend a hash.

                        input = "#" + e.Data.GetData(DataFormats.Text).ToString();
                        Color droppedColor = ColorTranslator.FromHtml(input);

                        CreateColorPanel(droppedColor, defaultColorPanelWidth);
                    }
                }
            }
        }

        private void menuItem2_Click_1(object sender, EventArgs e)
        {
            RemoveColorPanel(sender as Panel);
        }

        private void RemoveColorPanel(Panel panel)
        {
            // Remove the Color Panel.
            if (selectedColorPanel != null && !selectedColorPanel.IsDisposed)
            {
                //ColorPallette pallette = History.Pallettes.Where(x => x.Color == selectedColorPanel.BackColor).FirstOrDefault();

                selectedColorPanel.Dispose();
                selectedColorPanel = null;
                colorHistoryPanel.Controls.Remove(selectedColorPanel);

                //if (pallette != null)
                //{
                //    History.Pallettes.Remove(pallette);
                //}
            }

            if(panel != null && !panel.IsDisposed)
            {
                //ColorPallette pallette = History.Pallettes.Where(x => x.Color == panel.BackColor).FirstOrDefault();

                panel.Dispose();
                panel = null;
                colorHistoryPanel.Controls.Remove(panel);

                //if(pallette != null)
                //{
                //    History.Pallettes.Remove(pallette);
                //}
            }
        }

        public void ChangeEyeDropperBackgroundColor(Color color)
        {
            eyedropper.BackColor = color;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            ColorOptions.SelectedColor = selectedColor;

            if (RGBMenuItem.Checked)
                ColorOptions.SelectedColorType = ColorOptions.ColorTypes.RGB;
            else if (CMYKMenuItem.Checked)
                ColorOptions.SelectedColorType = ColorOptions.ColorTypes.CMYK;
            else if (HEXMenuItem.Checked)
                ColorOptions.SelectedColorType = ColorOptions.ColorTypes.HEX;
            else if(HSBMenuItem.Checked)
                ColorOptions.SelectedColorType = ColorOptions.ColorTypes.HSB;
            
            using (ColorOptions colorOptions = new ColorOptions())
            {
                if(colorOptions.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: Something.
                    if(ColorOptions.SelectedColor != null)
                    {
                        selectedColor = ColorOptions.SelectedColor;

                        //ColorPallette colorPallette = new ColorPallette()
                        //{
                        //    Color = selectedColor,
                        //    ColorPanelWidth = defaultColorPanelWidth
                        //};

                        //Program.history = new History();
                        //History.Pallettes.Add(colorPallette);

                        CreateColorPanel(selectedColor, defaultColorPanelWidth);

                        foreach(Color color in selectedColors)
                        {
                            //ColorPallette thisColorPallette = new ColorPallette()
                            //{
                            //    Color = color,
                            //    ColorPanelWidth = defaultColorPanelWidth
                            //};

                            //History.Pallettes.Add(thisColorPallette);

                            // If they have hit the plus button in the ColorOptions window,
                            // we don't want to add it twice.
                            if(selectedColor != color)
                                CreateColorPanel(color, defaultColorPanelWidth);
                        }

                        Visibility = VisibilityTypes.Visible;
                        SetLocation();
                    }
                }
                else
                {
                    foreach (Color color in selectedColors)
                    {
                        //ColorPallette thisColorPallette = new ColorPallette()
                        //{
                        //    Color = color,
                        //    ColorPanelWidth = defaultColorPanelWidth
                        //};

                        //History.Pallettes.Add(thisColorPallette);

                        CreateColorPanel(color, defaultColorPanelWidth);
                    }

                    Visibility = VisibilityTypes.Visible;
                    SetLocation();
                }
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if(ColorOptions.focused)
            {
                Visibility = VisibilityTypes.PartiallyVisible;
                SetLocation();
            }
        }

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            if ((sender as MenuItem).Checked)
            {
                inSelectMode = false;
                (sender as MenuItem).Checked = false;
            }
            else
            {
                inSelectMode = true;
                (sender as MenuItem).Checked = true;
            }
        }

        private void colorHistoryPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pressing = true;
            lastMouseLocation = e.Location;
        }

        private void colorHistoryPanel_MouseMove(object sender, MouseEventArgs e)
        {
            moving = true;

            if(pressing && moving)
            {
                colorHistoryPanel.Dock = DockStyle.None;
                colorHistoryPanel.Left = colorHistoryPanel.Left - (lastMouseLocation.X + e.Location.X);
            }
        }

        private void colorHistoryPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;
            moving = false;
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                colorHistoryPanel.Dock = DockStyle.Fill;
            }
        }

        private void menuItem5_Click_1(object sender, EventArgs e)
        {
            if ((sender as MenuItem).Checked)
            {
                (sender as MenuItem).Checked = false;

                CMYKMenuItem.Checked = false;
                RGBMenuItem.Checked = false;
                HSBMenuItem.Checked = false;
                //HEXMenuItem.Checked = true;

                string hexCode = HexConverter(selectedColor);
                Clipboard.SetText(hexCode);
            }
            else
            {
                (sender as MenuItem).Checked = true;

                CMYKMenuItem.Checked = false;
                RGBMenuItem.Checked = false;
                HSBMenuItem.Checked = false;
                //HEXMenuItem.Checked = true;

                string hexCode = HexConverter(selectedColor);
                Clipboard.SetText("#" + hexCode);
            }
        }
    }
}