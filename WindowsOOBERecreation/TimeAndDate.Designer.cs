namespace WindowsOOBERecreation
{
	// Token: 0x0200000A RID: 10
	public partial class TimeAndDate : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00005A8B File Offset: 0x00003C8B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005AAC File Offset: 0x00003CAC
		private void InitializeComponent()
		{
			this.monthCalendar1 = new global::System.Windows.Forms.MonthCalendar();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.nextButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timeZoneCombo = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.DSTCheckbox = new global::System.Windows.Forms.CheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.clockBrowser = new global::System.Windows.Forms.WebBrowser();
			this.label4 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.monthCalendar1.ForeColor = global::System.Drawing.Color.White;
			this.monthCalendar1.Location = new global::System.Drawing.Point(37, 193);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.ShowToday = false;
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.DateChanged += new global::System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.panel1.Controls.Add(this.nextButton);
			this.panel1.Location = new global::System.Drawing.Point(0, 426);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(593, 40);
			this.panel1.TabIndex = 8;
			this.nextButton.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.nextButton.Location = new global::System.Drawing.Point(514, 8);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new global::System.Drawing.Size(69, 23);
			this.nextButton.TabIndex = 7;
			this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new global::System.EventHandler(this.nextButton_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(0, 51, 153);
			this.label1.Location = new global::System.Drawing.Point(34, 51);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(253, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "Review your time and date settings";
			this.timeZoneCombo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.timeZoneCombo.FormattingEnabled = true;
			this.timeZoneCombo.Location = new global::System.Drawing.Point(39, 115);
			this.timeZoneCombo.Name = "timeZoneCombo";
			this.timeZoneCombo.Size = new global::System.Drawing.Size(328, 23);
			this.timeZoneCombo.TabIndex = 10;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(37, 90);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "Time zone:";
			this.DSTCheckbox.AutoSize = true;
			this.DSTCheckbox.Checked = true;
			this.DSTCheckbox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.DSTCheckbox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DSTCheckbox.Location = new global::System.Drawing.Point(38, 148);
			this.DSTCheckbox.Name = "DSTCheckbox";
			this.DSTCheckbox.Size = new global::System.Drawing.Size(299, 19);
			this.DSTCheckbox.TabIndex = 12;
			this.DSTCheckbox.Text = "Automatically adjust clock for Daylight Saving Time";
			this.DSTCheckbox.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(37, 183);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(34, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Date:";
			this.clockBrowser.Location = new global::System.Drawing.Point(298, 196);
			this.clockBrowser.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.clockBrowser.Name = "clockBrowser";
			this.clockBrowser.ScrollBarsEnabled = false;
			this.clockBrowser.Size = new global::System.Drawing.Size(140, 140);
			this.clockBrowser.TabIndex = 14;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(298, 183);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(37, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Time:";
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(223, 223, 223);
			this.panel2.Location = new global::System.Drawing.Point(0, 426);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(593, 1);
			this.panel2.TabIndex = 16;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(593, 466);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.clockBrowser);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.DSTCheckbox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.timeZoneCombo);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.monthCalendar1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimeAndDate";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004A RID: 74
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.MonthCalendar monthCalendar1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button nextButton;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ComboBox timeZoneCombo;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.CheckBox DSTCheckbox;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.WebBrowser clockBrowser;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Panel panel2;
	}
}
