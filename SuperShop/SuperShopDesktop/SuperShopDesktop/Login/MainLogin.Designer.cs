namespace SuperShopDesktop
{
    partial class MainLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.pnl_background = new System.Windows.Forms.Panel();
            this.gbtn_setting = new Guna.UI.WinForms.GunaButton();
            this.gbtn_exit = new Guna.UI.WinForms.GunaButton();
            this.gbtn_operator = new Guna.UI.WinForms.GunaButton();
            this.gbtn_admin = new Guna.UI.WinForms.GunaButton();
            this.gbtn_signup = new Guna.UI.WinForms.GunaButton();
            this.gbtn_signin = new Guna.UI.WinForms.GunaButton();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_background.BackgroundImage")));
            this.pnl_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_background.Controls.Add(this.gbtn_setting);
            this.pnl_background.Controls.Add(this.gbtn_exit);
            this.pnl_background.Controls.Add(this.gbtn_operator);
            this.pnl_background.Controls.Add(this.gbtn_admin);
            this.pnl_background.Controls.Add(this.gbtn_signup);
            this.pnl_background.Controls.Add(this.gbtn_signin);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(398, 417);
            this.pnl_background.TabIndex = 0;
            // 
            // gbtn_setting
            // 
            this.gbtn_setting.AnimationHoverSpeed = 0.07F;
            this.gbtn_setting.AnimationSpeed = 0.03F;
            this.gbtn_setting.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_setting.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_setting.BorderColor = System.Drawing.Color.Black;
            this.gbtn_setting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_setting.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_setting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_setting.ForeColor = System.Drawing.Color.White;
            this.gbtn_setting.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_setting.Image")));
            this.gbtn_setting.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_setting.Location = new System.Drawing.Point(12, 370);
            this.gbtn_setting.Name = "gbtn_setting";
            this.gbtn_setting.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_setting.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_setting.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_setting.OnHoverImage = null;
            this.gbtn_setting.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_setting.Radius = 10;
            this.gbtn_setting.Size = new System.Drawing.Size(35, 35);
            this.gbtn_setting.TabIndex = 5;
            this.gbtn_setting.Text = "Settings";
            this.gbtn_setting.Click += new System.EventHandler(this.gbtn_setting_Click);
            this.gbtn_setting.MouseEnter += new System.EventHandler(this.gbtn_setting_MouseEnter);
            this.gbtn_setting.MouseLeave += new System.EventHandler(this.gbtn_setting_MouseLeave);
            // 
            // gbtn_exit
            // 
            this.gbtn_exit.AnimationHoverSpeed = 0.07F;
            this.gbtn_exit.AnimationSpeed = 0.03F;
            this.gbtn_exit.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_exit.BorderColor = System.Drawing.Color.Black;
            this.gbtn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_exit.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_exit.ForeColor = System.Drawing.Color.White;
            this.gbtn_exit.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_exit.Image")));
            this.gbtn_exit.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_exit.Location = new System.Drawing.Point(12, 225);
            this.gbtn_exit.Name = "gbtn_exit";
            this.gbtn_exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_exit.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_exit.OnHoverImage = null;
            this.gbtn_exit.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_exit.Radius = 10;
            this.gbtn_exit.Size = new System.Drawing.Size(35, 35);
            this.gbtn_exit.TabIndex = 4;
            this.gbtn_exit.Text = "Exit";
            this.gbtn_exit.Click += new System.EventHandler(this.gbtn_exit_Click);
            this.gbtn_exit.MouseEnter += new System.EventHandler(this.gbtn_exit_MouseEnter);
            this.gbtn_exit.MouseLeave += new System.EventHandler(this.gbtn_exit_MouseLeave);
            // 
            // gbtn_operator
            // 
            this.gbtn_operator.AnimationHoverSpeed = 0.07F;
            this.gbtn_operator.AnimationSpeed = 0.03F;
            this.gbtn_operator.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_operator.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_operator.BorderColor = System.Drawing.Color.Black;
            this.gbtn_operator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_operator.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_operator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_operator.ForeColor = System.Drawing.Color.White;
            this.gbtn_operator.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_operator.Image")));
            this.gbtn_operator.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_operator.Location = new System.Drawing.Point(12, 184);
            this.gbtn_operator.Name = "gbtn_operator";
            this.gbtn_operator.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_operator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_operator.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_operator.OnHoverImage = null;
            this.gbtn_operator.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_operator.Radius = 10;
            this.gbtn_operator.Size = new System.Drawing.Size(35, 35);
            this.gbtn_operator.TabIndex = 3;
            this.gbtn_operator.Tag = "operator";
            this.gbtn_operator.Text = "Operator";
            this.gbtn_operator.Click += new System.EventHandler(this.gbtn_operator_Click);
            this.gbtn_operator.MouseEnter += new System.EventHandler(this.gbtn_operator_MouseEnter);
            this.gbtn_operator.MouseLeave += new System.EventHandler(this.gbtn_operator_MouseLeave);
            // 
            // gbtn_admin
            // 
            this.gbtn_admin.AnimationHoverSpeed = 0.07F;
            this.gbtn_admin.AnimationSpeed = 1F;
            this.gbtn_admin.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_admin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_admin.BorderColor = System.Drawing.Color.Black;
            this.gbtn_admin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_admin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_admin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_admin.ForeColor = System.Drawing.Color.White;
            this.gbtn_admin.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_admin.Image")));
            this.gbtn_admin.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_admin.Location = new System.Drawing.Point(12, 143);
            this.gbtn_admin.Name = "gbtn_admin";
            this.gbtn_admin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_admin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_admin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_admin.OnHoverImage = null;
            this.gbtn_admin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_admin.Radius = 10;
            this.gbtn_admin.Size = new System.Drawing.Size(35, 35);
            this.gbtn_admin.TabIndex = 2;
            this.gbtn_admin.Tag = "admin";
            this.gbtn_admin.Text = "Admin";
            this.gbtn_admin.Click += new System.EventHandler(this.gbtn_admin_Click);
            this.gbtn_admin.MouseEnter += new System.EventHandler(this.gbtn_admin_MouseEnter);
            this.gbtn_admin.MouseLeave += new System.EventHandler(this.gbtn_admin_MouseLeave);
            // 
            // gbtn_signup
            // 
            this.gbtn_signup.AnimationHoverSpeed = 0.07F;
            this.gbtn_signup.AnimationSpeed = 0.03F;
            this.gbtn_signup.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_signup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_signup.BorderColor = System.Drawing.Color.Black;
            this.gbtn_signup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_signup.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_signup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_signup.ForeColor = System.Drawing.Color.White;
            this.gbtn_signup.Image = null;
            this.gbtn_signup.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_signup.Location = new System.Drawing.Point(193, 12);
            this.gbtn_signup.Name = "gbtn_signup";
            this.gbtn_signup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_signup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_signup.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_signup.OnHoverImage = null;
            this.gbtn_signup.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_signup.Radius = 10;
            this.gbtn_signup.Size = new System.Drawing.Size(119, 28);
            this.gbtn_signup.TabIndex = 1;
            this.gbtn_signup.Tag = "signup";
            this.gbtn_signup.Text = "Sign up";
            this.gbtn_signup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_signup.Click += new System.EventHandler(this.gbtn_signup_Click);
            // 
            // gbtn_signin
            // 
            this.gbtn_signin.AnimationHoverSpeed = 0.07F;
            this.gbtn_signin.AnimationSpeed = 0.03F;
            this.gbtn_signin.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_signin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.gbtn_signin.BorderColor = System.Drawing.Color.Black;
            this.gbtn_signin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_signin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_signin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_signin.ForeColor = System.Drawing.Color.White;
            this.gbtn_signin.Image = null;
            this.gbtn_signin.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_signin.Location = new System.Drawing.Point(68, 12);
            this.gbtn_signin.Name = "gbtn_signin";
            this.gbtn_signin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_signin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_signin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_signin.OnHoverImage = null;
            this.gbtn_signin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_signin.Radius = 10;
            this.gbtn_signin.Size = new System.Drawing.Size(119, 28);
            this.gbtn_signin.TabIndex = 0;
            this.gbtn_signin.Tag = "signin";
            this.gbtn_signin.Text = "Sign in";
            this.gbtn_signin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_signin.Click += new System.EventHandler(this.gbtn_signin_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_main.Location = new System.Drawing.Point(404, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(346, 417);
            this.pnl_main.TabIndex = 1;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 417);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop managment";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_background;
        private Guna.UI.WinForms.GunaButton gbtn_exit;
        private Guna.UI.WinForms.GunaButton gbtn_operator;
        private Guna.UI.WinForms.GunaButton gbtn_admin;
        private Guna.UI.WinForms.GunaButton gbtn_signup;
        private Guna.UI.WinForms.GunaButton gbtn_signin;
        private System.Windows.Forms.Panel pnl_main;
        private Guna.UI.WinForms.GunaButton gbtn_setting;
    }
}