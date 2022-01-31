using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class About : Form
    {
        public enum Guides
        {
            None = 0,
            PDF,
            GuidedTour
        }

        public static Guides Guide { get; set; }

        public About()
        {
            InitializeComponent();
        }

        private void About_Shown(object sender, EventArgs e)
        {
            // Get the App version and display it to the user.
            Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            versionLabel.Text = "v" + appVersion.Major + "." + appVersion.Minor + "." + appVersion.Build + ".";

            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void okButton_Clicked(object sender, ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "ColorPickerUserGuide.pdf");

            Process.Start(filePath);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:talk@colorpicker.website");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:talk@colorpicker.website");
        }
    }
}
