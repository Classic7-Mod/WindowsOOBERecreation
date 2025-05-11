using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
	// Token: 0x02000005 RID: 5
	public partial class Main : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002E8A File Offset: 0x0000108A
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002E92 File Offset: 0x00001092
		public string Username { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002E9B File Offset: 0x0000109B
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002EA3 File Offset: 0x000010A3
		public string ComputerName { get; set; }

		// Token: 0x06000017 RID: 23 RVA: 0x00002EAC File Offset: 0x000010AC
		public Main()
		{
			this.InitializeComponent();
			new Background().Show();
			this.mainPanel = new Panel();
			this.mainPanel.Dock = DockStyle.Fill;
			base.TopMost = true;
			base.Controls.Add(this.mainPanel);
			this.LoadStartForm();
			using (MemoryStream memoryStream = new MemoryStream(Resources.backnotallowed))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backnotallowed";
			this.EnablePictureBoxEvents();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F54 File Offset: 0x00001154
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys)196722)
			{
				this.RunAuditMode();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002F70 File Offset: 0x00001170
		private void RunAuditMode()
		{
			try
			{
				Process.Start("cmd.exe", "/C sysprep /audit /reboot");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to execute Audit Mode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002FC0 File Offset: 0x000011C0
		private bool IsImageDisabled()
		{
			object tag = this.pictureBox2.Tag;
			return ((tag != null) ? tag.ToString() : null) == "backnotallowed";
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002FE4 File Offset: 0x000011E4
		private void PictureBox2_MouseEnter(object sender, EventArgs e)
		{
			if (this.IsImageDisabled())
			{
				return;
			}
			using (MemoryStream memoryStream = new MemoryStream(Resources.backhovered))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backhovered";
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003044 File Offset: 0x00001244
		private void PictureBox2_MouseLeave(object sender, EventArgs e)
		{
			if (this.IsImageDisabled())
			{
				return;
			}
			using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backallowed";
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000030A4 File Offset: 0x000012A4
		private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.IsImageDisabled())
			{
				return;
			}
			using (MemoryStream memoryStream = new MemoryStream(Resources.backpressed))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backpressed";
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003104 File Offset: 0x00001304
		private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.IsImageDisabled())
			{
				return;
			}
			using (MemoryStream memoryStream = new MemoryStream(Resources.backhovered))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backhovered";
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003164 File Offset: 0x00001364
		public void LoadFormIntoPanel(Form form)
		{
			this.mainPanel.Controls.Clear();
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			this.mainPanel.Controls.Add(form);
			form.Show();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000031A4 File Offset: 0x000013A4
		private void LoadStartForm()
		{
			Start form = new Start(this);
			this.LoadFormIntoPanel(form);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000031C0 File Offset: 0x000013C0
		public void LoadPasswordForm()
		{
			Password form = new Password(this, this.Username, this.ComputerName);
			this.LoadFormIntoPanel(form);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000031E8 File Offset: 0x000013E8
		private void LoadTimeAndDateForm()
		{
			TimeAndDate form = new TimeAndDate(this);
			this.LoadFormIntoPanel(form);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003204 File Offset: 0x00001404
		private void LoadLicenseForm()
		{
			License form = new License(this);
			this.LoadFormIntoPanel(form);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003220 File Offset: 0x00001420
		public void DisablePictureBox()
		{
			using (MemoryStream memoryStream = new MemoryStream(Resources.backnotallowed))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backnotallowed";
			this.DisablePictureBoxEvents();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000327C File Offset: 0x0000147C
		public void EnablePictureBox()
		{
			using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
			{
				this.pictureBox2.Image = Image.FromStream(memoryStream);
			}
			this.pictureBox2.Tag = "backallowed";
			this.EnablePictureBoxEvents();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000032D8 File Offset: 0x000014D8
		public void DisablePictureBoxEvents()
		{
			this.pictureBox2.MouseEnter -= this.PictureBox2_MouseEnter;
			this.pictureBox2.MouseLeave -= this.PictureBox2_MouseLeave;
			this.pictureBox2.MouseDown -= this.PictureBox2_MouseDown;
			this.pictureBox2.MouseUp -= this.PictureBox2_MouseUp;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003344 File Offset: 0x00001544
		public void EnablePictureBoxEvents()
		{
			this.pictureBox2.MouseEnter += this.PictureBox2_MouseEnter;
			this.pictureBox2.MouseLeave += this.PictureBox2_MouseLeave;
			this.pictureBox2.MouseDown += this.PictureBox2_MouseDown;
			this.pictureBox2.MouseUp += this.PictureBox2_MouseUp;
		}

		// Token: 0x04000010 RID: 16
		private Panel mainPanel;
	}
}
