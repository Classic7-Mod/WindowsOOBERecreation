using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Main : Form
    {
        private Panel mainPanel;
        public string Username { get; set; }
        public string ComputerName { get; set; }

        public Main()
        {
            InitializeComponent();

            Background backgroundForm = new Background();
            backgroundForm.Show();

            mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            this.TopMost = true;
            this.Controls.Add(mainPanel);

            LoadStartForm();

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backnotallowed))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backNotAllowed";

            EnablePictureBoxEvents();
        }

        private bool IsImageDisabled()
        {
            return backButtonPic.Tag?.ToString() == "backNotAllowed";
        }

        private void BackButtonPic_MouseEnter(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backhovered))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backHovered";
        }

        private void BackButtonPic_MouseLeave(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backAllowed";
        }

        private void BackButtonPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backpressed))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backPressed";
        }

        private void BackButtonPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backhovered))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backHovered";
        }

        public void LoadFormIntoPanel(Form form)
        {
            mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void LoadStartForm()
        {
            Start startForm = new Start(this);
            LoadFormIntoPanel(startForm);
        }

        public void LoadPasswordForm()
        {
            Password passwordForm = new Password(this, Username, ComputerName);
            LoadFormIntoPanel(passwordForm);
        }

        private void LoadTimeAndDateForm()
        {
            TimeAndDate timeAndDateForm = new TimeAndDate(this);
            LoadFormIntoPanel(timeAndDateForm);
        }

        private void LoadLicenseForm()
        {
            License LicenseForm = new License(this);
            LoadFormIntoPanel(LicenseForm);
        }

        public void DisablePictureBox()
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.backnotallowed))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backNotAllowed";

            DisablePictureBoxEvents();
        }

        public void EnablePictureBox()
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                backButtonPic.Image = Image.FromStream(ms);
            }
            backButtonPic.Tag = "backAllowed";

            EnablePictureBoxEvents();
        }

        public void DisablePictureBoxEvents()
        {
            backButtonPic.MouseEnter -= BackButtonPic_MouseEnter;
            backButtonPic.MouseLeave -= BackButtonPic_MouseLeave;
            backButtonPic.MouseDown -= BackButtonPic_MouseDown;
            backButtonPic.MouseUp -= BackButtonPic_MouseUp;
        }

        public void EnablePictureBoxEvents()
        {
            backButtonPic.MouseEnter += BackButtonPic_MouseEnter;
            backButtonPic.MouseLeave += BackButtonPic_MouseLeave;
            backButtonPic.MouseDown += BackButtonPic_MouseDown;
            backButtonPic.MouseUp += BackButtonPic_MouseUp;
        }
    }
}
