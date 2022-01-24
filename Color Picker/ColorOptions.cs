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

            SetChosenColor();

            rValueTextField.Text = rTrackBar.Value.ToString();
            gValueTextField.Text = gTrackBar.Value.ToString();
            bValueTextField.Text = bTrackBar.Value.ToString();
            aValueTextField.Text = aTrackBar.Value.ToString();

        }

        private void SetChosenColor()
        {
            colorPanel.BackColor = SelectedColor;

            switch(SelectedColorType)
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

            rTrackBar.Value = SelectedColor.R;
            gTrackBar.Value = SelectedColor.G;
            bTrackBar.Value = SelectedColor.B;
            aTrackBar.Value = SelectedColor.A;
        }

        private void rTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            rValueTextField.Text = rTrackBar.Value.ToString();
        }

        private void gTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            gValueTextField.Text = gTrackBar.Value.ToString();
        }

        private void bTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            bValueTextField.Text = bTrackBar.Value.ToString();
        }

        private void okButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            SelectedColor = colorPanel.BackColor;            

            this.DialogResult = DialogResult.OK;
        }

        private void selectedColorStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(selectedColorStyleComboBox.SelectedText)
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
                    if(fullScreenWindow.ShowDialog() == DialogResult.OK)
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

            rTrackBar.Value = SelectedColor.R;
            gTrackBar.Value = SelectedColor.G;
            bTrackBar.Value = SelectedColor.B;

            rValueTextField.Text = SelectedColor.R.ToString();
            gValueTextField.Text = SelectedColor.G.ToString();
            bValueTextField.Text = SelectedColor.B.ToString();
        }

        private void rValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(rValueTextField.Text, out colorValue);

            rTrackBar.Value = colorValue;
        }

        private void gValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(gValueTextField.Text, out colorValue);

            gTrackBar.Value = colorValue;
        }

        private void bValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(bValueTextField.Text, out colorValue);

            bTrackBar.Value = colorValue;
        }

        private void rMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(rValueTextField.Text, out value);

            if(value >= 0 && value <= 254)
                rValueTextField.Text = (value - 1).ToString();
        }

        private void rPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(rValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                rValueTextField.Text = (value + 1).ToString();
        }

        private void gMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(gValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                gValueTextField.Text = (value - 1).ToString();
        }

        private void gPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(gValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                gValueTextField.Text = (value + 1).ToString();
        }

        private void bMinusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(bValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                bValueTextField.Text = (value - 1).ToString();
        }

        private void bPlusButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            int value;
            Int32.TryParse(bValueTextField.Text, out value);

            if (value >= 0 && value <= 254)
                bValueTextField.Text = (value + 1).ToString();
        }

        private void aTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(aTrackBar.Value, rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
            aValueTextField.Text = aTrackBar.Value.ToString();
        }

        private void aValueTextField_TextChanged(object sender, EventArgs e)
        {
            int colorValue;

            Int32.TryParse(aValueTextField.Text, out colorValue);

            aTrackBar.Value = colorValue; colorPanel.BackColor = Color.FromArgb(aTrackBar.Value, rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
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
    }
}
