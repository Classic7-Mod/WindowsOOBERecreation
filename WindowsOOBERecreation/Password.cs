using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Password : Form
    {
        private Main _mainForm;
        private string _username;
        private string _computerName;

        public Password(Main mainForm, string username, string computerName)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _username = username;
            _computerName = computerName;

            passwordBox.TextChanged += ValidateInput;
            confpasswordBox.TextChanged += ValidateInput;
            passwordHintBox.TextChanged += ValidateInput;
            nextButton.Enabled = true;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string confirmPassword = confpasswordBox.Text;
            string passwordHint = passwordHintBox.Text;

            if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(confirmPassword) && string.IsNullOrEmpty(passwordHint))
            {
                nextButton.Enabled = true;
            }
            else if (!string.IsNullOrEmpty(password) && password == confirmPassword && !string.IsNullOrEmpty(passwordHint))
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string confirmPassword = confpasswordBox.Text;

            try
            {
                if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(confirmPassword))
                {
                    ExecuteCommand($"net user \"{_username}\" /add");
                }
                else if (password == confirmPassword)
                {
                    ExecuteCommand($"net user \"{_username}\" \"{password}\" /add /y"); // /y forces the password over 14 characters!
                }

                ExecuteCommand($"net localgroup Administrators /add \"{_username}\"");
                ChangeComputerName(_computerName);

                Properties.Settings.Default.username = _username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            try
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
                            Console.WriteLine("Computer name changed successfully to: " + newComputerName);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine($"Failed to change computer name. Error code: {returnValue}");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while changing the computer name: " + ex.Message);
            }

            return false;
        }
    }
}
