﻿namespace Color_Picker
{
    partial class RGBLine
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RGBLine
            // 
            this.MaximumSize = new System.Drawing.Size(255, 1);
            this.MinimumSize = new System.Drawing.Size(255, 1);
            this.Size = new System.Drawing.Size(255, 1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RGBLine_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RGBLine_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RGBLine_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
