using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
	// Token: 0x02000002 RID: 2
	public partial class Background : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Background()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			base.TopMost = true;
			base.ShowInTaskbar = false;
			base.Enabled = false;
			this.SetBackgroundImageForResolution();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
		private void SetBackgroundImageForResolution()
		{
			List<ValueTuple<Size, Bitmap>> list = new List<ValueTuple<Size, Bitmap>>();
			list.Add(new ValueTuple<Size, Bitmap>(new Size(1024, 768), Resources._1024768));
			list.Add(new ValueTuple<Size, Bitmap>(new Size(768, 1280), Resources._7681280));
			list.Add(new ValueTuple<Size, Bitmap>(new Size(1280, 1024), Resources._12801024));
			list.Add(new ValueTuple<Size, Bitmap>(new Size(1600, 1200), Resources._16001200));
			list.Add(new ValueTuple<Size, Bitmap>(new Size(1920, 1200), Resources._19201200));
			Size currentResolution = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			ValueTuple<Size, Bitmap> valueTuple = (from r in list
			orderby Math.Sqrt(Math.Pow((double)(r.Item1.Width - currentResolution.Width), 2.0) + Math.Pow((double)(r.Item1.Height - currentResolution.Height), 2.0))
			select r).First<ValueTuple<Size, Bitmap>>();
			this.BackgroundImage = valueTuple.Item2;
			this.BackgroundImageLayout = ImageLayout.None;
			Console.WriteLine(string.Format("Screen Resolution: {0}x{1}", currentResolution.Width, currentResolution.Height));
			Console.WriteLine(string.Format("Selected Background Resolution: {0}x{1}", valueTuple.Item1.Width, valueTuple.Item1.Height));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021F4 File Offset: 0x000003F4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.BackgroundImage != null)
			{
				float num = (float)this.BackgroundImage.Width / (float)this.BackgroundImage.Height;
				float num2 = (float)base.ClientSize.Width / (float)base.ClientSize.Height;
				int num3;
				int num4;
				if (num > num2)
				{
					num3 = base.ClientSize.Height;
					num4 = (int)((float)num3 * num);
				}
				else
				{
					num4 = base.ClientSize.Width;
					num3 = (int)((float)num4 / num);
				}
				int x = (base.ClientSize.Width - num4) / 2;
				int y = (base.ClientSize.Height - num3) / 2;
				e.Graphics.DrawImage(this.BackgroundImage, x, y, num4, num3);
			}
		}
	}
}
