namespace WindowsOOBERecreation
{
    partial class License
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.acceptCheck = new System.Windows.Forms.CheckBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.licensePanel = new System.Windows.Forms.Panel();
            this.licenseBox = new System.Windows.Forms.RichTextBox();
            this.somethingPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.licensePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleLabel.Location = new System.Drawing.Point(34, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(210, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Please read the license terms";
            // 
            // acceptCheck
            // 
            this.acceptCheck.AutoSize = true;
            this.acceptCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acceptCheck.Location = new System.Drawing.Point(38, 368);
            this.acceptCheck.Name = "acceptCheck";
            this.acceptCheck.Size = new System.Drawing.Size(159, 19);
            this.acceptCheck.TabIndex = 1;
            this.acceptCheck.Text = "I accept the license terms";
            this.acceptCheck.UseVisualStyleBackColor = true;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 426);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(593, 40);
            this.buttonPanel.TabIndex = 8;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // licensePanel
            // 
            this.licensePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.licensePanel.Controls.Add(this.licenseBox);
            this.licensePanel.Location = new System.Drawing.Point(38, 90);
            this.licensePanel.Name = "licensePanel";
            this.licensePanel.Size = new System.Drawing.Size(538, 264);
            this.licensePanel.TabIndex = 10;
            // 
            // licenseBox
            // 
            this.licenseBox.BackColor = System.Drawing.Color.White;
            this.licenseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.licenseBox.Location = new System.Drawing.Point(1, 1);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ReadOnly = true;
            this.licenseBox.Size = new System.Drawing.Size(536, 262);
            this.licenseBox.TabIndex = 0;
            this.licenseBox.Text = "";
            // 
            // somethingPanel
            // 
            this.somethingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.somethingPanel.Location = new System.Drawing.Point(0, 426);
            this.somethingPanel.Name = "somethingPanel";
            this.somethingPanel.Size = new System.Drawing.Size(593, 1);
            this.somethingPanel.TabIndex = 11;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.somethingPanel);
            this.Controls.Add(this.licensePanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.acceptCheck);
            this.Controls.Add(this.titleLabel);
            this.Name = "License";
            this.ShowIcon = false;
            this.buttonPanel.ResumeLayout(false);
            this.licensePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox acceptCheck;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel licensePanel;
        private System.Windows.Forms.RichTextBox licenseBox;
        private System.Windows.Forms.Panel somethingPanel;
    }
}