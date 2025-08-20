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

            finalizingProgBar.Style = ProgressBarStyle.Marquee;
            finalizingProgBar.MarqueeAnimationSpeed = 30;

            FinalizeAfterDelay();
        }

        private async void FinalizeAfterDelay()
        {
            // We add a delay here to trick the user into thinking it's doing something
            // However, it's really doing nothing other than wasting the users time. (My bad 💔)
            await Task.Delay(15000);
            FinalizeTheOOBE();
        }

        private void FinalizeTheOOBE()
        {
            string appDirectory = Application.StartupPath;
            using (RegistryKey winlogonKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true))
            {
                if (winlogonKey != null)
                {
                    string passwordReg = Properties.Settings.Default.password ?? "";
                    SetRegistryValue(winlogonKey, "AutoAdminLogon", "1", RegistryValueKind.String);
                    SetRegistryValue(winlogonKey, "AutoLogonCount", 2, RegistryValueKind.DWord);
                    SetRegistryValue(winlogonKey, "DefaultUserName", Properties.Settings.Default.username, RegistryValueKind.String);
                    SetRegistryValue(winlogonKey, "DefaultPassword", passwordReg, RegistryValueKind.String);
                }
            }

            using (RegistryKey setupKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup", true))
            {
                if (setupKey != null)
                {
                    SetRegistryValue(setupKey, "OOBEInProgress", 0, RegistryValueKind.DWord);
                    SetRegistryValue(setupKey, "RestartSetup", 0, RegistryValueKind.DWord);
                    SetRegistryValue(setupKey, "SetupPhase", 0, RegistryValueKind.DWord);
                    SetRegistryValue(setupKey, "SetupSupported", 1, RegistryValueKind.DWord);
                    SetRegistryValue(setupKey, "SetupType", 0, RegistryValueKind.DWord);
                    SetRegistryValue(setupKey, "SystemSetupInProgress", 0, RegistryValueKind.DWord);
                }
            }

            Environment.Exit(0);
        }

        private void SetRegistryValue(RegistryKey key, string valueName, object value, RegistryValueKind valueKind)
        {
            key.SetValue(valueName, value, valueKind);
        }
    }
}
