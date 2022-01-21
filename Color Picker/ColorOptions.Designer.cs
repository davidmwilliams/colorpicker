namespace Color_Picker
{
    partial class ColorOptions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorOptions));
            this.colorPanel = new System.Windows.Forms.Panel();
            this.selectedColorStyleComboBox = new System.Windows.Forms.ComboBox();
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.separator1 = new ALMSTWKND.UI.WindowsForms.Controls.Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.okButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.colorNameLabel = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.Location = new System.Drawing.Point(14, 14);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(257, 37);
            this.colorPanel.TabIndex = 0;
            this.tip.SetToolTip(this.colorPanel, "Show this color in fullscreen.");
            this.colorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPanel_MouseClick);
            // 
            // selectedColorStyleComboBox
            // 
            this.selectedColorStyleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedColorStyleComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.selectedColorStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedColorStyleComboBox.FormattingEnabled = true;
            this.selectedColorStyleComboBox.Items.AddRange(new object[] {
            "CMYK",
            "HEX",
            "HSB",
            "HSL",
            "RGB"});
            this.selectedColorStyleComboBox.Location = new System.Drawing.Point(185, 57);
            this.selectedColorStyleComboBox.Name = "selectedColorStyleComboBox";
            this.selectedColorStyleComboBox.Size = new System.Drawing.Size(86, 23);
            this.selectedColorStyleComboBox.TabIndex = 1;
            this.selectedColorStyleComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectedColorStyleComboBox_SelectionChangeCommitted);
            // 
            // rTrackBar
            // 
            this.rTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTrackBar.Location = new System.Drawing.Point(14, 122);
            this.rTrackBar.Maximum = 255;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(257, 45);
            this.rTrackBar.TabIndex = 2;
            this.rTrackBar.Scroll += new System.EventHandler(this.rTrackBar_Scroll);
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.CanHighlight = false;
            this.separator1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.separator1.Direction = "Horizontal";
            this.separator1.DisabledColor = System.Drawing.Color.Empty;
            this.separator1.HighlightColor = System.Drawing.Color.Empty;
            this.separator1.Location = new System.Drawing.Point(14, 86);
            this.separator1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 32);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(257, 1);
            this.separator1.TabIndex = 3;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // gTrackBar
            // 
            this.gTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gTrackBar.Location = new System.Drawing.Point(14, 188);
            this.gTrackBar.Maximum = 255;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(257, 45);
            this.gTrackBar.TabIndex = 5;
            this.gTrackBar.Scroll += new System.EventHandler(this.gTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // bTrackBar
            // 
            this.bTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bTrackBar.Location = new System.Drawing.Point(14, 254);
            this.bTrackBar.Maximum = 255;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(257, 45);
            this.bTrackBar.TabIndex = 7;
            this.bTrackBar.Scroll += new System.EventHandler(this.bTrackBar_Scroll);
            // 
            // okButton
            // 
            this.okButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.okButton.BackgroundImageLayout = null;
            this.okButton.BackgroundTexture = null;
            this.okButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.okButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.okButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.okButton.BorderThickness = 1F;
            this.okButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.okButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.okButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.okButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.okButton.CheckmarkThickness = 0F;
            this.okButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.okButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.okButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.okButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.okButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.okButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.okButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.okButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.okButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.okButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.okButton.FocusedColor = System.Drawing.Color.Empty;
            this.okButton.HasBorder = true;
            this.okButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.okButton.Location = new System.Drawing.Point(187, 310);
            this.okButton.Name = "okButton";
            this.okButton.RequiresConfirmation = false;
            this.okButton.SeparatorDistance = 0;
            this.okButton.Size = new System.Drawing.Size(85, 25);
            this.okButton.StyleButtonSeparately = false;
            this.okButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UsingTexturedBackground = false;
            this.okButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.okButton_Clicked);
            // 
            // colorNameLabel
            // 
            this.colorNameLabel.AutoSize = true;
            this.colorNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(202)))));
            this.colorNameLabel.Location = new System.Drawing.Point(12, 60);
            this.colorNameLabel.Name = "colorNameLabel";
            this.colorNameLabel.Size = new System.Drawing.Size(0, 15);
            this.colorNameLabel.TabIndex = 10;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.tip.ToolTipTitle = "Hint:";
            // 
            // ColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.colorNameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.rTrackBar);
            this.Controls.Add(this.selectedColorStyleComboBox);
            this.Controls.Add(this.colorPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(300, 386);
            this.Name = "ColorOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorOptions_FormClosing);
            this.Shown += new System.EventHandler(this.ColorOptions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ComboBox selectedColorStyleComboBox;
        private System.Windows.Forms.TrackBar rTrackBar;
        private ALMSTWKND.UI.WindowsForms.Controls.Separator separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar bTrackBar;
        private ALMSTWKND.UI.WindowsForms.Controls.Button okButton;
        private System.Windows.Forms.Label colorNameLabel;
        private System.Windows.Forms.ToolTip tip;
    }
}