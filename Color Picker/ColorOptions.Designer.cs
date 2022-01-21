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
            this.addColorButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.resetColorChoiceLink = new System.Windows.Forms.LinkLabel();
            this.rValueTextField = new System.Windows.Forms.TextBox();
            this.gValueTextField = new System.Windows.Forms.TextBox();
            this.bValueTextField = new System.Windows.Forms.TextBox();
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
            this.colorPanel.Size = new System.Drawing.Size(329, 37);
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
            this.selectedColorStyleComboBox.Location = new System.Drawing.Point(257, 57);
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
            this.rTrackBar.Size = new System.Drawing.Size(281, 45);
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
            this.separator1.Size = new System.Drawing.Size(329, 1);
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
            this.gTrackBar.Size = new System.Drawing.Size(281, 45);
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
            this.bTrackBar.Size = new System.Drawing.Size(281, 45);
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
            this.okButton.Location = new System.Drawing.Point(259, 310);
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
            // addColorButton
            // 
            this.addColorButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.addColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.addColorButton.BackgroundImageLayout = null;
            this.addColorButton.BackgroundTexture = null;
            this.addColorButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.addColorButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.addColorButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.addColorButton.BorderThickness = 1F;
            this.addColorButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.addColorButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.addColorButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.addColorButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.addColorButton.CheckmarkThickness = 0F;
            this.addColorButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.addColorButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.addColorButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.addColorButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.addColorButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.addColorButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.addColorButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.addColorButton.FocusedColor = System.Drawing.Color.Empty;
            this.addColorButton.HasBorder = true;
            this.addColorButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.addColorButton.Location = new System.Drawing.Point(228, 57);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.RequiresConfirmation = false;
            this.addColorButton.SeparatorDistance = 0;
            this.addColorButton.Size = new System.Drawing.Size(23, 23);
            this.addColorButton.StyleButtonSeparately = false;
            this.addColorButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.addColorButton.TabIndex = 11;
            this.addColorButton.Text = "+";
            this.tip.SetToolTip(this.addColorButton, "Add this color to the Color Strip without closing the window.");
            this.addColorButton.UsingTexturedBackground = false;
            this.addColorButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.addColorButton_Clicked);
            // 
            // resetColorChoiceLink
            // 
            this.resetColorChoiceLink.AutoSize = true;
            this.resetColorChoiceLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.resetColorChoiceLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.resetColorChoiceLink.Location = new System.Drawing.Point(12, 315);
            this.resetColorChoiceLink.Name = "resetColorChoiceLink";
            this.resetColorChoiceLink.Size = new System.Drawing.Size(35, 15);
            this.resetColorChoiceLink.TabIndex = 12;
            this.resetColorChoiceLink.TabStop = true;
            this.resetColorChoiceLink.Text = "Reset";
            this.resetColorChoiceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetColorChoiceLink_LinkClicked);
            // 
            // rValueTextField
            // 
            this.rValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.rValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rValueTextField.Location = new System.Drawing.Point(301, 128);
            this.rValueTextField.Name = "rValueTextField";
            this.rValueTextField.Size = new System.Drawing.Size(42, 23);
            this.rValueTextField.TabIndex = 13;
            this.rValueTextField.TextChanged += new System.EventHandler(this.rValueTextField_TextChanged);
            // 
            // gValueTextField
            // 
            this.gValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.gValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gValueTextField.Location = new System.Drawing.Point(301, 194);
            this.gValueTextField.Name = "gValueTextField";
            this.gValueTextField.Size = new System.Drawing.Size(42, 23);
            this.gValueTextField.TabIndex = 14;
            this.gValueTextField.TextChanged += new System.EventHandler(this.gValueTextField_TextChanged);
            // 
            // bValueTextField
            // 
            this.bValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.bValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bValueTextField.Location = new System.Drawing.Point(301, 260);
            this.bValueTextField.Name = "bValueTextField";
            this.bValueTextField.Size = new System.Drawing.Size(42, 23);
            this.bValueTextField.TabIndex = 15;
            this.bValueTextField.TextChanged += new System.EventHandler(this.bValueTextField_TextChanged);
            // 
            // ColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(356, 347);
            this.Controls.Add(this.bValueTextField);
            this.Controls.Add(this.gValueTextField);
            this.Controls.Add(this.rValueTextField);
            this.Controls.Add(this.resetColorChoiceLink);
            this.Controls.Add(this.addColorButton);
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
            this.MinimumSize = new System.Drawing.Size(372, 386);
            this.Name = "ColorOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Options";
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
        private ALMSTWKND.UI.WindowsForms.Controls.Button addColorButton;
        private System.Windows.Forms.LinkLabel resetColorChoiceLink;
        private System.Windows.Forms.TextBox rValueTextField;
        private System.Windows.Forms.TextBox gValueTextField;
        private System.Windows.Forms.TextBox bValueTextField;
    }
}