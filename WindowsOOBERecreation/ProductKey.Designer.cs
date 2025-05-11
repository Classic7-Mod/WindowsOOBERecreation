namespace WindowsOOBERecreation
{
    public partial class ProductKey : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsOOBERecreation.ProductKey));
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.button1 = new global::System.Windows.Forms.Button();
            this.nextButton = new global::System.Windows.Forms.Button();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.textBox1 = new global::System.Windows.Forms.TextBox();
            this.label5 = new global::System.Windows.Forms.Label();
            this.checkBox1 = new global::System.Windows.Forms.CheckBox();
            this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.panel1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Location = new global::System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(593, 40);
            this.panel1.TabIndex = 9;
            this.button1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.button1.Location = new global::System.Drawing.Point(439, 8);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(69, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Skip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.button1_Click);
            this.nextButton.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.nextButton.Location = new global::System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new global::System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new global::System.EventHandler(this.nextButton_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label2.Location = new global::System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(500, 45);
            this.label2.TabIndex = 18;
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
            this.label1.ForeColor = global::System.Drawing.Color.FromArgb(0, 51, 153);
            this.label1.Location = new global::System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(233, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type your Windows product key";
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.label3.Location = new global::System.Drawing.Point(37, 153);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(201, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "The product key looks similar to this:";
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.label4.Location = new global::System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(285, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "PRODUCT KEY: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            this.textBox1.Font = new global::System.Drawing.Font("Courier New", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.textBox1.Location = new global::System.Drawing.Point(38, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new global::System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.label5.Location = new global::System.Drawing.Point(37, 225);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(199, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "(dashes will be added automatically)";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.checkBox1.Location = new global::System.Drawing.Point(38, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new global::System.Drawing.Size(284, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Automatically activate Windows when I'm online";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.linkLabel1.LinkColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
            this.linkLabel1.Location = new global::System.Drawing.Point(35, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new global::System.Drawing.Size(106, 15);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What is activation?";
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
            this.linkLabel2.LinkColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
            this.linkLabel2.Location = new global::System.Drawing.Point(35, 370);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new global::System.Drawing.Size(151, 15);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Read our privacy statement";
            this.panel2.BackColor = global::System.Drawing.Color.FromArgb(223, 223, 223);
            this.panel2.Location = new global::System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 26;
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            base.ClientSize = new global::System.Drawing.Size(593, 466);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.linkLabel2);
            base.Controls.Add(this.linkLabel1);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.panel1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ProductKey";
            base.ShowIcon = false;
            base.Load += new global::System.EventHandler(this.ProductKey_Load);
            this.panel1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.Panel panel1;

        private global::System.Windows.Forms.Button nextButton;

        private global::System.Windows.Forms.Label label2;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.Label label3;

        private global::System.Windows.Forms.Label label4;

        private global::System.Windows.Forms.TextBox textBox1;

        private global::System.Windows.Forms.Label label5;

        private global::System.Windows.Forms.CheckBox checkBox1;

        private global::System.Windows.Forms.LinkLabel linkLabel1;

        private global::System.Windows.Forms.Button button1;

        private global::System.Windows.Forms.LinkLabel linkLabel2;

        private global::System.Windows.Forms.Panel panel2;
    }
}
