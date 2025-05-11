namespace WindowsOOBERecreation
{
	// Token: 0x02000004 RID: 4
	public partial class License : global::System.Windows.Forms.Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000298D File Offset: 0x00000B8D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029AC File Offset: 0x00000BAC
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.nextButton = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(0, 51, 153);
			this.label1.Location = new global::System.Drawing.Point(34, 50);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(210, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please read the license terms";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBox1.Location = new global::System.Drawing.Point(38, 368);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(159, 19);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "I accept the license terms";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.panel1.Controls.Add(this.nextButton);
			this.panel1.Location = new global::System.Drawing.Point(0, 426);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(593, 40);
			this.panel1.TabIndex = 8;
			this.nextButton.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.nextButton.Location = new global::System.Drawing.Point(514, 8);
			this.nextButton.Name = "nextButton";
			this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.nextButton.Size = new global::System.Drawing.Size(69, 23);
			this.nextButton.TabIndex = 7;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new global::System.EventHandler(this.nextButton_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(227, 227, 227);
			this.panel2.Controls.Add(this.richTextBox1);
			this.panel2.Location = new global::System.Drawing.Point(38, 90);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(538, 264);
			this.panel2.TabIndex = 10;
			this.richTextBox1.BackColor = global::System.Drawing.Color.White;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new global::System.Drawing.Point(1, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(536, 262);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(223, 223, 223);
			this.panel3.Location = new global::System.Drawing.Point(0, 426);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(593, 1);
			this.panel3.TabIndex = 11;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(593, 466);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.label1);
			base.Name = "License";
			base.ShowIcon = false;
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button nextButton;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Panel panel3;
	}
}
