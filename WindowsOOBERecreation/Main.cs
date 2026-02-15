using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Main : Form
    {
        private Panel mainPanel;
        public string Username { get; set; }
        public string ComputerName { get; set; }
        public int PageNumber = 0;

        private Image imgBackNotAllowed;
        private Image imgBackAllowed;
        private Image imgBackHovered;
        private Image imgBackPressed;

        public Main()
        {
            InitializeComponent();

            Background backgroundForm = new Background();
            backgroundForm.Show();

            imgBackNotAllowed = LoadImage(Properties.Resources.backnotallowed);
            imgBackAllowed = LoadImage(Properties.Resources.backallowed);
            imgBackHovered = LoadImage(Properties.Resources.backhovered);
            imgBackPressed = LoadImage(Properties.Resources.backpressed);

            mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            this.TopMost = true;
            this.Controls.Add(mainPanel);

            LoadStartForm();
            EnablePictureBoxEvents();
        }

        private bool IsImageDisabled()
        {
            return backButtonPic.Tag?.ToString() == "backNotAllowed";
        }

        private Image LoadImage(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void BackButtonPic_MouseEnter(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;
            backButtonPic.Image = imgBackHovered;
        }

        private void BackButtonPic_MouseLeave(object sender, EventArgs e)
        {
            if (IsImageDisabled()) return;
            backButtonPic.Image = imgBackAllowed;
        }

        private void BackButtonPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;
            backButtonPic.Image = imgBackPressed;
            HandleBackNav();
        }

        private void BackButtonPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsImageDisabled()) return;
            backButtonPic.Image = imgBackHovered;
        }

        public void DisablePictureBox()
        {
            backButtonPic.Image = imgBackNotAllowed;
            backButtonPic.Tag = "backNotAllowed";
            DisablePictureBoxEvents();
        }

        public void EnablePictureBox()
        {
            backButtonPic.Image = imgBackAllowed;
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

        public void HandleBackNav()
        {
            // buggy kinda, if you go for example:
            // password -> security -> time date
            // then go back to security and password and then go like that again up to time date
            // it'll send you back to password instead of security, if you know to fix this please lmk!!
            if (mainPanel.Controls[0] is Security securityForm)
            {
                buttonPanel.Visible = true;
                nextButton.Visible = true;

                LoadPasswordForm();
            }
            else if (mainPanel.Controls[0] is TimeAndDate timeAndDateForm)
            {
                buttonPanel.Visible = false;
                nextButton.Visible = false;

                LoadSecurityForm();
            }
            else if (mainPanel.Controls[0] is Network nwForm)
            {
                buttonPanel.Visible = true;
                nextButton.Visible = true;

                LoadTimeAndDateForm();
            }
        }

        public void LoadFormIntoPanel(Form form)
        {
            foreach (Control c in mainPanel.Controls)
            {
                c.Dispose();
            }
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

        public void LoadProductKeyForm()
        {
            ProductKey ProductKeyForm = new ProductKey(this);
            LoadFormIntoPanel(ProductKeyForm);
        }

        private void LoadSecurityForm()
        {
            Security securityForm = new Security(this);
            LoadFormIntoPanel(securityForm);
        }

        private void LoadTimeAndDateForm()
        {
            TimeAndDate timeAndDateForm = new TimeAndDate(this);
            LoadFormIntoPanel(timeAndDateForm);
        }

        private void LoadNetworkForm()
        {
            Network nwForm = new Network(this);
            LoadFormIntoPanel(nwForm);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls[0] is Start startForm)
            {
                startForm.MainBtnClick();
                LoadPasswordForm();
            }
            else if (mainPanel.Controls[0] is Password pwForm)
            {
                pwForm.MainBtnClick();

                buttonPanel.Visible = false;
                nextButton.Visible = false;

                LoadSecurityForm();
            }
            else if (mainPanel.Controls[0] is Security securityForm)
            {
                // Do nothing, security handles it.
            }
            else if (mainPanel.Controls[0] is TimeAndDate timeAndDateForm)
            {
                buttonPanel.Visible = false;
                nextButton.Visible = false;

                LoadNetworkForm();
            }
            else if (mainPanel.Controls[0] is Network nwForm)
            {
                // Do nothing, network handles it.
            }
        }
    }
}