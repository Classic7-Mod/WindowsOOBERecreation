using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    // Token: 0x02000004 RID: 4
    public partial class License : Form
    {
        // Token: 0x0600000D RID: 13 RVA: 0x000028C0 File Offset: 0x00000AC0
        public License(Main mainForm)
        {
            this.InitializeComponent();
            this._mainForm = mainForm;
            this._mainForm.DisablePictureBox();
            this.nextButton.Enabled = false;
            this.LoadLicenseFile();
            this.checkBox1.CheckedChanged += this.CheckBox1_CheckedChanged;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002914 File Offset: 0x00000B14
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

        // Token: 0x0600000F RID: 15 RVA: 0x00002950 File Offset: 0x00000B50
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.nextButton.Enabled = this.checkBox1.Checked;
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002968 File Offset: 0x00000B68
        private void nextButton_Click(object sender, EventArgs e)
        {
            Finalizing form = new Finalizing(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        // Token: 0x04000007 RID: 7
        private Main _mainForm;
    }
}
