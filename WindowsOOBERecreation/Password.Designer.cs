namespace WindowsOOBERecreation
{
    partial class Password
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.retypeLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passHintBox = new System.Windows.Forms.TextBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.securityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleLabel.Location = new System.Drawing.Point(34, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(237, 19);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Set a password for your account";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(37, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(516, 28);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Creating a password is a smart security precaution that helps protect your user a" +
    "ccount from\r\nunwanted users. Be sure to remember your password or keep it in a s" +
    "afe place.\r\n";
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassBox.Location = new System.Drawing.Point(38, 209);
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.Size = new System.Drawing.Size(240, 23);
            this.confirmPassBox.TabIndex = 13;
            this.confirmPassBox.UseSystemPasswordChar = true;
            // 
            // retypeLabel
            // 
            this.retypeLabel.AutoSize = true;
            this.retypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypeLabel.Location = new System.Drawing.Point(37, 189);
            this.retypeLabel.Name = "retypeLabel";
            this.retypeLabel.Size = new System.Drawing.Size(133, 14);
            this.retypeLabel.TabIndex = 12;
            this.retypeLabel.Text = "Retype your password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(38, 160);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(240, 23);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(37, 140);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(197, 14);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Type a password (recommended):";
            // 
            // passHintBox
            // 
            this.passHintBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passHintBox.Location = new System.Drawing.Point(38, 258);
            this.passHintBox.Name = "passHintBox";
            this.passHintBox.Size = new System.Drawing.Size(240, 23);
            this.passHintBox.TabIndex = 15;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(37, 238);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(129, 14);
            this.hintLabel.TabIndex = 14;
            this.hintLabel.Text = "Type a password hint:";
            // 
            // securityLabel
            // 
            this.securityLabel.AutoSize = true;
            this.securityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityLabel.Location = new System.Drawing.Point(37, 289);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(374, 28);
            this.securityLabel.TabIndex = 16;
            this.securityLabel.Text = "Choose a word or phrase that helps you remember your password.\r\nIf you forget you" +
    "r password, Windows will show you your hint.\r\n";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.securityLabel);
            this.Controls.Add(this.passHintBox);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.confirmPassBox);
            this.Controls.Add(this.retypeLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.Label retypeLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passHintBox;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label securityLabel;
    }
}