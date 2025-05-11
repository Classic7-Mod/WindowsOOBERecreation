using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
    public partial class Password : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool SetComputerName(string lpComputerName);

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

        private Main _mainForm;

        private string _username;

        private string _computerName;
    }
}
