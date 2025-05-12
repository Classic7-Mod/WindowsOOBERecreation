using System;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Start : Form
    {
        private Main _mainForm;
        private int clickCount = 0;
        private Timer clickTimer;

        public string Username { get; private set; }
        public string ComputerName { get; private set; }

        public Start(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            usernameBox.TextChanged += UsernameBox_TextChanged;
            usernameBox.AutoSize = false;
            usernameBox.Height = 20;
            computernameBox.KeyPress += ComputernameBox_KeyPress;
            computernameBox.AutoSize = false;
            computernameBox.Height = 20;
            nextButton.Enabled = false;

            clickTimer = new Timer();
            clickTimer.Interval = 300;
            clickTimer.Tick += ClickTimer_Tick;

            pictureBox1.MouseClick += PictureBox1_MouseClick;
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            string sanitizedUsername = usernameBox.Text.Replace(" ", string.Empty);
            computernameBox.Text = $"{sanitizedUsername}-PC";

            nextButton.Enabled = !string.IsNullOrWhiteSpace(usernameBox.Text);

            Username = sanitizedUsername;
            ComputerName = computernameBox.Text;
        }

        private void ComputernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _mainForm.Username = Username;
            _mainForm.ComputerName = ComputerName;

            _mainForm.LoadPasswordForm();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickCount++;

                if (clickCount == 1)
                {
                    clickTimer.Start();
                }
                else if (clickCount == 3)
                {
                    clickTimer.Stop();
                    MessageBox.Show("made with love by patricktbp");
                    clickCount = 0;
                }
            }
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            clickCount = 0;
            clickTimer.Stop();
        }
    }
}
