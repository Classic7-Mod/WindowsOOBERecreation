using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
    public partial class ProductKey : Form
    {
        public ProductKey(Main mainForm)
        {
            this._mainForm = mainForm;
            this._mainForm.EnablePictureBox();
            this.InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            TimeAndDate form = new TimeAndDate(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeAndDate form = new TimeAndDate(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = new string(this.textBox1.Text.Where(new Func<char, bool>(char.IsLetterOrDigit)).ToArray<char>());
            text = text.ToUpper();
            if (text.Length > 25)
            {
                text = text.Substring(0, 25);
            }
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && i % 5 == 0)
                {
                    stringBuilder.Append("-");
                }
                stringBuilder.Append(text[i]);
            }
            this.textBox1.TextChanged -= this.textBox1_TextChanged;
            this.textBox1.Text = stringBuilder.ToString();
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
            this.textBox1.TextChanged += this.textBox1_TextChanged;
        }

        private void ProductKey_Load(object sender, EventArgs e)
        {
            using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
            {
                this._mainForm.pictureBox2.Image = Image.FromStream(memoryStream);
            }
        }

        private Main _mainForm;
    }
}
