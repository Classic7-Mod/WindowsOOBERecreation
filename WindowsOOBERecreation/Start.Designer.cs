namespace WindowsOOBERecreation
{
    public partial class Start : global::System.Windows.Forms.Form
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
            this.label1 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.usernameBox = new global::System.Windows.Forms.TextBox();
            this.computernameBox = new global::System.Windows.Forms.TextBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.nextButton = new global::System.Windows.Forms.Button();
            this.label4 = new global::System.Windows.Forms.Label();
            this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
            this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label1.Location = new global::System.Drawing.Point(37, 168);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(514, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a user name for your account and name your computer to distinguish it on the network.";
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label2.Location = new global::System.Drawing.Point(167, 203);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(206, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type a user name (for example, John):";
            this.usernameBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.usernameBox.Location = new global::System.Drawing.Point(168, 218);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new global::System.Drawing.Size(240, 23);
            this.usernameBox.TabIndex = 3;
            this.computernameBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.computernameBox.Location = new global::System.Drawing.Point(168, 261);
            this.computernameBox.Name = "computernameBox";
            this.computernameBox.Size = new global::System.Drawing.Size(240, 23);
            this.computernameBox.TabIndex = 5;
            this.computernameBox.Text = "PC";
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label3.Location = new global::System.Drawing.Point(165, 242);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(131, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type a computer name:";
            this.panel1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Location = new global::System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(593, 40);
            this.panel1.TabIndex = 6;
            this.panel2.BackColor = global::System.Drawing.Color.FromArgb(223, 223, 223);
            this.panel2.Location = new global::System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 9;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.nextButton.Location = new global::System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new global::System.Drawing.Size(69, 23);
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new global::System.EventHandler(this.nextButton_Click);
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label4.Location = new global::System.Drawing.Point(262, 408);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(328, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Copyright © 2009 Microsoft Corporation.  All rights reserved.";
            this.pictureBox2.Image = global::WindowsOOBERecreation.Properties.Resources.image;
            this.pictureBox2.Location = new global::System.Drawing.Point(11, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new global::System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.Image = global::WindowsOOBERecreation.Properties.Resources.branding;
            this.pictureBox1.Location = new global::System.Drawing.Point(67, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new global::System.Drawing.Size(458, 72);
            this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            base.ClientSize = new global::System.Drawing.Size(593, 466);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.computernameBox);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.usernameBox);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.pictureBox1);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Start";
            base.ShowIcon = false;
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.PictureBox pictureBox1;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.Label label2;

        private global::System.Windows.Forms.TextBox usernameBox;

        private global::System.Windows.Forms.TextBox computernameBox;

        private global::System.Windows.Forms.Label label3;

        private global::System.Windows.Forms.Panel panel1;

        private global::System.Windows.Forms.Button nextButton;

        private global::System.Windows.Forms.Label label4;

        private global::System.Windows.Forms.PictureBox pictureBox2;

        private global::System.Windows.Forms.Panel panel2;
    }
}
