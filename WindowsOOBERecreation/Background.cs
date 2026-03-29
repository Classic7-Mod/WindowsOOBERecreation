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
                (new Size(1280, 1024), Properties.Resources._12801024),
                (new Size(1280, 960), Properties.Resources._1280960),
                (new Size(1024, 768), Properties.Resources._1024768),
                (new Size(1600, 1200), Properties.Resources._16001200),
                (new Size(1440, 900), Properties.Resources._1440900),
                (new Size(1920, 1200), Properties.Resources._19201200),
                (new Size(1280, 768), Properties.Resources._1280768),
                (new Size(1360, 768), Properties.Resources._1360768),
                (new Size(1024, 1280), Properties.Resources._10241280),
                (new Size(960, 1280), Properties.Resources._9601280),
                (new Size(900, 1440), Properties.Resources._9001440),
                (new Size(768, 1280), Properties.Resources._7681280),
                (new Size(768, 1360), Properties.Resources._7681360),
            };

            var currentResolution = Screen.PrimaryScreen.Bounds.Size;
            float screenRatio = (float)currentResolution.Width / currentResolution.Height;

            var closestResolution = resolutions
                .OrderBy(r => Math.Abs((float)r.Resolution.Width / r.Resolution.Height - screenRatio))
                .ThenBy(r => Math.Abs(r.Resolution.Width - currentResolution.Width))
                .First();

            _bgOriginal = closestResolution.Image;
            BuildScaledBackground();
        }

        private void BuildScaledBackground()
        {
            if (_bgOriginal == null || ClientSize.Width == 0 || ClientSize.Height == 0)
                return;

            if (_bgScaled != null &&
                _bgScaled.Width == ClientSize.Width &&
                _bgScaled.Height == ClientSize.Height)
                return;

            _bgScaled?.Dispose();
            _bgScaled = new Bitmap(ClientSize.Width, ClientSize.Height);

            using (var g = Graphics.FromImage(_bgScaled))
            using (var attributes = new System.Drawing.Imaging.ImageAttributes())
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                attributes.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);

                g.DrawImage(_bgOriginal, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), 0, 0, _bgOriginal.Width, _bgOriginal.Height, GraphicsUnit.Pixel, attributes);
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