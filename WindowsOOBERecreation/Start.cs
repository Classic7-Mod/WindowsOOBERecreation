using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
	// Token: 0x02000008 RID: 8
	public partial class Start : Form
	{
		public string Username { get; private set; }
		public string ComputerName { get; private set; }

		public Start(Main mainForm)
		{
			this.InitializeComponent();
			this._mainForm = mainForm;
			this.usernameBox.TextChanged += this.UsernameBox_TextChanged;
			this.usernameBox.AutoSize = false;
			this.usernameBox.Height = 20;
			this.computernameBox.KeyPress += this.ComputernameBox_KeyPress;
			this.computernameBox.AutoSize = false;
			this.computernameBox.Height = 20;
			this.nextButton.Enabled = false;
			this.clickTimer = new Timer();
			this.clickTimer.Interval = 300;
			this.clickTimer.Tick += this.ClickTimer_Tick;
			this.pictureBox1.MouseClick += this.PictureBox1_MouseClick;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004E24 File Offset: 0x00003024
		private void UsernameBox_TextChanged(object sender, EventArgs e)
		{
			string text = this.usernameBox.Text.Replace(" ", string.Empty);
			this.computernameBox.Text = text + "-PC";
			this.nextButton.Enabled = !string.IsNullOrWhiteSpace(this.usernameBox.Text);
			this.Username = text;
			this.ComputerName = this.computernameBox.Text;
			if (string.IsNullOrWhiteSpace(this.usernameBox.Text))
			{
				this.computernameBox.Text = "PC";
            }
		}

		private void ComputernameBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ' ')
			{
				e.Handled = true;
			}
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			this._mainForm.Username = this.Username;
			this._mainForm.ComputerName = this.ComputerName;
			this._mainForm.LoadPasswordForm();
		}

		private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.clickCount++;
				if (this.clickCount == 1)
				{
					this.clickTimer.Start();
					return;
				}
				if (this.clickCount == 3)
				{
					this.clickTimer.Stop();
					MessageBox.Show("made with love by patricktbp <3");
					this.clickCount = 0;
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004F3F File Offset: 0x0000313F
		private void ClickTimer_Tick(object sender, EventArgs e)
		{
			this.clickCount = 0;
			this.clickTimer.Stop();
		}

		private Main _mainForm;
		private int clickCount;
		private Timer clickTimer;
	}
}
