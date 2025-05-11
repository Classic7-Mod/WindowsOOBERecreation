namespace WindowsOOBERecreation
{
    public partial class Password : global::System.Windows.Forms.Form
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
            this.nextButton = new global::System.Windows.Forms.Button();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.label1 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.confpasswordBox = new global::System.Windows.Forms.TextBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.passwordBox = new global::System.Windows.Forms.TextBox();
            this.label4 = new global::System.Windows.Forms.Label();
            this.passwordHintBox = new global::System.Windows.Forms.TextBox();
            this.label5 = new global::System.Windows.Forms.Label();
            this.label6 = new global::System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.nextButton.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.nextButton.Location = new global::System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new global::System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new global::System.EventHandler(this.nextButton_Click);
            this.panel1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Location = new global::System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(593, 40);
            this.panel1.TabIndex = 7;
            this.panel2.BackColor = global::System.Drawing.Color.FromArgb(223, 223, 223);
            this.panel2.Location = new global::System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 17;
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
            this.label1.ForeColor = global::System.Drawing.Color.FromArgb(0, 51, 153);
            this.label1.Location = new global::System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(233, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set a password for your account";
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label2.Location = new global::System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(494, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Creating a password is a smart security precaution that helps protect your user account from\r\nunwanted users. Be sure to remember your password or keep it in a safe place.\r\n";
            this.confpasswordBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.confpasswordBox.Location = new global::System.Drawing.Point(38, 209);
            this.confpasswordBox.Name = "confpasswordBox";
            this.confpasswordBox.Size = new global::System.Drawing.Size(240, 23);
            this.confpasswordBox.TabIndex = 13;
            this.confpasswordBox.UseSystemPasswordChar = true;
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label3.Location = new global::System.Drawing.Point(37, 189);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(126, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Retype your password:";
            this.passwordBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.passwordBox.Location = new global::System.Drawing.Point(38, 160);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new global::System.Drawing.Size(240, 23);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.UseSystemPasswordChar = true;
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label4.Location = new global::System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(185, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type a password (recommended):";
            this.passwordHintBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.passwordHintBox.Location = new global::System.Drawing.Point(38, 258);
            this.passwordHintBox.Name = "passwordHintBox";
            this.passwordHintBox.Size = new global::System.Drawing.Size(240, 23);
            this.passwordHintBox.TabIndex = 15;
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label5.Location = new global::System.Drawing.Point(37, 238);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(120, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type a password hint:";
            this.label6.AutoSize = true;
            this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label6.Location = new global::System.Drawing.Point(37, 289);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size(361, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Choose a word or phrase that helps your remember your password.\r\nIf you forget your password, Windows will show you your hint.\r\n";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            base.ClientSize = new global::System.Drawing.Size(593, 466);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.passwordHintBox);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.confpasswordBox);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.passwordBox);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.panel1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Password";
            base.ShowIcon = false;
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.Button nextButton;

        private global::System.Windows.Forms.Panel panel1;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.Label label2;

        private global::System.Windows.Forms.TextBox confpasswordBox;

        private global::System.Windows.Forms.Label label3;

        private global::System.Windows.Forms.TextBox passwordBox;

        private global::System.Windows.Forms.Label label4;

        private global::System.Windows.Forms.TextBox passwordHintBox;

        private global::System.Windows.Forms.Label label5;

        private global::System.Windows.Forms.Label label6;

        private global::System.Windows.Forms.Panel panel2;
    }
}
