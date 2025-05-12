using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsOOBERecreation
{
    public partial class Finalizing : Form
    {
        private Main _mainForm;

        public Finalizing(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            LogoutAfterDelay();
        }

        private async void LogoutAfterDelay()
        {
            await Task.Delay(30000);

            LogOut();
        }

        private void LogOut()
        {
            string logFilePath = @"C:\Classic Files\oobe.log";

            try
            {
                string appDirectory = Application.StartupPath;
                using (RegistryKey winlogonKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true))
                {
                    if (winlogonKey != null)
                    {
                        SetRegistryValue(winlogonKey, "AutoAdminLogon", "1", RegistryValueKind.String, logFilePath);
                        SetRegistryValue(winlogonKey, "AutoLogonCount", 2, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(winlogonKey, "DefaultUserName", Properties.Settings.Default.username, RegistryValueKind.String, logFilePath);

                        string password = Properties.Settings.Default.password ?? "";
                        SetRegistryValue(winlogonKey, "DefaultPassword", password, RegistryValueKind.String, logFilePath);
                    }
                }

                using (RegistryKey setupKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup", true))
                {
                    if (setupKey != null)
                    {
                        SetRegistryValue(setupKey, "OOBEInProgress", 0, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(setupKey, "RestartSetup", 0, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(setupKey, "SetupPhase", 0, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(setupKey, "SetupSupported", 1, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(setupKey, "SetupType", 0, RegistryValueKind.DWord, logFilePath);
                        SetRegistryValue(setupKey, "SystemSetupInProgress", 0, RegistryValueKind.DWord, logFilePath);
                    }
                }

                LogToFile(logFilePath, "Exiting now");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                LogToFile(logFilePath, $"An error occurred: {ex.Message}");
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void SetRegistryValue(RegistryKey key, string valueName, object value, RegistryValueKind valueKind, string logFilePath)
        {
            try
            {
                object existingValue = key.GetValue(valueName);

                if (existingValue == null)
                {
                    key.SetValue(valueName, value, valueKind);
                    LogToFile(logFilePath, $"Created and set {valueName} to {value}.");
                }
                else
                {
                    key.SetValue(valueName, value, valueKind);
                    LogToFile(logFilePath, $"Updated {valueName} to {value}.");
                }
            }
            catch (Exception ex)
            {
                LogToFile(logFilePath, $"Failed to set {valueName}: {ex.Message}");
            }
        }

        private void LogToFile(string filePath, string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write to log: {ex.Message}");
            }
        }
    }
}
