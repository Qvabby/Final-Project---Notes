namespace Final_Project___Notes.Auth
{
    partial class Login
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordErrorLabel = new System.Windows.Forms.Label();
            this.pswShowBtn = new System.Windows.Forms.Button();
            this.EMailFormatErrorLabel = new System.Windows.Forms.Label();
            this.UserTb = new System.Windows.Forms.TextBox();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(60, 25);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordErrorLabel
            // 
            this.PasswordErrorLabel.AutoSize = true;
            this.PasswordErrorLabel.Location = new System.Drawing.Point(93, 153);
            this.PasswordErrorLabel.Name = "PasswordErrorLabel";
            this.PasswordErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.PasswordErrorLabel.TabIndex = 19;
            this.PasswordErrorLabel.Text = "(Incorrect)";
            this.PasswordErrorLabel.Visible = false;
            // 
            // pswShowBtn
            // 
            this.pswShowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.pswShowBtn.FlatAppearance.BorderSize = 0;
            this.pswShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pswShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswShowBtn.Location = new System.Drawing.Point(203, 172);
            this.pswShowBtn.Name = "pswShowBtn";
            this.pswShowBtn.Size = new System.Drawing.Size(43, 27);
            this.pswShowBtn.TabIndex = 18;
            this.pswShowBtn.Text = "show";
            this.pswShowBtn.UseVisualStyleBackColor = false;
            this.pswShowBtn.Click += new System.EventHandler(this.pswShowBtn_Click);
            // 
            // EMailFormatErrorLabel
            // 
            this.EMailFormatErrorLabel.AutoSize = true;
            this.EMailFormatErrorLabel.Location = new System.Drawing.Point(138, 70);
            this.EMailFormatErrorLabel.Name = "EMailFormatErrorLabel";
            this.EMailFormatErrorLabel.Size = new System.Drawing.Size(54, 13);
            this.EMailFormatErrorLabel.TabIndex = 17;
            this.EMailFormatErrorLabel.Text = "(incorrect)";
            this.EMailFormatErrorLabel.Visible = false;
            // 
            // UserTb
            // 
            this.UserTb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTb.Location = new System.Drawing.Point(12, 86);
            this.UserTb.MaxLength = 50;
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(185, 27);
            this.UserTb.TabIndex = 14;
            // 
            // GmailLabel
            // 
            this.GmailLabel.AutoSize = true;
            this.GmailLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailLabel.Location = new System.Drawing.Point(11, 63);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(130, 20);
            this.GmailLabel.TabIndex = 15;
            this.GmailLabel.Text = "E-Mail / Username:";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(12, 170);
            this.PasswordTb.MaxLength = 50;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(185, 27);
            this.PasswordTb.TabIndex = 16;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(11, 147);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 20);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Password:";
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.SignInBtn.FlatAppearance.BorderSize = 0;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.Location = new System.Drawing.Point(15, 203);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 27);
            this.SignInBtn.TabIndex = 20;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(484, 379);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordErrorLabel);
            this.Controls.Add(this.pswShowBtn);
            this.Controls.Add(this.EMailFormatErrorLabel);
            this.Controls.Add(this.UserTb);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordErrorLabel;
        private System.Windows.Forms.Button pswShowBtn;
        private System.Windows.Forms.Label EMailFormatErrorLabel;
        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.Label GmailLabel;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SignInBtn;
    }
}