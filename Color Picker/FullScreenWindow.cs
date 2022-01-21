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
    public partial class FullScreenWindow : Form
    {
        public static Color SelectedColor { get; set; }

        public FullScreenWindow()
        {
            InitializeComponent();
        }

        private void FullScreenWindow_Load(object sender, EventArgs e)
        {
            this.BackColor = SelectedColor;

            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.CenterToScreen();
        }

        private void FullScreenWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FullScreenWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
