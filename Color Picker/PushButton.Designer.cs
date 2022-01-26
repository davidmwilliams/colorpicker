namespace Color_Picker
{
    partial class PushButton
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
            // PushButton
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PushButton_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PushButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.PushButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PushButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PushButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
