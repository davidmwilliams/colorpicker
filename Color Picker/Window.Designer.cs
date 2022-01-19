namespace Color_Picker
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.exitPanel = new System.Windows.Forms.Panel();
            this.pickColorPanel = new System.Windows.Forms.Panel();
            this.pickColorLink = new System.Windows.Forms.LinkLabel();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.colorHistoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.openClosePanel = new System.Windows.Forms.Panel();
            this.eyedropper = new System.Windows.Forms.Panel();
            this.colorOptionsContextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.pickColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(74)))), ((int)(((byte)(55)))));
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitPanel.Location = new System.Drawing.Point(263, 0);
            this.exitPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(12, 32);
            this.exitPanel.TabIndex = 2;
            this.exitPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitPanel_MouseClick);
            this.exitPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitPanel_MouseDown);
            this.exitPanel.MouseEnter += new System.EventHandler(this.exitPanel_MouseEnter);
            this.exitPanel.MouseLeave += new System.EventHandler(this.exitPanel_MouseLeave);
            this.exitPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitPanel_MouseUp);
            // 
            // pickColorPanel
            // 
            this.pickColorPanel.Controls.Add(this.pickColorLink);
            this.pickColorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickColorPanel.Location = new System.Drawing.Point(215, 0);
            this.pickColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickColorPanel.Name = "pickColorPanel";
            this.pickColorPanel.Size = new System.Drawing.Size(48, 32);
            this.pickColorPanel.TabIndex = 3;
            // 
            // pickColorLink
            // 
            this.pickColorLink.AutoSize = true;
            this.pickColorLink.DisabledLinkColor = System.Drawing.Color.Gray;
            this.pickColorLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pickColorLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.pickColorLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pickColorLink.Location = new System.Drawing.Point(11, 8);
            this.pickColorLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pickColorLink.Name = "pickColorLink";
            this.pickColorLink.Size = new System.Drawing.Size(29, 15);
            this.pickColorLink.TabIndex = 0;
            this.pickColorLink.TabStop = true;
            this.pickColorLink.Text = "Pick";
            this.pickColorLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(198)))));
            this.pickColorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pickColorLink_LinkClicked);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.tip.ToolTipTitle = "Hint:";
            // 
            // colorHistoryPanel
            // 
            this.colorHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorHistoryPanel.Location = new System.Drawing.Point(44, 0);
            this.colorHistoryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.colorHistoryPanel.Name = "colorHistoryPanel";
            this.colorHistoryPanel.Size = new System.Drawing.Size(159, 32);
            this.colorHistoryPanel.TabIndex = 6;
            this.colorHistoryPanel.WrapContents = false;
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.informationPanel.BackgroundImage = global::Color_Picker.Properties.Resources.information2;
            this.informationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.informationPanel.Location = new System.Drawing.Point(203, 0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(12, 32);
            this.informationPanel.TabIndex = 5;
            this.informationPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.informationPanel_MouseClick);
            this.informationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.informationPanel_MouseDown);
            this.informationPanel.MouseEnter += new System.EventHandler(this.informationPanel_MouseEnter);
            this.informationPanel.MouseLeave += new System.EventHandler(this.informationPanel_MouseLeave);
            this.informationPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.informationPanel_MouseUp);
            // 
            // openClosePanel
            // 
            this.openClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.openClosePanel.BackgroundImage = global::Color_Picker.Properties.Resources.draggergrey;
            this.openClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openClosePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.openClosePanel.Location = new System.Drawing.Point(32, 0);
            this.openClosePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openClosePanel.Name = "openClosePanel";
            this.openClosePanel.Size = new System.Drawing.Size(12, 32);
            this.openClosePanel.TabIndex = 1;
            this.openClosePanel.Click += new System.EventHandler(this.openClosePanel_Click);
            this.openClosePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openClosePanel_MouseDown);
            this.openClosePanel.MouseEnter += new System.EventHandler(this.openClosePanel_MouseEnter);
            this.openClosePanel.MouseLeave += new System.EventHandler(this.openClosePanel_MouseLeave);
            this.openClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openClosePanel_MouseMove);
            this.openClosePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openClosePanel_MouseUp);
            // 
            // eyedropper
            // 
            this.eyedropper.BackgroundImage = global::Color_Picker.Properties.Resources.eyedropper;
            this.eyedropper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyedropper.Dock = System.Windows.Forms.DockStyle.Left;
            this.eyedropper.Location = new System.Drawing.Point(0, 0);
            this.eyedropper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.eyedropper.Name = "eyedropper";
            this.eyedropper.Size = new System.Drawing.Size(32, 32);
            this.eyedropper.TabIndex = 0;
            this.eyedropper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eyedropper_MouseClick);
            this.eyedropper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eyedropper_MouseDown);
            this.eyedropper.MouseEnter += new System.EventHandler(this.eyedropper_MouseEnter);
            this.eyedropper.MouseLeave += new System.EventHandler(this.eyedropper_MouseLeave);
            this.eyedropper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.eyedropper_MouseUp);
            this.eyedropper.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.eyedropper_PreviewKeyDown);
            // 
            // colorOptionsContextMenu
            // 
            this.colorOptionsContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem3,
            this.menuItem5,
            this.menuItem2});
            this.menuItem1.Text = "Copy...";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.RadioCheck = true;
            this.menuItem4.Text = "CMYK";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.RadioCheck = true;
            this.menuItem3.Text = "HEX";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.RadioCheck = true;
            this.menuItem5.Text = "HSB";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Checked = true;
            this.menuItem2.Index = 3;
            this.menuItem2.RadioCheck = true;
            this.menuItem2.Text = "RGB";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Clear Color Strip";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "More Options...";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(275, 32);
            this.Controls.Add(this.colorHistoryPanel);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.pickColorPanel);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.openClosePanel);
            this.Controls.Add(this.eyedropper);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Color Picker";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.Window_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.Shown += new System.EventHandler(this.Window_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            this.pickColorPanel.ResumeLayout(false);
            this.pickColorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel eyedropper;
        private System.Windows.Forms.Panel openClosePanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Panel pickColorPanel;
        private System.Windows.Forms.LinkLabel pickColorLink;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.FlowLayoutPanel colorHistoryPanel;
        private System.Windows.Forms.ContextMenu colorOptionsContextMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
    }
}

