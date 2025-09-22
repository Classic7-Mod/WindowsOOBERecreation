using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsOOBERecreation
{
    public partial class ProductKey : Form
    {
        private Main _mainForm;

        public ProductKey(Main mainForm)
        {
            this.AcceptButton = nextButton;
            _mainForm = mainForm;
            _mainForm.EnablePictureBox();
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            TimeAndDate timeAndDateForm = new TimeAndDate(_mainForm);
            _mainForm.LoadFormIntoPanel(timeAndDateForm);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            License licenseForm = new License(_mainForm);
            _mainForm.LoadFormIntoPanel(licenseForm);
        }

        // This adds the - between the product key
        private void ProductKeyBox_TextChanged(object sender, EventArgs e)
        {
            string input = new string(productKeyBox.Text.Where(char.IsLetterOrDigit).ToArray());
            input = input.ToUpper();

            if (input.Length > 25)
            {
                input = input.Substring(0, 25);
            }

            StringBuilder formattedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && i % 5 == 0)
                {
                    formattedInput.Append("-");
                }
                formattedInput.Append(input[i]);
            }

            productKeyBox.TextChanged -= ProductKeyBox_TextChanged;
            productKeyBox.Text = formattedInput.ToString();
            productKeyBox.SelectionStart = productKeyBox.Text.Length;
            productKeyBox.TextChanged += ProductKeyBox_TextChanged;
        }

        private void ProductKey_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                _mainForm.backButtonPic.Image = Image.FromStream(ms);
            }
        }
    }
}
