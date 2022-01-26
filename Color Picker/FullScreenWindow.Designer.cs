namespace Color_Picker
{
    partial class FullScreenWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rgbLine1 = new Color_Picker.RGBLine();
            this.SuspendLayout();
            // 
            // rgbLine1
            // 
            this.rgbLine1.ChosenColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rgbLine1.LineThickness = 0F;
            this.rgbLine1.Location = new System.Drawing.Point(12, 12);
            this.rgbLine1.MaximumSize = new System.Drawing.Size(255, 1);
            this.rgbLine1.MinimumSize = new System.Drawing.Size(255, 12);
            this.rgbLine1.Name = "rgbLine1";
            this.rgbLine1.SelectedColor = Color_Picker.RGBLine.Colors.Shade;
            this.rgbLine1.Size = new System.Drawing.Size(255, 12);
            this.rgbLine1.TabIndex = 1;
            this.rgbLine1.Text = "rgbLine1";
            // 
            // FullScreenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 363);
            this.Controls.Add(this.rgbLine1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FullScreenWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.FullScreenWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullScreenWindow_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FullScreenWindow_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private RGBLine rgbLine1;
    }
}