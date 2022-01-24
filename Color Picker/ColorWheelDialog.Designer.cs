namespace Color_Picker
{
    partial class ColorWheelDialog
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
            this.separator1 = new ALMSTWKND.UI.WindowsForms.Controls.Separator();
            this.addedColorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.applyButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.addColorButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.clearColorsLink = new System.Windows.Forms.LinkLabel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorPanelContextMenu = new System.Windows.Forms.ContextMenu();
            this.removeContextMenuItem = new System.Windows.Forms.MenuItem();
            this.rgbLine1 = new Color_Picker.RGBLine();
            this.colorWheel = new Color_Picker.ColorWheel();
            this.SuspendLayout();
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.CanHighlight = false;
            this.separator1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(116)))), ((int)(((byte)(230)))));
            this.separator1.Direction = "Horizontal";
            this.separator1.DisabledColor = System.Drawing.Color.Empty;
            this.separator1.HighlightColor = System.Drawing.Color.Empty;
            this.separator1.Location = new System.Drawing.Point(12, 360);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(304, 1);
            this.separator1.TabIndex = 1;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            // 
            // addedColorsPanel
            // 
            this.addedColorsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedColorsPanel.AutoSize = true;
            this.addedColorsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addedColorsPanel.Location = new System.Drawing.Point(12, 367);
            this.addedColorsPanel.MinimumSize = new System.Drawing.Size(304, 32);
            this.addedColorsPanel.Name = "addedColorsPanel";
            this.addedColorsPanel.Size = new System.Drawing.Size(304, 32);
            this.addedColorsPanel.TabIndex = 2;
            this.addedColorsPanel.WrapContents = false;
            // 
            // applyButton
            // 
            this.applyButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.applyButton.BackgroundImageLayout = null;
            this.applyButton.BackgroundTexture = null;
            this.applyButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.applyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.applyButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.applyButton.BorderThickness = 1F;
            this.applyButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.applyButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.applyButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.applyButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.applyButton.CheckmarkThickness = 1F;
            this.applyButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.applyButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.applyButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.applyButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.applyButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.applyButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.applyButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.applyButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.applyButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.applyButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.applyButton.FocusedColor = System.Drawing.Color.Empty;
            this.applyButton.HasBorder = true;
            this.applyButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.applyButton.Location = new System.Drawing.Point(241, 410);
            this.applyButton.Name = "applyButton";
            this.applyButton.RequiresConfirmation = true;
            this.applyButton.SeparatorDistance = 25;
            this.applyButton.Size = new System.Drawing.Size(75, 25);
            this.applyButton.StyleButtonSeparately = false;
            this.applyButton.SynchronizeCheckMarkWithBorderSettings = true;
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UsingTexturedBackground = false;
            this.applyButton.Confirmed += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs>(this.applyButton_Confirmed);
            // 
            // addColorButton
            // 
            this.addColorButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.addColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
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
            this.addColorButton.CheckmarkThickness = 1F;
            this.addColorButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.addColorButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.addColorButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.addColorButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.addColorButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.addColorButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.addColorButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.addColorButton.Enabled = false;
            this.addColorButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.addColorButton.FocusedColor = System.Drawing.Color.Empty;
            this.addColorButton.HasBorder = true;
            this.addColorButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.addColorButton.Location = new System.Drawing.Point(160, 410);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.RequiresConfirmation = false;
            this.addColorButton.SeparatorDistance = 25;
            this.addColorButton.Size = new System.Drawing.Size(75, 25);
            this.addColorButton.StyleButtonSeparately = false;
            this.addColorButton.SynchronizeCheckMarkWithBorderSettings = true;
            this.addColorButton.TabIndex = 4;
            this.addColorButton.Text = "Add Color";
            this.addColorButton.UsingTexturedBackground = false;
            // 
            // clearColorsLink
            // 
            this.clearColorsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.clearColorsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearColorsLink.AutoSize = true;
            this.clearColorsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.clearColorsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(133)))), ((int)(((byte)(227)))));
            this.clearColorsLink.Location = new System.Drawing.Point(9, 416);
            this.clearColorsLink.Name = "clearColorsLink";
            this.clearColorsLink.Size = new System.Drawing.Size(31, 13);
            this.clearColorsLink.TabIndex = 5;
            this.clearColorsLink.TabStop = true;
            this.clearColorsLink.Text = "Clear";
            this.clearColorsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearColorsLink_LinkClicked);
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.Location = new System.Drawing.Point(12, 322);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(304, 32);
            this.colorPanel.TabIndex = 6;
            // 
            // colorPanelContextMenu
            // 
            this.colorPanelContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.removeContextMenuItem});
            // 
            // removeContextMenuItem
            // 
            this.removeContextMenuItem.Index = 0;
            this.removeContextMenuItem.Text = "Remove";
            this.removeContextMenuItem.Click += new System.EventHandler(this.removeContextMenuItem_Click);
            // 
            // rgbLine1
            // 
            this.rgbLine1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rgbLine1.ChosenColor = System.Drawing.Color.Empty;
            this.rgbLine1.LineThickness = 3F;
            this.rgbLine1.Location = new System.Drawing.Point(37, 309);
            this.rgbLine1.MaximumSize = new System.Drawing.Size(255, 10);
            this.rgbLine1.MinimumSize = new System.Drawing.Size(255, 10);
            this.rgbLine1.Name = "rgbLine1";
            this.rgbLine1.SelectedColor = Color_Picker.RGBLine.Colors.Shade;
            this.rgbLine1.Size = new System.Drawing.Size(255, 10);
            this.rgbLine1.TabIndex = 7;
            this.rgbLine1.Text = "rgbLine1";
            // 
            // colorWheel
            // 
            this.colorWheel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorWheel.LineThickness = 2F;
            this.colorWheel.Location = new System.Drawing.Point(36, 12);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colorWheel.SelectedColor = System.Drawing.Color.Empty;
            this.colorWheel.Size = new System.Drawing.Size(256, 256);
            this.colorWheel.TabIndex = 0;
            this.colorWheel.Text = "colorWheel1";
            this.colorWheel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorWheel_MouseClick);
            this.colorWheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorWheel_MouseMove);
            // 
            // ColorWheelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(328, 447);
            this.Controls.Add(this.rgbLine1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.clearColorsLink);
            this.Controls.Add(this.addColorButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.addedColorsPanel);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.colorWheel);
            this.MinimumSize = new System.Drawing.Size(344, 486);
            this.Name = "ColorWheelDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Chooser";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorWheelDialog_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorWheel colorWheel;
        private ALMSTWKND.UI.WindowsForms.Controls.Separator separator1;
        private System.Windows.Forms.FlowLayoutPanel addedColorsPanel;
        private ALMSTWKND.UI.WindowsForms.Controls.Button applyButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button addColorButton;
        private System.Windows.Forms.LinkLabel clearColorsLink;
        private System.Windows.Forms.Panel colorPanel;
        private RGBLine rgbLine1;
        private System.Windows.Forms.ContextMenu colorPanelContextMenu;
        private System.Windows.Forms.MenuItem removeContextMenuItem;
    }
}