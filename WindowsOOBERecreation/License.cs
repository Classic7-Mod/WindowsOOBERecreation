using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class License : Form
    {
        public License(Main mainForm)
        {
            this.InitializeComponent();
            this._mainForm = mainForm;
            this._mainForm.DisablePictureBox();
            this.nextButton.Enabled = false;
            this.LoadLicenseFile();
            this.checkBox1.CheckedChanged += this.CheckBox1_CheckedChanged;
        }

        private void LoadLicenseFile()
        {
            string path = "C:\\Windows\\System32\\license.rtf";
            try
            {
                if (File.Exists(path))
                {
                    this.richTextBox1.LoadFile(path);
                }
            }
            catch (Exception)
            {
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.nextButton.Enabled = this.checkBox1.Checked;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Finalizing form = new Finalizing(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        private Main _mainForm;
    }
}
