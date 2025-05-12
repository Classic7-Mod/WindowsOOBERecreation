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
            _mainForm.DisablePictureBox();

            nextButton.Enabled = false;
            LoadLicenseFile();
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void LoadLicenseFile()
        {
            string licensePath = @"C:\Windows\System32\license.rtf";

            try
            {
                if (File.Exists(licensePath))
                {
                    richTextBox1.LoadFile(licensePath);
                }
                else
                {
                    MessageBox.Show("License file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the license: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = checkBox1.Checked;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Finalizing finalizingForm = new Finalizing(_mainForm);
            _mainForm.LoadFormIntoPanel(finalizingForm);
        }
    }
}
