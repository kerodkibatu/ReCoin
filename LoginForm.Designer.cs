namespace ReCoin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFrvr = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.PasswordInput = new ReaLTaiizor.Controls.ForeverTextBox();
            this.UsernameInput = new ReaLTaiizor.Controls.ForeverTextBox();
            this.LoginBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.SignUpBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.LoginFrvr.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginFrvr
            // 
            this.LoginFrvr.BackColor = System.Drawing.Color.White;
            this.LoginFrvr.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LoginFrvr.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginFrvr.Controls.Add(this.foreverLabel2);
            this.LoginFrvr.Controls.Add(this.foreverLabel1);
            this.LoginFrvr.Controls.Add(this.PasswordInput);
            this.LoginFrvr.Controls.Add(this.UsernameInput);
            this.LoginFrvr.Controls.Add(this.LoginBtn);
            this.LoginFrvr.Controls.Add(this.SignUpBtn);
            this.LoginFrvr.Controls.Add(this.foreverClose1);
            this.LoginFrvr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginFrvr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginFrvr.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.LoginFrvr.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoginFrvr.HeaderMaximize = false;
            this.LoginFrvr.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginFrvr.Image = ((System.Drawing.Image)(resources.GetObject("LoginFrvr.Image")));
            this.LoginFrvr.Location = new System.Drawing.Point(0, 0);
            this.LoginFrvr.MinimumSize = new System.Drawing.Size(210, 50);
            this.LoginFrvr.Name = "LoginFrvr";
            this.LoginFrvr.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.LoginFrvr.Sizable = true;
            this.LoginFrvr.Size = new System.Drawing.Size(263, 423);
            this.LoginFrvr.TabIndex = 0;
            this.LoginFrvr.Text = "Login/Sign Up";
            this.LoginFrvr.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.LoginFrvr.TextLight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.foreverLabel2.Location = new System.Drawing.Point(26, 173);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(122, 36);
            this.foreverLabel2.TabIndex = 6;
            this.foreverLabel2.Text = "Password";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.foreverLabel1.Location = new System.Drawing.Point(26, 89);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(131, 36);
            this.foreverLabel1.TabIndex = 5;
            this.foreverLabel1.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.Transparent;
            this.PasswordInput.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.PasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.PasswordInput.FocusOnHover = false;
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PasswordInput.Location = new System.Drawing.Point(26, 212);
            this.PasswordInput.MaxLength = 32767;
            this.PasswordInput.Multiline = false;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.ReadOnly = false;
            this.PasswordInput.Size = new System.Drawing.Size(209, 42);
            this.PasswordInput.TabIndex = 4;
            this.PasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UsernameInput
            // 
            this.UsernameInput.BackColor = System.Drawing.Color.Transparent;
            this.UsernameInput.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.UsernameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.UsernameInput.FocusOnHover = false;
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UsernameInput.Location = new System.Drawing.Point(26, 128);
            this.UsernameInput.MaxLength = 32767;
            this.UsernameInput.Multiline = false;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.ReadOnly = false;
            this.UsernameInput.Size = new System.Drawing.Size(209, 42);
            this.UsernameInput.TabIndex = 3;
            this.UsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameInput.UseSystemPasswordChar = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(26, 260);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Rounded = false;
            this.LoginBtn.Size = new System.Drawing.Size(96, 40);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LoginBtn.Click += new System.EventHandler(this.LoginClicked);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpBtn.Location = new System.Drawing.Point(128, 260);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Rounded = false;
            this.SignUpBtn.Size = new System.Drawing.Size(107, 40);
            this.SignUpBtn.TabIndex = 1;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpClicked);
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.White;
            this.foreverClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = true;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverClose1.Location = new System.Drawing.Point(233, 16);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 0;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 423);
            this.Controls.Add(this.LoginFrvr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1160);
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.LoginFrvr.ResumeLayout(false);
            this.LoginFrvr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm LoginFrvr;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverButton LoginBtn;
        private ReaLTaiizor.Controls.ForeverButton SignUpBtn;
        private ReaLTaiizor.Controls.ForeverTextBox PasswordInput;
        private ReaLTaiizor.Controls.ForeverTextBox UsernameInput;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
    }
}