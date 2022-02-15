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
            this.separator1 = new ALMSTWKND.UI.WindowsForms.Controls.Separator();
            this.okButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.colorNameLabel = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.addColorButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.resetColorChoiceLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rValueTextField = new System.Windows.Forms.TextBox();
            this.gValueTextField = new System.Windows.Forms.TextBox();
            this.bValueTextField = new System.Windows.Forms.TextBox();
            this.rMinusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.rPlusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.gMinusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.gPlusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.bMinusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.bPlusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.aTrackBar = new System.Windows.Forms.TrackBar();
            this.aValueTextField = new System.Windows.Forms.TextBox();
            this.aMinusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.aPlusButton = new ALMSTWKND.UI.WindowsForms.Controls.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.redLine = new Color_Picker.RGBLine();
            this.blueLine = new Color_Picker.RGBLine();
            this.greenLine = new Color_Picker.RGBLine();
            ((System.ComponentModel.ISupportInitialize)(this.aTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.Location = new System.Drawing.Point(14, 14);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(400, 37);
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
            this.selectedColorStyleComboBox.Location = new System.Drawing.Point(328, 57);
            this.selectedColorStyleComboBox.Name = "selectedColorStyleComboBox";
            this.selectedColorStyleComboBox.Size = new System.Drawing.Size(86, 23);
            this.selectedColorStyleComboBox.TabIndex = 1;
            this.selectedColorStyleComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectedColorStyleComboBox_SelectionChangeCommitted);
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.Angle = 0;
            this.separator1.CanHighlight = false;
            this.separator1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.separator1.Direction = "Horizontal";
            this.separator1.DisabledColor = System.Drawing.Color.Empty;
            this.separator1.HighlightColor = System.Drawing.Color.Empty;
            this.separator1.Location = new System.Drawing.Point(14, 86);
            this.separator1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 32);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(400, 1);
            this.separator1.TabIndex = 3;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
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
            this.okButton.Location = new System.Drawing.Point(330, 310);
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
            this.addColorButton.Location = new System.Drawing.Point(299, 57);
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
            this.resetColorChoiceLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetColorChoiceLink.AutoSize = true;
            this.resetColorChoiceLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.resetColorChoiceLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(145)))));
            this.resetColorChoiceLink.Location = new System.Drawing.Point(11, 315);
            this.resetColorChoiceLink.Name = "resetColorChoiceLink";
            this.resetColorChoiceLink.Size = new System.Drawing.Size(35, 15);
            this.resetColorChoiceLink.TabIndex = 12;
            this.resetColorChoiceLink.TabStop = true;
            this.resetColorChoiceLink.Text = "Reset";
            this.resetColorChoiceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetColorChoiceLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // rValueTextField
            // 
            this.rValueTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.rValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rValueTextField.Location = new System.Drawing.Point(343, 107);
            this.rValueTextField.Name = "rValueTextField";
            this.rValueTextField.Size = new System.Drawing.Size(42, 23);
            this.rValueTextField.TabIndex = 13;
            this.rValueTextField.TextChanged += new System.EventHandler(this.rValueTextField_TextChanged);
            // 
            // gValueTextField
            // 
            this.gValueTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.gValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gValueTextField.Location = new System.Drawing.Point(343, 158);
            this.gValueTextField.Name = "gValueTextField";
            this.gValueTextField.Size = new System.Drawing.Size(42, 23);
            this.gValueTextField.TabIndex = 14;
            this.gValueTextField.TextChanged += new System.EventHandler(this.gValueTextField_TextChanged);
            // 
            // bValueTextField
            // 
            this.bValueTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.bValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bValueTextField.Location = new System.Drawing.Point(343, 209);
            this.bValueTextField.Name = "bValueTextField";
            this.bValueTextField.Size = new System.Drawing.Size(42, 23);
            this.bValueTextField.TabIndex = 15;
            this.bValueTextField.TextChanged += new System.EventHandler(this.bValueTextField_TextChanged);
            // 
            // rMinusButton
            // 
            this.rMinusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.rMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.rMinusButton.BackgroundImageLayout = null;
            this.rMinusButton.BackgroundTexture = null;
            this.rMinusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.rMinusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.rMinusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rMinusButton.BorderThickness = 0F;
            this.rMinusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.rMinusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.rMinusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.rMinusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.rMinusButton.CheckmarkThickness = 0F;
            this.rMinusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.rMinusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.rMinusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.rMinusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.rMinusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.rMinusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rMinusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.rMinusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rMinusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rMinusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rMinusButton.FocusedColor = System.Drawing.Color.Empty;
            this.rMinusButton.HasBorder = false;
            this.rMinusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.rMinusButton.Location = new System.Drawing.Point(314, 107);
            this.rMinusButton.Name = "rMinusButton";
            this.rMinusButton.RequiresConfirmation = false;
            this.rMinusButton.SeparatorDistance = 0;
            this.rMinusButton.Size = new System.Drawing.Size(23, 23);
            this.rMinusButton.StyleButtonSeparately = false;
            this.rMinusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.rMinusButton.TabIndex = 16;
            this.rMinusButton.Text = "-";
            this.rMinusButton.UsingTexturedBackground = false;
            this.rMinusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.rMinusButton_Clicked);
            // 
            // rPlusButton
            // 
            this.rPlusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.rPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.rPlusButton.BackgroundImageLayout = null;
            this.rPlusButton.BackgroundTexture = null;
            this.rPlusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.rPlusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.rPlusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rPlusButton.BorderThickness = 0F;
            this.rPlusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.rPlusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.rPlusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.rPlusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.rPlusButton.CheckmarkThickness = 0F;
            this.rPlusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.rPlusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.rPlusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.rPlusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.rPlusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.rPlusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rPlusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.rPlusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rPlusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rPlusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rPlusButton.FocusedColor = System.Drawing.Color.Empty;
            this.rPlusButton.HasBorder = false;
            this.rPlusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.rPlusButton.Location = new System.Drawing.Point(391, 107);
            this.rPlusButton.Name = "rPlusButton";
            this.rPlusButton.RequiresConfirmation = false;
            this.rPlusButton.SeparatorDistance = 0;
            this.rPlusButton.Size = new System.Drawing.Size(23, 23);
            this.rPlusButton.StyleButtonSeparately = false;
            this.rPlusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.rPlusButton.TabIndex = 17;
            this.rPlusButton.Text = "+";
            this.rPlusButton.UsingTexturedBackground = false;
            this.rPlusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.rPlusButton_Clicked);
            // 
            // gMinusButton
            // 
            this.gMinusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.gMinusButton.BackgroundImageLayout = null;
            this.gMinusButton.BackgroundTexture = null;
            this.gMinusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.gMinusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.gMinusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.gMinusButton.BorderThickness = 0F;
            this.gMinusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.gMinusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.gMinusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.gMinusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.gMinusButton.CheckmarkThickness = 0F;
            this.gMinusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.gMinusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.gMinusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.gMinusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.gMinusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.gMinusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gMinusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.gMinusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gMinusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gMinusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.gMinusButton.FocusedColor = System.Drawing.Color.Empty;
            this.gMinusButton.HasBorder = false;
            this.gMinusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.gMinusButton.Location = new System.Drawing.Point(314, 158);
            this.gMinusButton.Name = "gMinusButton";
            this.gMinusButton.RequiresConfirmation = false;
            this.gMinusButton.SeparatorDistance = 0;
            this.gMinusButton.Size = new System.Drawing.Size(23, 23);
            this.gMinusButton.StyleButtonSeparately = false;
            this.gMinusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.gMinusButton.TabIndex = 18;
            this.gMinusButton.Text = "-";
            this.gMinusButton.UsingTexturedBackground = false;
            this.gMinusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.gMinusButton_Clicked);
            // 
            // gPlusButton
            // 
            this.gPlusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.gPlusButton.BackgroundImageLayout = null;
            this.gPlusButton.BackgroundTexture = null;
            this.gPlusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.gPlusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.gPlusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.gPlusButton.BorderThickness = 0F;
            this.gPlusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.gPlusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.gPlusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.gPlusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.gPlusButton.CheckmarkThickness = 0F;
            this.gPlusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.gPlusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.gPlusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.gPlusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.gPlusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.gPlusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gPlusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.gPlusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gPlusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gPlusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.gPlusButton.FocusedColor = System.Drawing.Color.Empty;
            this.gPlusButton.HasBorder = false;
            this.gPlusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.gPlusButton.Location = new System.Drawing.Point(391, 158);
            this.gPlusButton.Name = "gPlusButton";
            this.gPlusButton.RequiresConfirmation = false;
            this.gPlusButton.SeparatorDistance = 0;
            this.gPlusButton.Size = new System.Drawing.Size(23, 23);
            this.gPlusButton.StyleButtonSeparately = false;
            this.gPlusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.gPlusButton.TabIndex = 19;
            this.gPlusButton.Text = "+";
            this.gPlusButton.UsingTexturedBackground = false;
            this.gPlusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.gPlusButton_Clicked);
            // 
            // bMinusButton
            // 
            this.bMinusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.bMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.bMinusButton.BackgroundImageLayout = null;
            this.bMinusButton.BackgroundTexture = null;
            this.bMinusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.bMinusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.bMinusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bMinusButton.BorderThickness = 0F;
            this.bMinusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.bMinusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.bMinusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.bMinusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.bMinusButton.CheckmarkThickness = 0F;
            this.bMinusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.bMinusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.bMinusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.bMinusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.bMinusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.bMinusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bMinusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.bMinusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bMinusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bMinusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bMinusButton.FocusedColor = System.Drawing.Color.Empty;
            this.bMinusButton.HasBorder = false;
            this.bMinusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.bMinusButton.Location = new System.Drawing.Point(314, 209);
            this.bMinusButton.Name = "bMinusButton";
            this.bMinusButton.RequiresConfirmation = false;
            this.bMinusButton.SeparatorDistance = 0;
            this.bMinusButton.Size = new System.Drawing.Size(23, 23);
            this.bMinusButton.StyleButtonSeparately = false;
            this.bMinusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.bMinusButton.TabIndex = 20;
            this.bMinusButton.Text = "-";
            this.bMinusButton.UsingTexturedBackground = false;
            this.bMinusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.bMinusButton_Clicked);
            // 
            // bPlusButton
            // 
            this.bPlusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.bPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.bPlusButton.BackgroundImageLayout = null;
            this.bPlusButton.BackgroundTexture = null;
            this.bPlusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.bPlusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.bPlusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bPlusButton.BorderThickness = 0F;
            this.bPlusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.bPlusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.bPlusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.bPlusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.bPlusButton.CheckmarkThickness = 0F;
            this.bPlusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.bPlusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.bPlusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.bPlusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.bPlusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.bPlusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bPlusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.bPlusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bPlusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.bPlusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bPlusButton.FocusedColor = System.Drawing.Color.Empty;
            this.bPlusButton.HasBorder = false;
            this.bPlusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.bPlusButton.Location = new System.Drawing.Point(391, 209);
            this.bPlusButton.Name = "bPlusButton";
            this.bPlusButton.RequiresConfirmation = false;
            this.bPlusButton.SeparatorDistance = 0;
            this.bPlusButton.Size = new System.Drawing.Size(23, 23);
            this.bPlusButton.StyleButtonSeparately = false;
            this.bPlusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.bPlusButton.TabIndex = 21;
            this.bPlusButton.Text = "+";
            this.bPlusButton.UsingTexturedBackground = false;
            this.bPlusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.bPlusButton_Clicked);
            // 
            // aTrackBar
            // 
            this.aTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aTrackBar.Location = new System.Drawing.Point(31, 268);
            this.aTrackBar.Maximum = 255;
            this.aTrackBar.Name = "aTrackBar";
            this.aTrackBar.Size = new System.Drawing.Size(265, 45);
            this.aTrackBar.TabIndex = 22;
            this.aTrackBar.Scroll += new System.EventHandler(this.aTrackBar_Scroll);
            // 
            // aValueTextField
            // 
            this.aValueTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aValueTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.aValueTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aValueTextField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aValueTextField.Location = new System.Drawing.Point(343, 260);
            this.aValueTextField.Name = "aValueTextField";
            this.aValueTextField.Size = new System.Drawing.Size(42, 23);
            this.aValueTextField.TabIndex = 23;
            this.aValueTextField.TextChanged += new System.EventHandler(this.aValueTextField_TextChanged);
            // 
            // aMinusButton
            // 
            this.aMinusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.aMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.aMinusButton.BackgroundImageLayout = null;
            this.aMinusButton.BackgroundTexture = null;
            this.aMinusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.aMinusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.aMinusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.aMinusButton.BorderThickness = 0F;
            this.aMinusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.aMinusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.aMinusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.aMinusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.aMinusButton.CheckmarkThickness = 0F;
            this.aMinusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.aMinusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.aMinusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.aMinusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.aMinusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.aMinusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aMinusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.aMinusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aMinusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aMinusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.aMinusButton.FocusedColor = System.Drawing.Color.Empty;
            this.aMinusButton.HasBorder = false;
            this.aMinusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.aMinusButton.Location = new System.Drawing.Point(314, 260);
            this.aMinusButton.Name = "aMinusButton";
            this.aMinusButton.RequiresConfirmation = false;
            this.aMinusButton.SeparatorDistance = 0;
            this.aMinusButton.Size = new System.Drawing.Size(23, 23);
            this.aMinusButton.StyleButtonSeparately = false;
            this.aMinusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.aMinusButton.TabIndex = 24;
            this.aMinusButton.Text = "-";
            this.aMinusButton.UsingTexturedBackground = false;
            this.aMinusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.aMinusButton_Clicked);
            // 
            // aPlusButton
            // 
            this.aPlusButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.aPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.aPlusButton.BackgroundImageLayout = null;
            this.aPlusButton.BackgroundTexture = null;
            this.aPlusButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.aPlusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.aPlusButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.aPlusButton.BorderThickness = 0F;
            this.aPlusButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.aPlusButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.aPlusButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.aPlusButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.aPlusButton.CheckmarkThickness = 0F;
            this.aPlusButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.aPlusButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.aPlusButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.aPlusButton.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.aPlusButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.aPlusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aPlusButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.aPlusButton.DisabledCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aPlusButton.DisabledSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.aPlusButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.aPlusButton.FocusedColor = System.Drawing.Color.Empty;
            this.aPlusButton.HasBorder = false;
            this.aPlusButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.aPlusButton.Location = new System.Drawing.Point(391, 260);
            this.aPlusButton.Name = "aPlusButton";
            this.aPlusButton.RequiresConfirmation = false;
            this.aPlusButton.SeparatorDistance = 0;
            this.aPlusButton.Size = new System.Drawing.Size(23, 23);
            this.aPlusButton.StyleButtonSeparately = false;
            this.aPlusButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.aPlusButton.TabIndex = 25;
            this.aPlusButton.Text = "+";
            this.aPlusButton.UsingTexturedBackground = false;
            this.aPlusButton.Clicked += new System.EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.aPlusButton_Clicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "A";
            // 
            // redLine
            // 
            this.redLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.redLine.BackColor = System.Drawing.Color.Transparent;
            this.redLine.ChosenColor = System.Drawing.Color.Red;
            this.redLine.LineThickness = 7F;
            this.redLine.Location = new System.Drawing.Point(33, 115);
            this.redLine.MaximumSize = new System.Drawing.Size(255, 10);
            this.redLine.MinimumSize = new System.Drawing.Size(255, 10);
            this.redLine.Name = "redLine";
            this.redLine.SelectedColor = Color_Picker.RGBLine.Colors.Shade;
            this.redLine.Size = new System.Drawing.Size(255, 10);
            this.redLine.StartingColor = System.Drawing.Color.Black;
            this.redLine.TabIndex = 29;
            this.redLine.Text = "rgbLine3";
            this.redLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.redLine_MouseMove);
            // 
            // blueLine
            // 
            this.blueLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blueLine.BackColor = System.Drawing.Color.Transparent;
            this.blueLine.ChosenColor = System.Drawing.Color.Blue;
            this.blueLine.LineThickness = 7F;
            this.blueLine.Location = new System.Drawing.Point(32, 217);
            this.blueLine.MaximumSize = new System.Drawing.Size(255, 10);
            this.blueLine.MinimumSize = new System.Drawing.Size(255, 10);
            this.blueLine.Name = "blueLine";
            this.blueLine.SelectedColor = Color_Picker.RGBLine.Colors.Shade;
            this.blueLine.Size = new System.Drawing.Size(255, 10);
            this.blueLine.StartingColor = System.Drawing.Color.Black;
            this.blueLine.TabIndex = 27;
            this.blueLine.Text = "rgbLine1";
            this.blueLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.blueLine_MouseMove);
            // 
            // greenLine
            // 
            this.greenLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.greenLine.BackColor = System.Drawing.Color.Transparent;
            this.greenLine.ChosenColor = System.Drawing.Color.Green;
            this.greenLine.LineThickness = 7F;
            this.greenLine.Location = new System.Drawing.Point(33, 166);
            this.greenLine.MaximumSize = new System.Drawing.Size(255, 10);
            this.greenLine.MinimumSize = new System.Drawing.Size(255, 10);
            this.greenLine.Name = "greenLine";
            this.greenLine.SelectedColor = Color_Picker.RGBLine.Colors.Shade;
            this.greenLine.Size = new System.Drawing.Size(255, 10);
            this.greenLine.StartingColor = System.Drawing.Color.Black;
            this.greenLine.TabIndex = 30;
            this.greenLine.Text = "rgbLine3";
            this.greenLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.greenLine_MouseMove);
            // 
            // ColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(427, 347);
            this.Controls.Add(this.greenLine);
            this.Controls.Add(this.redLine);
            this.Controls.Add(this.blueLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aPlusButton);
            this.Controls.Add(this.aMinusButton);
            this.Controls.Add(this.aValueTextField);
            this.Controls.Add(this.aTrackBar);
            this.Controls.Add(this.bPlusButton);
            this.Controls.Add(this.bMinusButton);
            this.Controls.Add(this.gPlusButton);
            this.Controls.Add(this.gMinusButton);
            this.Controls.Add(this.rPlusButton);
            this.Controls.Add(this.rMinusButton);
            this.Controls.Add(this.bValueTextField);
            this.Controls.Add(this.gValueTextField);
            this.Controls.Add(this.rValueTextField);
            this.Controls.Add(this.resetColorChoiceLink);
            this.Controls.Add(this.addColorButton);
            this.Controls.Add(this.colorNameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.aTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ComboBox selectedColorStyleComboBox;
        private ALMSTWKND.UI.WindowsForms.Controls.Separator separator1;
        private ALMSTWKND.UI.WindowsForms.Controls.Button okButton;
        private System.Windows.Forms.Label colorNameLabel;
        private System.Windows.Forms.ToolTip tip;
        private ALMSTWKND.UI.WindowsForms.Controls.Button addColorButton;
        private System.Windows.Forms.LinkLabel resetColorChoiceLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rValueTextField;
        private System.Windows.Forms.TextBox gValueTextField;
        private System.Windows.Forms.TextBox bValueTextField;
        private ALMSTWKND.UI.WindowsForms.Controls.Button rMinusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button rPlusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button gMinusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button gPlusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button bMinusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button bPlusButton;
        private System.Windows.Forms.TrackBar aTrackBar;
        private System.Windows.Forms.TextBox aValueTextField;
        private ALMSTWKND.UI.WindowsForms.Controls.Button aMinusButton;
        private ALMSTWKND.UI.WindowsForms.Controls.Button aPlusButton;
        private System.Windows.Forms.Label label4;
        private RGBLine blueLine;
        private RGBLine redLine;
        private RGBLine greenLine;
    }
}