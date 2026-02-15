using Microsoft.Win32;
using System;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Finalizing : Form
    {
        private Main _mainForm;

        public Finalizing(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _mainForm.DisablePictureBox();

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
            string usernameStr = Properties.Settings.Default.usernameStg;
            string passwordStr = Properties.Settings.Default.passwordStg;
            string confPassStr = Properties.Settings.Default.confPassStg;
            string compNameStr = Properties.Settings.Default.compNameStg;

            if (string.IsNullOrEmpty(passwordStr) && string.IsNullOrEmpty(confPassStr))
            {
                Helper.CreateUser(usernameStr, null);
            }
            else if (passwordStr == confPassStr)
            {
                Helper.CreateUser(usernameStr, passwordStr);
            }
            ChangeComputerName(compNameStr);

            string appDirectory = Application.StartupPath;
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

        private void SetRegistryValue(RegistryKey key, string valueName, object value, RegistryValueKind valueKind)
        {
            key.SetValue(valueName, value, valueKind);
        }
    }
}