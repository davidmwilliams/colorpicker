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
    public partial class ColorOptions : Form
    {
        public static bool focused;
        private Color originalSelectedColor;

        public enum ColorTypes
        {
            CMYK,
            HEX,
            HSB,
            RGB
        }

        public static ColorTypes SelectedColorType { get; set; }

        public static Color SelectedColor { get; set; }

        public ColorOptions()
        {
            InitializeComponent();
        }

        private void ColorOptions_Shown(object sender, EventArgs e)
        {
            originalSelectedColor = SelectedColor;

            rValueTextField.Text = SelectedColor.R.ToString();
            gValueTextField.Text = SelectedColor.G.ToString();
            bValueTextField.Text = SelectedColor.B.ToString();
            aValueTextField.Text = aTrackBar.Value.ToString();

            redLine.ChangePositionOnSlider(SelectedColor.R);
            greenLine.ChangePositionOnSlider(SelectedColor.G);
            blueLine.ChangePositionOnSlider(SelectedColor.B);

            redLine.ManuallySelectedColor = SelectedColor;
            greenLine.ManuallySelectedColor = SelectedColor;
            blueLine.ManuallySelectedColor = SelectedColor;

            redLine.ManuallySelectedColor = SelectedColor;
            greenLine.ManuallySelectedColor = SelectedColor;
            blueLine.ManuallySelectedColor = SelectedColor;

            SetChosenColor();


            int r, g, b;
            Int32.TryParse(rValueTextField.Text, out r);
            Int32.TryParse(gValueTextField.Text, out g);
            Int32.TryParse(bValueTextField.Text, out b);

            colorPanel.BackColor = Color.FromArgb(r, g, b);
        }

        private void SetChosenColor()
        {
            colorPanel.BackColor = SelectedColor;

            switch (SelectedColorType)
            {
                case ColorTypes.RGB:
                    selectedColorStyleComboBox.Text = "RGB";
                    break;
                case ColorTypes.HSB:
                    selectedColorStyleComboBox.Text = "HSB";
                    break;
                case ColorTypes.CMYK:
                    selectedColorStyleComboBox.Text = "CMYK";
                    break;
                case ColorTypes.HEX:
                    selectedColorStyleComboBox.Text = "HEX";
                    break;
            }

            aTrackBar.Value = SelectedColor.A;
            colorNameLabel.Text = SelectedColor.Name; 
            colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        //private void rTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        //    SelectedColor = colorPanel.BackColor;
        //    colorNameLabel.Text = SelectedColor.Name;
        //    rValueTextField.Text = rTrackBar.Value.ToString();
        //}

        //private void gTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        //    SelectedColor = colorPanel.BackColor;
        //    colorNameLabel.Text = SelectedColor.Name;
        //    gValueTextField.Text = gTrackBar.Value.ToString();
        //}

        //private void bTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        //    SelectedColor = colorPanel.BackColor;
        //    colorNameLabel.Text = SelectedColor.Name;
        //    bValueTextField.Text = bTrackBar.Value.ToString();
        //}

        private void okButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            SelectedColor = colorPanel.BackColor;

            this.DialogResult = DialogResult.OK;
        }

        private void selectedColorStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (selectedColorStyleComboBox.SelectedText)
            {
                case "CMYK":
                    break;
                case "HEX":
                    break;
                case "HSB":
                    break;
                case "HSL":
                    break;
                case "RGB":
                    break;
            }
        }

        private void colorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FullScreenWindow.SelectedColor = colorPanel.BackColor;

                using (FullScreenWindow fullScreenWindow = new FullScreenWindow())
                {
                    if (fullScreenWindow.ShowDialog() == DialogResult.OK)
                    {
                        // TODO: Something.
                    }
                }
            }
        }

        private void addColorButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            SelectedColor = colorPanel.BackColor;
            Window.selectedColors.Add(SelectedColor);
            focused = true;
            Window.ActiveForm.Activate();
        }

        private void resetColorChoiceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colorPanel.BackColor = originalSelectedColor;
            SelectedColor = originalSelectedColor;

            rValueTextField.Text = SelectedColor.R.ToString();
            gValueTextField.Text = SelectedColor.G.ToString();
            bValueTextField.Text = SelectedColor.B.ToString();
        }

        private void rValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(rValueTextField.Text, out colorValue);

            redLine.ChangePositionOnSlider(colorValue);
            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

            //rTrackBar.Value = colorValue;
        }

        private void gValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(gValueTextField.Text, out colorValue);

            greenLine.ChangePositionOnSlider(colorValue);
            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

            //gTrackBar.Value = colorValue;
        }

        private void bValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(bValueTextField.Text, out colorValue);

            blueLine.ChangePositionOnSlider(colorValue);
            colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

            colorNameLabel.Text = SelectedColor.Name;
            colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

            //bTrackBar.Value = colorValue;
        }

        public Color GetColor(int a, string red, string green, string blue)
        {
            int r, g, b;

            Int32.TryParse(red, out r);
            Int32.TryParse(green, out g);
            Int32.TryParse(blue, out b);

            return Color.FromArgb(a, r, g, b);
        }

        private void rMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(rValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                rValueTextField.Text = (value - 1).ToString();

            redLine.ChangePositionOnSlider(value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            colorPanel.BackColor = Color.FromArgb(aTrackBar.Value, SelectedColor.R, SelectedColor.G, SelectedColor.B);
        }

        private void rPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(rValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                rValueTextField.Text = (value + 1).ToString();

            redLine.ChangePositionOnSlider(value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void gMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(gValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                gValueTextField.Text = (value - 1).ToString();

            greenLine.ChangePositionOnSlider(value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void gPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(gValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                gValueTextField.Text = (value + 1).ToString();

            greenLine.ChangePositionOnSlider(value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void bMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(bValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                bValueTextField.Text = (value - 1).ToString();

            blueLine.ChangePositionOnSlider(value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void bPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(bValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                bValueTextField.Text = (value + 1).ToString();

            blueLine.ChangePositionOnSlider(value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void aTrackBar_Scroll(object sender, EventArgs e)
        {
            //colorPanel.BackColor = Color.FromArgb(aTrackBar.Value, rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

            aValueTextField.Text = aTrackBar.Value.ToString();
        }

        private void aValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(aValueTextField.Text, out colorValue);

            //aTrackBar.Value = colorValue; colorPanel.BackColor = Color.FromArgb(aTrackBar.Value, rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            redLine.ChangePositionOnSlider(colorValue);

            colorNameLabel.Text = SelectedColor.Name; colorPanel.BackColor = GetColor(aTrackBar.Value, rValueTextField.Text, gValueTextField.Text, bValueTextField.Text);

        }

        private void aMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(aValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                aValueTextField.Text = (value - 1).ToString();
        }

        private void aPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(aValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                aValueTextField.Text = (value + 1).ToString();
        }

        private void redLine_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = (sender as RGBLine).ManuallySelectedColor;
            colorPanel.BackColor = color;
            int number;

            number = colorPanel.BackColor.R;
            rValueTextField.Text = number.ToString();

            int r, g, b;
            Int32.TryParse(rValueTextField.Text, out r);
            Int32.TryParse(gValueTextField.Text, out g);
            Int32.TryParse(bValueTextField.Text, out b);

            colorPanel.BackColor = Color.FromArgb(r, g, b);

            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
        }

        private void greenLine_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = (sender as RGBLine).ManuallySelectedColor;
            colorPanel.BackColor = color;
            int number;

            number = colorPanel.BackColor.G;
            gValueTextField.Text = number.ToString();

            int r, g, b;
            Int32.TryParse(rValueTextField.Text, out r);
            Int32.TryParse(gValueTextField.Text, out g);
            Int32.TryParse(bValueTextField.Text, out b);

            colorPanel.BackColor = Color.FromArgb(r, g, b);

            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
        }

        private void blueLine_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = (sender as RGBLine).ManuallySelectedColor;
            colorPanel.BackColor = color;
            int number;

            number = colorPanel.BackColor.B;
            bValueTextField.Text = number.ToString();

            int r, g, b;
            Int32.TryParse(rValueTextField.Text, out r);
            Int32.TryParse(gValueTextField.Text, out g);
            Int32.TryParse(bValueTextField.Text, out b);

            colorPanel.BackColor = Color.FromArgb(r, g, b);

            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;

            //    colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            //    SelectedColor = colorPanel.BackColor;
            //    colorNameLabel.Text = SelectedColor.Name;
            //    rValueTextField.Text = rTrackBar.Value.ToString();
        }
    }
}
