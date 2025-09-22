using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Password : Form
    {
        private Main _mainForm;
        private string usernameStr;
        private string computerNameStr;

        public Password(Main mainForm, string username, string computerName)
        {
            InitializeComponent();
            this.AcceptButton = nextButton;
            _mainForm = mainForm;
            usernameStr = username;
            computerNameStr = computerName;

            passwordBox.TextChanged += ValidateInput;
            confirmPassBox.TextChanged += ValidateInput;
            passHintBox.TextChanged += ValidateInput;
            nextButton.Enabled = true;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string confirmPassword = confirmPassBox.Text;
            string passwordHint = passHintBox.Text;

            if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(confirmPassword) && string.IsNullOrEmpty(passwordHint))
            {
                nextButton.Enabled = true;
                hintLabel.Text = "Type a password hint:";
            }
            else if (!string.IsNullOrEmpty(password) && password == confirmPassword && !string.IsNullOrEmpty(passwordHint))
            {
                nextButton.Enabled = true;
                hintLabel.Text = "Type a password hint (required):";
            }
            else
            {
                nextButton.Enabled = false;
                hintLabel.Text = "Type a password hint (required):";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string confirmPassword = confirmPassBox.Text;

            if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(confirmPassword))
            {
                ExecuteCommand($"net user \"{usernameStr}\" /add");
            }
            else if (password == confirmPassword)
            {
                ExecuteCommand($"net user \"{usernameStr}\" \"{password}\" /add /y"); // /y forces the password over 14 characters!
            }

            ExecuteCommand($"net localgroup Administrators /add \"{usernameStr}\"");
            ChangeComputerName(computerNameStr);

            // Needed in Finalizing.cs
            Properties.Settings.Default.username = usernameStr;
            Properties.Settings.Default.password = password;
            Properties.Settings.Default.Save();

            ProductKey ProductKeyForm = new ProductKey(_mainForm);
            _mainForm.LoadFormIntoPanel(ProductKeyForm);
        }

        private void ExecuteCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception(error);
                }
            }
        }

        public static bool ChangeComputerName(string newComputerName)
        {
            using (var managementClass = new ManagementClass("Win32_ComputerSystem"))
            {
                managementClass.Scope = new ManagementScope("\\\\.\\root\\cimv2");
                foreach (ManagementObject instance in managementClass.GetInstances())
                {
                    ManagementBaseObject inParams = instance.GetMethodParameters("Rename");
                    inParams["Name"] = newComputerName;
                    ManagementBaseObject outParams = instance.InvokeMethod("Rename", inParams, null);

                    uint returnValue = (uint)outParams["ReturnValue"];
                    if (returnValue == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
