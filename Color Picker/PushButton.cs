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
    public partial class PushButton : Control
    {
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Layout")]
        [DisplayName("Radius")]
        public int Radius { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Outline Color")]
        public Color OutlineColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Fill Color")]
        public Color FillColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Hover Color")]
        public Color HoverColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Pressed Color")]
        public Color PressedColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Outline Thickness")]
        public float OutlineThickness { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [DisplayName("Spacing")]
        public int Spacing { get; set; }

        public enum DrawTypes
        {
            Outline,
            Filling
        }

        public static DrawTypes DrawType { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Behavior")]
        [DisplayName("Push State")]
        public bool PushState { get; set; }

        public bool mouseEntered;
        private bool mouseDown;

        public PushButton()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public void Draw(PaintEventArgs paintEventArgs, DrawTypes drawType)
        {
            switch(drawType)
            {
                case DrawTypes.Outline:
                    paintEventArgs.Graphics.DrawEllipse(new Pen(FillColor, OutlineThickness), new RectangleF(new Point(0, 0), new SizeF(this.Width - OutlineThickness, this.Height - OutlineThickness)));

                    if (mouseDown)
                    {
                        paintEventArgs.Graphics.FillEllipse(new SolidBrush(PressedColor), new RectangleF(new Point((int)OutlineThickness, (int)OutlineThickness), new Size(this.Width - (int)OutlineThickness * 3, this.Height - (int)OutlineThickness * 3)));
                    }

                    if (mouseEntered)
                    {
                        paintEventArgs.Graphics.FillEllipse(new SolidBrush(HoverColor), new RectangleF(new Point((int)OutlineThickness, (int)OutlineThickness), new Size(this.Width - (int)OutlineThickness * 3, this.Height - (int)OutlineThickness * 3)));
                        mouseEntered = false;
                    }
                    break;
                case DrawTypes.Filling:
                    if (PushState)
                    {
                        paintEventArgs.Graphics.FillEllipse(new SolidBrush(this.FillColor), new RectangleF(new Point(3, 3), new Size(this.Width - 7, this.Height - 7)));
                    }
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Draw(paintEventArgs, DrawTypes.Outline);
            Draw(paintEventArgs, DrawTypes.Filling);

            base.OnPaint(paintEventArgs);
        }

        private void PushButton_MouseClick(object sender, MouseEventArgs e)
        {
            switch (PushState)
            {
                case true:
                    PushState = false;
                    this.Refresh();
                    break;
                case false:
                    PushState = true;
                    this.Refresh();
                    break;
            }
        }

        private void PushButton_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered = true;
            this.Refresh();
        }

        private void PushButton_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            this.Refresh();
        }

        private void PushButton_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Refresh();
        }

        private void PushButton_MouseLeave(object sender, EventArgs e)
        {
            mouseEntered = false;
            this.Refresh();
        }
    }
}
