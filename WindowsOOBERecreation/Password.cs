using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
	// Token: 0x02000006 RID: 6
	public partial class Password : Form
	{
		// Token: 0x0600002A RID: 42
		[DllImport("kernel32.dll")]
		private static extern bool SetComputerName(string lpComputerName);

		// Token: 0x0600002B RID: 43 RVA: 0x00003798 File Offset: 0x00001998
		public Password(Main mainForm, string username, string computerName)
		{
			this.InitializeComponent();
			this._mainForm = mainForm;
			this._username = username;
			this._computerName = computerName;
			this.passwordBox.TextChanged += this.ValidateInput;
			this.confpasswordBox.TextChanged += this.ValidateInput;
			this.passwordHintBox.TextChanged += this.ValidateInput;
			this.nextButton.Enabled = true;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003818 File Offset: 0x00001A18
		private void ValidateInput(object sender, EventArgs e)
		{
			string text = this.passwordBox.Text;
			string text2 = this.confpasswordBox.Text;
			string text3 = this.passwordHintBox.Text;
			if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2) && string.IsNullOrEmpty(text3))
			{
				this.nextButton.Enabled = true;
				return;
			}
			if (!string.IsNullOrEmpty(text) && text == text2 && !string.IsNullOrEmpty(text3))
			{
				this.nextButton.Enabled = true;
				return;
			}
			this.nextButton.Enabled = false;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000038A0 File Offset: 0x00001AA0
		private void nextButton_Click(object sender, EventArgs e)
		{
			string text = this.passwordBox.Text;
			string text2 = this.confpasswordBox.Text;
			try
			{
				if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2))
				{
					this.ExecuteCommand("net user \"" + this._username + "\" /add");
				}
				else if (text == text2)
				{
					this.ExecuteCommand(string.Concat(new string[]
					{
						"net user \"",
						this._username,
						"\" \"",
						text,
						"\" /add"
					}));
				}
				this.ExecuteCommand("net localgroup Administrators /add \"" + this._username + "\"");
				Password.ChangeComputerName(this._computerName);
				Settings.Default.username = this._username;
				Settings.Default.password = text;
				Settings.Default.Save();
			}
			catch (Exception)
			{
			}
			ProductKey form = new ProductKey(this._mainForm);
			this._mainForm.LoadFormIntoPanel(form);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000039AC File Offset: 0x00001BAC
		private void ExecuteCommand(string command)
		{
			using (Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
			{
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			}))
			{
				process.WaitForExit();
				process.StandardOutput.ReadToEnd();
				string text = process.StandardError.ReadToEnd();
				if (!string.IsNullOrEmpty(text))
				{
					throw new Exception(text);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003A3C File Offset: 0x00001C3C
		public static bool ChangeComputerName(string newComputerName)
		{
			bool flag = Password.SetComputerName(newComputerName);
			if (flag)
			{
				Console.WriteLine("Computer name changed successfully to: " + newComputerName);
				return flag;
			}
			Console.WriteLine("Failed to change the computer name.");
			return flag;
		}

		// Token: 0x04000019 RID: 25
		private Main _mainForm;

		// Token: 0x0400001A RID: 26
		private string _username;

		// Token: 0x0400001B RID: 27
		private string _computerName;
	}
}
