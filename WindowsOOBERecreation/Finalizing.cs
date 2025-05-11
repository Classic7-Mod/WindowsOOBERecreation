using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
    public partial class Finalizing : Form
    {
        public Finalizing(Main mainForm)
        {
            this.InitializeComponent();
            this._mainForm = mainForm;
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.LogoutAfterDelay();
        }

        private async void LogoutAfterDelay()
        {
            await Task.Delay(30000);
            LogOut();
        }

        private void LogOut()
        {
            string text = "C:\\Classic Files\\oobe.log";
            try
            {
                string startupPath = Application.StartupPath;
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true))
                {
                    if (registryKey != null)
                    {
                        this.SetRegistryValue(registryKey, "AutoAdminLogon", "1", RegistryValueKind.String, text);
                        this.SetRegistryValue(registryKey, "AutoLogonCount", 2, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey, "DefaultUserName", Settings.Default.username, RegistryValueKind.String, text);
                        string value = Settings.Default.password ?? "";
                        this.SetRegistryValue(registryKey, "DefaultPassword", value, RegistryValueKind.String, text);
                    }
                }
                using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\Setup", true))
                {
                    if (registryKey2 != null)
                    {
                        this.SetRegistryValue(registryKey2, "OOBEInProgress", 0, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey2, "RestartSetup", 0, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey2, "SetupPhase", 0, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey2, "SetupSupported", 1, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey2, "SetupType", 0, RegistryValueKind.DWord, text);
                        this.SetRegistryValue(registryKey2, "SystemSetupInProgress", 0, RegistryValueKind.DWord, text);
                    }
                }
                this.LogToFile(text, "Exiting now");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                this.LogToFile(text, "An error occurred: " + ex.Message);
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void SetRegistryValue(RegistryKey key, string valueName, object value, RegistryValueKind valueKind, string logFilePath)
        {
            try
            {
                if (key.GetValue(valueName) == null)
                {
                    key.SetValue(valueName, value, valueKind);
                    this.LogToFile(logFilePath, string.Format("Created and set {0} to {1}.", valueName, value));
                }
                else
                {
                    key.SetValue(valueName, value, valueKind);
                    this.LogToFile(logFilePath, string.Format("Updated {0} to {1}.", valueName, value));
                }
            }
            catch (Exception ex)
            {
                this.LogToFile(logFilePath, "Failed to set " + valueName + ": " + ex.Message);
            }
        }

        private void LogToFile(string filePath, string message)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(string.Format("{0}: {1}", DateTime.Now, message));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to write to log: " + ex.Message);
            }
        }

        private Main _mainForm;
    }
}
