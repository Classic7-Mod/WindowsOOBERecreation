namespace WindowsOOBERecreation
{
    public partial class Main : global::System.Windows.Forms.Form
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
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsOOBERecreation.Main));
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.label1 = new global::System.Windows.Forms.Label();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
            this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.panel1.BackColor = global::System.Drawing.Color.FromArgb(185, 209, 234);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new global::System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(593, 31);
            this.panel1.TabIndex = 0;
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label1.Location = new global::System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Up Windows";
            this.panel2.BackColor = global::System.Drawing.Color.FromArgb(169, 191, 214);
            this.panel2.Location = new global::System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 1;
            this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
            this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new global::System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new global::System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsOOBERecreation.Properties.Resources.wysi_icon_10;
            this.pictureBox1.Location = new global::System.Drawing.Point(37, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new global::System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(593, 466);
            base.ControlBox = false;
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.panel1);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Main";
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "‎ ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            base.ResumeLayout(false);
        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.Panel panel1;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.Panel panel2;

        private global::System.Windows.Forms.PictureBox pictureBox1;

        public global::System.Windows.Forms.PictureBox pictureBox2;
    }
}
