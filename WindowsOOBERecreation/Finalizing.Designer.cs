namespace WindowsOOBERecreation
{
	// Token: 0x02000003 RID: 3
	public partial class Finalizing : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002678 File Offset: 0x00000878
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002698 File Offset: 0x00000898
		private void InitializeComponent()
		{
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.progressBar1.Location = new global::System.Drawing.Point(107, 225);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(396, 15);
			this.progressBar1.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(199, 206);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(189, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Windows is finalizing your settings";
			this.pictureBox1.Image = global::WindowsOOBERecreation.Properties.Resources.branding;
			this.pictureBox1.Location = new global::System.Drawing.Point(67, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(458, 72);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(593, 466);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.pictureBox1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Finalizing";
			base.ShowIcon = false;
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;
	}
}
