using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
    public partial class Main : Form
    {
        public string Username { get; set; }

        public string ComputerName { get; set; }

        public Main()
        {
            this.InitializeComponent();
            new Background().Show();
            this.mainPanel = new Panel();
            this.mainPanel.Dock = DockStyle.Fill;
            base.TopMost = true;
            base.Controls.Add(this.mainPanel);
            this.LoadStartForm();
            using (MemoryStream memoryStream = new MemoryStream(Resources.backnotallowed))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backnotallowed";
            this.EnablePictureBoxEvents();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys)196722)
            {
                this.RunAuditMode();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RunAuditMode()
        {
            try
            {
                Process.Start("cmd.exe", "/C sysprep /audit /reboot");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to execute Audit Mode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private bool IsImageDisabled()
        {
            object tag = this.pictureBox2.Tag;
            return ((tag != null) ? tag.ToString() : null) == "backnotallowed";
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (this.IsImageDisabled())
            {
                return;
            }
            using (MemoryStream memoryStream = new MemoryStream(Resources.backhovered))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backhovered";
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (this.IsImageDisabled())
            {
                return;
            }
            using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backallowed";
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.IsImageDisabled())
            {
                return;
            }
            using (MemoryStream memoryStream = new MemoryStream(Resources.backpressed))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backpressed";
        }

        private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.IsImageDisabled())
            {
                return;
            }
            using (MemoryStream memoryStream = new MemoryStream(Resources.backhovered))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backhovered";
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            form.Show();
        }

        private void LoadStartForm()
        {
            Start form = new Start(this);
            this.LoadFormIntoPanel(form);
        }

        public void LoadPasswordForm()
        {
            Password form = new Password(this, this.Username, this.ComputerName);
            this.LoadFormIntoPanel(form);
        }

        private void LoadTimeAndDateForm()
        {
            TimeAndDate form = new TimeAndDate(this);
            this.LoadFormIntoPanel(form);
        }

        private void LoadLicenseForm()
        {
            License form = new License(this);
            this.LoadFormIntoPanel(form);
        }

        public void DisablePictureBox()
        {
            using (MemoryStream memoryStream = new MemoryStream(Resources.backnotallowed))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backnotallowed";
            this.DisablePictureBoxEvents();
        }

        public void EnablePictureBox()
        {
            using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
            {
                this.pictureBox2.Image = Image.FromStream(memoryStream);
            }
            this.pictureBox2.Tag = "backallowed";
            this.EnablePictureBoxEvents();
        }

        public void DisablePictureBoxEvents()
        {
            this.pictureBox2.MouseEnter -= this.PictureBox2_MouseEnter;
            this.pictureBox2.MouseLeave -= this.PictureBox2_MouseLeave;
            this.pictureBox2.MouseDown -= this.PictureBox2_MouseDown;
            this.pictureBox2.MouseUp -= this.PictureBox2_MouseUp;
        }

        public void EnablePictureBoxEvents()
        {
            this.pictureBox2.MouseEnter += this.PictureBox2_MouseEnter;
            this.pictureBox2.MouseLeave += this.PictureBox2_MouseLeave;
            this.pictureBox2.MouseDown += this.PictureBox2_MouseDown;
            this.pictureBox2.MouseUp += this.PictureBox2_MouseUp;
        }

        private Panel mainPanel;
    }
}
