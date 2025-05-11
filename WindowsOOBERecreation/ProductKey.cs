using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsOOBERecreation.Properties;

namespace WindowsOOBERecreation
{
    // Token: 0x02000007 RID: 7
    public partial class ProductKey : Form
    {
        // Token: 0x06000032 RID: 50 RVA: 0x0000424A File Offset: 0x0000244A
        public ProductKey(Main mainForm)
        {
            this._mainForm = mainForm;
            this._mainForm.EnablePictureBox();
            this.InitializeComponent();
        }

        // Token: 0x06000033 RID: 51 RVA: 0x0000426C File Offset: 0x0000246C
        private void nextButton_Click(object sender, EventArgs e)
        {
            TimeAndDate form = new TimeAndDate(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00004294 File Offset: 0x00002494
        private void button1_Click(object sender, EventArgs e)
        {
            TimeAndDate form = new TimeAndDate(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        // Token: 0x06000035 RID: 53 RVA: 0x000042BC File Offset: 0x000024BC
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

        // Token: 0x06000036 RID: 54 RVA: 0x000043A0 File Offset: 0x000025A0
        private void ProductKey_Load(object sender, EventArgs e)
        {
            using (MemoryStream memoryStream = new MemoryStream(Resources.backallowed))
            {
                this._mainForm.pictureBox2.Image = Image.FromStream(memoryStream);
            }
        }

        // Token: 0x04000029 RID: 41
        private Main _mainForm;
    }
}
