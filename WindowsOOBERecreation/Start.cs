// somethingPanel is called that because I forgot what it does
// God I haven't touched this source code in a while
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsOOBERecreation
{
    public partial class Start : Form
    {
        private Main _mainForm;
        public string Username { get; private set; }
        public string ComputerName { get; private set; }

        public Start(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.AcceptButton = nextButton;

            // This fixes the issue of text boxes not being resizable in forms
            usernameBox.TextChanged += UsernameBox_TextChanged;
            usernameBox.AutoSize = false;
            usernameBox.Height = 20;

            // The ComputerNameBox_KeyPress() function makes it so you can't press space
            computerNameBox.KeyPress += ComputerNameBox_KeyPress;
            computerNameBox.AutoSize = false;
            computerNameBox.Height = 20;
            nextButton.Enabled = false;

            windowsBrandingPic.MouseClick += WindowsBrandingPic_MouseClick;
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            string UsernameNoSpaces = usernameBox.Text.Replace(" ", string.Empty);
            computerNameBox.Text = string.IsNullOrEmpty(UsernameNoSpaces)
                ? "PC"
                : $"{UsernameNoSpaces}-PC";

            nextButton.Enabled = !string.IsNullOrWhiteSpace(UsernameNoSpaces);

            Username = UsernameNoSpaces;
            ComputerName = computerNameBox.Text;
        }

        private void ComputerNameBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void WindowsBrandingPic_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Made with love by bricktapper! / patricktbp <3", "WindowsOOBERecreation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void EOAPic_Click(object sender, EventArgs e)
        {
            ExecuteCommand("Utilman.exe");
        }

        private void ExecuteCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception(error);
                }
            }
        }
    }
}
