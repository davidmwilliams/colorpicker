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
            SetChosenColor();
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
        }

        private void rTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
        }

        private void gTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;
        }

        private void bTrackBar_Scroll(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            SelectedColor = colorPanel.BackColor;
            colorNameLabel.Text = SelectedColor.Name;

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

        private void ColorOptions_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
