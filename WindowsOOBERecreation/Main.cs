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
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backnotallowed";

            EnablePictureBoxEvents();
        }

        private bool IsImageDisabled()
        {
            return pictureBox2.Tag?.ToString() == "backnotallowed";
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backhovered))
            {
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backhovered";
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backallowed";
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backpressed))
            {
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backpressed";
        }

        private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;

            using (MemoryStream ms = new MemoryStream(Properties.Resources.backhovered))
            {
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backhovered";
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
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backnotallowed";

            DisablePictureBoxEvents();
        }

        public void EnablePictureBox()
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                pictureBox2.Image = Image.FromStream(ms);
            }
            pictureBox2.Tag = "backallowed";

            EnablePictureBoxEvents();
        }

        public void DisablePictureBoxEvents()
        {
            pictureBox2.MouseEnter -= PictureBox2_MouseEnter;
            pictureBox2.MouseLeave -= PictureBox2_MouseLeave;
            pictureBox2.MouseDown -= PictureBox2_MouseDown;
            pictureBox2.MouseUp -= PictureBox2_MouseUp;
        }

        public void EnablePictureBoxEvents()
        {
            pictureBox2.MouseEnter += PictureBox2_MouseEnter;
            pictureBox2.MouseLeave += PictureBox2_MouseLeave;
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            pictureBox2.MouseUp += PictureBox2_MouseUp;
        }
    }
}
