using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class License : Form
    {
        private Main _mainForm;

        public License(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.AcceptButton = nextButton;
            _mainForm.DisablePictureBox();

            nextButton.Enabled = false;
            LoadLicenseFile();
            acceptCheck.CheckedChanged += AcceptCheck_CheckedChanged;
        }

        private void LoadLicenseFile()
        {
            string licensePath = @"C:\Windows\System32\license.rtf";
            licenseBox.LoadFile(licensePath);
        }

        private void AcceptCheck_CheckedChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = acceptCheck.Checked;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Security securityForm = new Security(_mainForm);
            _mainForm.LoadFormIntoPanel(securityForm);
        }
    }
}
