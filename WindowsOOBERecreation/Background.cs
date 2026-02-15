using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Background : Form
    {
        private Bitmap _bgOriginal;
        private Bitmap _bgScaled;

        public Background()
        {
            InitializeComponent();

            this.TopMost = true;
            this.ShowInTaskbar = false;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Enabled = false;

            SetBGForRes();
        }

        private void SetBGForRes()
        {
            var resolutions = new List<(Size Resolution, Bitmap Image)>
            {
                (new Size(1024, 768), Properties.Resources._1024768),
                (new Size(768, 1280), Properties.Resources._7681280),
                (new Size(1280, 1024), Properties.Resources._12801024),
                (new Size(1600, 1200), Properties.Resources._16001200),
                (new Size(1920, 1200), Properties.Resources._19201200)
            };

            var currentResolution = Screen.PrimaryScreen.Bounds.Size;
            var closestResolution = resolutions
                .OrderBy(r => Math.Sqrt(
                    Math.Pow(r.Resolution.Width - currentResolution.Width, 2) +
                    Math.Pow(r.Resolution.Height - currentResolution.Height, 2)))
                .First();

            _bgOriginal = closestResolution.Image;
            BuildScaledBackground();
        }

        private void BuildScaledBackground()
        {
            if (_bgOriginal == null || ClientSize.Width == 0 || ClientSize.Height == 0)
                return;

            _bgScaled?.Dispose();
            _bgScaled = new Bitmap(ClientSize.Width, ClientSize.Height);

            using (var g = Graphics.FromImage(_bgScaled))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.DrawImage(_bgOriginal, new Rectangle(0, 0, _bgScaled.Width, _bgScaled.Height));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            BuildScaledBackground();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_bgScaled != null)
                e.Graphics.DrawImageUnscaled(_bgScaled, 0, 0);
        }
    }
}