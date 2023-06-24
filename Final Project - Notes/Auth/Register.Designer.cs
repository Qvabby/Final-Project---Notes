namespace Final_Project___Notes.Auth
{
    partial class Register
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
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.GmailTb = new System.Windows.Forms.TextBox();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.UsernameTakenLabel = new System.Windows.Forms.Label();
            this.EMailFormatErrorLabel = new System.Windows.Forms.Label();
            this.pswShowBtn = new System.Windows.Forms.Button();
            this.PasswordErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(12, 9);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(83, 25);
            this.RegisterLabel.TabIndex = 1;
            this.RegisterLabel.Text = "Register";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTb.Location = new System.Drawing.Point(17, 95);
            this.UsernameTb.MaxLength = 20;
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(185, 27);
            this.UsernameTb.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(16, 72);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 20);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(16, 233);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(17, 256);
            this.PasswordTb.MaxLength = 50;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(185, 27);
            this.PasswordTb.TabIndex = 7;
            // 
            // GmailTb
            // 
            this.GmailTb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailTb.Location = new System.Drawing.Point(17, 172);
            this.GmailTb.MaxLength = 50;
            this.GmailTb.Name = "GmailTb";
            this.GmailTb.Size = new System.Drawing.Size(185, 27);
            this.GmailTb.TabIndex = 5;
            // 
            // GmailLabel
            // 
            this.GmailLabel.AutoSize = true;
            this.GmailLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailLabel.Location = new System.Drawing.Point(16, 149);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(51, 20);
            this.GmailLabel.TabIndex = 6;
            this.GmailLabel.Text = "E-Mail:";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(17, 337);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 30);
            this.SignUpBtn.TabIndex = 8;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // UsernameTakenLabel
            // 
            this.UsernameTakenLabel.AutoSize = true;
            this.UsernameTakenLabel.Location = new System.Drawing.Point(101, 78);
            this.UsernameTakenLabel.Name = "UsernameTakenLabel";
            this.UsernameTakenLabel.Size = new System.Drawing.Size(104, 13);
            this.UsernameTakenLabel.TabIndex = 9;
            this.UsernameTakenLabel.Text = "(Username is taken.)";
            this.UsernameTakenLabel.Visible = false;
            // 
            // EMailFormatErrorLabel
            // 
            this.EMailFormatErrorLabel.AutoSize = true;
            this.EMailFormatErrorLabel.Location = new System.Drawing.Point(73, 155);
            this.EMailFormatErrorLabel.Name = "EMailFormatErrorLabel";
            this.EMailFormatErrorLabel.Size = new System.Drawing.Size(127, 13);
            this.EMailFormatErrorLabel.TabIndex = 10;
            this.EMailFormatErrorLabel.Text = "(E-mail is incorrect format)";
            this.EMailFormatErrorLabel.Visible = false;
            // 
            // pswShowBtn
            // 
            this.pswShowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.pswShowBtn.FlatAppearance.BorderSize = 0;
            this.pswShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pswShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswShowBtn.Location = new System.Drawing.Point(208, 256);
            this.pswShowBtn.Name = "pswShowBtn";
            this.pswShowBtn.Size = new System.Drawing.Size(43, 27);
            this.pswShowBtn.TabIndex = 11;
            this.pswShowBtn.Text = "show";
            this.pswShowBtn.UseVisualStyleBackColor = false;
            this.pswShowBtn.Click += new System.EventHandler(this.pswShowBtn_Click);
            // 
            // PasswordErrorLabel
            // 
            this.PasswordErrorLabel.AutoSize = true;
            this.PasswordErrorLabel.Location = new System.Drawing.Point(98, 239);
            this.PasswordErrorLabel.Name = "PasswordErrorLabel";
            this.PasswordErrorLabel.Size = new System.Drawing.Size(116, 13);
            this.PasswordErrorLabel.TabIndex = 12;
            this.PasswordErrorLabel.Text = "(Minimum 8 characters)";
            this.PasswordErrorLabel.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(484, 379);
            this.Controls.Add(this.PasswordErrorLabel);
            this.Controls.Add(this.pswShowBtn);
            this.Controls.Add(this.EMailFormatErrorLabel);
            this.Controls.Add(this.UsernameTakenLabel);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.GmailTb);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.RegisterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox GmailTb;
        private System.Windows.Forms.Label GmailLabel;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label UsernameTakenLabel;
        private System.Windows.Forms.Label EMailFormatErrorLabel;
        private System.Windows.Forms.Button pswShowBtn;
        private System.Windows.Forms.Label PasswordErrorLabel;
    }
}