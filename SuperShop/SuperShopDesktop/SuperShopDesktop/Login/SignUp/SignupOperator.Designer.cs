namespace SuperShopDesktop.Login.SignUp
{
    partial class SignupOperator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.glbl_name = new Guna.UI.WinForms.GunaLabel();
            this.gchb_showpass = new Guna.UI.WinForms.GunaCheckBox();
            this.gtb_confirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_confirmPassword = new Guna.UI.WinForms.GunaLabel();
            this.glbl_errorMessage = new Guna.UI.WinForms.GunaLabel();
            this.gbtn_signup = new Guna.UI.WinForms.GunaButton();
            this.gtb_password = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_password = new Guna.UI.WinForms.GunaLabel();
            this.gtb_phone = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_phone = new Guna.UI.WinForms.GunaLabel();
            this.gtb_email = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_email = new Guna.UI.WinForms.GunaLabel();
            this.gtb_surname = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_surname = new Guna.UI.WinForms.GunaLabel();
            this.gtb_name = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // glbl_name
            // 
            this.glbl_name.AutoSize = true;
            this.glbl_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_name.Location = new System.Drawing.Point(3, 30);
            this.glbl_name.Name = "glbl_name";
            this.glbl_name.Size = new System.Drawing.Size(49, 20);
            this.glbl_name.TabIndex = 3;
            this.glbl_name.Text = "Name";
            // 
            // gchb_showpass
            // 
            this.gchb_showpass.BaseColor = System.Drawing.Color.White;
            this.gchb_showpass.CheckedOffColor = System.Drawing.Color.Gray;
            this.gchb_showpass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gchb_showpass.FillColor = System.Drawing.Color.White;
            this.gchb_showpass.Location = new System.Drawing.Point(281, 252);
            this.gchb_showpass.Name = "gchb_showpass";
            this.gchb_showpass.Radius = 3;
            this.gchb_showpass.Size = new System.Drawing.Size(58, 20);
            this.gchb_showpass.TabIndex = 31;
            this.gchb_showpass.Text = "Show";
            this.gchb_showpass.CheckedChanged += new System.EventHandler(this.gchb_showpass_CheckedChanged);
            // 
            // gtb_confirmPassword
            // 
            this.gtb_confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.gtb_confirmPassword.BaseColor = System.Drawing.Color.White;
            this.gtb_confirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.gtb_confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_confirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_confirmPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_confirmPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_confirmPassword.Location = new System.Drawing.Point(179, 216);
            this.gtb_confirmPassword.Name = "gtb_confirmPassword";
            this.gtb_confirmPassword.PasswordChar = '●';
            this.gtb_confirmPassword.Radius = 10;
            this.gtb_confirmPassword.SelectedText = "";
            this.gtb_confirmPassword.Size = new System.Drawing.Size(160, 30);
            this.gtb_confirmPassword.TabIndex = 30;
            this.gtb_confirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_confirmPassword_KeyDown);
            // 
            // glbl_confirmPassword
            // 
            this.glbl_confirmPassword.AutoSize = true;
            this.glbl_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_confirmPassword.Location = new System.Drawing.Point(181, 183);
            this.glbl_confirmPassword.Name = "glbl_confirmPassword";
            this.glbl_confirmPassword.Size = new System.Drawing.Size(129, 20);
            this.glbl_confirmPassword.TabIndex = 29;
            this.glbl_confirmPassword.Text = "Confirm password";
            // 
            // glbl_errorMessage
            // 
            this.glbl_errorMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glbl_errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.glbl_errorMessage.Location = new System.Drawing.Point(87, 336);
            this.glbl_errorMessage.Name = "glbl_errorMessage";
            this.glbl_errorMessage.Size = new System.Drawing.Size(161, 53);
            this.glbl_errorMessage.TabIndex = 28;
            this.glbl_errorMessage.Text = "Everything is okey";
            this.glbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glbl_errorMessage.Visible = false;
            // 
            // gbtn_signup
            // 
            this.gbtn_signup.AnimationHoverSpeed = 0.07F;
            this.gbtn_signup.AnimationSpeed = 0.03F;
            this.gbtn_signup.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_signup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_signup.BorderColor = System.Drawing.Color.Black;
            this.gbtn_signup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_signup.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_signup.ForeColor = System.Drawing.Color.White;
            this.gbtn_signup.Image = null;
            this.gbtn_signup.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_signup.Location = new System.Drawing.Point(88, 278);
            this.gbtn_signup.Name = "gbtn_signup";
            this.gbtn_signup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_signup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_signup.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_signup.OnHoverImage = null;
            this.gbtn_signup.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_signup.Radius = 10;
            this.gbtn_signup.Size = new System.Drawing.Size(160, 42);
            this.gbtn_signup.TabIndex = 27;
            this.gbtn_signup.Text = "Sign up";
            this.gbtn_signup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_signup.Click += new System.EventHandler(this.gbtn_signup_Click);
            // 
            // gtb_password
            // 
            this.gtb_password.BackColor = System.Drawing.Color.Transparent;
            this.gtb_password.BaseColor = System.Drawing.Color.White;
            this.gtb_password.BorderColor = System.Drawing.Color.Silver;
            this.gtb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_password.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_password.Location = new System.Drawing.Point(7, 216);
            this.gtb_password.Name = "gtb_password";
            this.gtb_password.PasswordChar = '●';
            this.gtb_password.Radius = 10;
            this.gtb_password.SelectedText = "";
            this.gtb_password.Size = new System.Drawing.Size(160, 30);
            this.gtb_password.TabIndex = 26;
            this.gtb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_password_KeyDown);
            // 
            // glbl_password
            // 
            this.glbl_password.AutoSize = true;
            this.glbl_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_password.Location = new System.Drawing.Point(6, 183);
            this.glbl_password.Name = "glbl_password";
            this.glbl_password.Size = new System.Drawing.Size(71, 20);
            this.glbl_password.TabIndex = 25;
            this.glbl_password.Text = "Password";
            // 
            // gtb_phone
            // 
            this.gtb_phone.BackColor = System.Drawing.Color.Transparent;
            this.gtb_phone.BaseColor = System.Drawing.Color.White;
            this.gtb_phone.BorderColor = System.Drawing.Color.Silver;
            this.gtb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_phone.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_phone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_phone.Location = new System.Drawing.Point(179, 139);
            this.gtb_phone.Name = "gtb_phone";
            this.gtb_phone.PasswordChar = '\0';
            this.gtb_phone.Radius = 10;
            this.gtb_phone.SelectedText = "";
            this.gtb_phone.Size = new System.Drawing.Size(160, 30);
            this.gtb_phone.TabIndex = 24;
            this.gtb_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_phone_KeyDown);
            // 
            // glbl_phone
            // 
            this.glbl_phone.AutoSize = true;
            this.glbl_phone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_phone.Location = new System.Drawing.Point(181, 107);
            this.glbl_phone.Name = "glbl_phone";
            this.glbl_phone.Size = new System.Drawing.Size(50, 20);
            this.glbl_phone.TabIndex = 23;
            this.glbl_phone.Text = "Phone";
            // 
            // gtb_email
            // 
            this.gtb_email.BackColor = System.Drawing.Color.Transparent;
            this.gtb_email.BaseColor = System.Drawing.Color.White;
            this.gtb_email.BorderColor = System.Drawing.Color.Silver;
            this.gtb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_email.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_email.Location = new System.Drawing.Point(7, 139);
            this.gtb_email.Name = "gtb_email";
            this.gtb_email.PasswordChar = '\0';
            this.gtb_email.Radius = 10;
            this.gtb_email.SelectedText = "";
            this.gtb_email.Size = new System.Drawing.Size(160, 30);
            this.gtb_email.TabIndex = 22;
            this.gtb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_email_KeyDown);
            // 
            // glbl_email
            // 
            this.glbl_email.AutoSize = true;
            this.glbl_email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_email.Location = new System.Drawing.Point(6, 107);
            this.glbl_email.Name = "glbl_email";
            this.glbl_email.Size = new System.Drawing.Size(46, 20);
            this.glbl_email.TabIndex = 21;
            this.glbl_email.Text = "Email";
            // 
            // gtb_surname
            // 
            this.gtb_surname.BackColor = System.Drawing.Color.Transparent;
            this.gtb_surname.BaseColor = System.Drawing.Color.White;
            this.gtb_surname.BorderColor = System.Drawing.Color.Silver;
            this.gtb_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_surname.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_surname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_surname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_surname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_surname.Location = new System.Drawing.Point(179, 63);
            this.gtb_surname.Name = "gtb_surname";
            this.gtb_surname.PasswordChar = '\0';
            this.gtb_surname.Radius = 10;
            this.gtb_surname.SelectedText = "";
            this.gtb_surname.Size = new System.Drawing.Size(160, 30);
            this.gtb_surname.TabIndex = 20;
            this.gtb_surname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_surname_KeyDown);
            // 
            // glbl_surname
            // 
            this.glbl_surname.AutoSize = true;
            this.glbl_surname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_surname.Location = new System.Drawing.Point(181, 30);
            this.glbl_surname.Name = "glbl_surname";
            this.glbl_surname.Size = new System.Drawing.Size(67, 20);
            this.glbl_surname.TabIndex = 19;
            this.glbl_surname.Text = "Surname";
            // 
            // gtb_name
            // 
            this.gtb_name.BackColor = System.Drawing.Color.Transparent;
            this.gtb_name.BaseColor = System.Drawing.Color.White;
            this.gtb_name.BorderColor = System.Drawing.Color.Silver;
            this.gtb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_name.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_name.Location = new System.Drawing.Point(7, 63);
            this.gtb_name.Name = "gtb_name";
            this.gtb_name.PasswordChar = '\0';
            this.gtb_name.Radius = 10;
            this.gtb_name.SelectedText = "";
            this.gtb_name.Size = new System.Drawing.Size(160, 30);
            this.gtb_name.TabIndex = 18;
            this.gtb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_name_KeyDown);
            // 
            // SignupOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gchb_showpass);
            this.Controls.Add(this.gtb_confirmPassword);
            this.Controls.Add(this.glbl_confirmPassword);
            this.Controls.Add(this.glbl_errorMessage);
            this.Controls.Add(this.gbtn_signup);
            this.Controls.Add(this.gtb_password);
            this.Controls.Add(this.glbl_password);
            this.Controls.Add(this.gtb_phone);
            this.Controls.Add(this.glbl_phone);
            this.Controls.Add(this.gtb_email);
            this.Controls.Add(this.glbl_email);
            this.Controls.Add(this.gtb_surname);
            this.Controls.Add(this.glbl_surname);
            this.Controls.Add(this.gtb_name);
            this.Controls.Add(this.glbl_name);
            this.Name = "SignupOperator";
            this.Size = new System.Drawing.Size(346, 417);
            this.Load += new System.EventHandler(this.SignupOperator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel glbl_name;
        private Guna.UI.WinForms.GunaCheckBox gchb_showpass;
        private Guna.UI.WinForms.GunaTextBox gtb_confirmPassword;
        private Guna.UI.WinForms.GunaLabel glbl_confirmPassword;
        private Guna.UI.WinForms.GunaLabel glbl_errorMessage;
        private Guna.UI.WinForms.GunaButton gbtn_signup;
        private Guna.UI.WinForms.GunaTextBox gtb_password;
        private Guna.UI.WinForms.GunaLabel glbl_password;
        private Guna.UI.WinForms.GunaTextBox gtb_phone;
        private Guna.UI.WinForms.GunaLabel glbl_phone;
        private Guna.UI.WinForms.GunaTextBox gtb_email;
        private Guna.UI.WinForms.GunaLabel glbl_email;
        private Guna.UI.WinForms.GunaTextBox gtb_surname;
        private Guna.UI.WinForms.GunaLabel glbl_surname;
        private Guna.UI.WinForms.GunaTextBox gtb_name;
    }
}
