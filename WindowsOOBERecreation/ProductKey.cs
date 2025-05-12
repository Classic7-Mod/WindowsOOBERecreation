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
            _mainForm = mainForm;
            _mainForm.EnablePictureBox();
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            TimeAndDate timeAndDateForm = new TimeAndDate(_mainForm);
            _mainForm.LoadFormIntoPanel(timeAndDateForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeAndDate timeAndDateForm = new TimeAndDate(_mainForm);
            _mainForm.LoadFormIntoPanel(timeAndDateForm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = new string(textBox1.Text.Where(char.IsLetterOrDigit).ToArray());
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

            textBox1.TextChanged -= textBox1_TextChanged;
            textBox1.Text = formattedInput.ToString();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void ProductKey_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.backallowed))
            {
                _mainForm.pictureBox2.Image = Image.FromStream(ms);
            }
        }
    }
}
