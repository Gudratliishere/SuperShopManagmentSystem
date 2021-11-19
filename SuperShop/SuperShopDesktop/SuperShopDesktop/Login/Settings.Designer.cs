namespace SuperShopDesktop
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gbtn_save = new Guna.UI.WinForms.GunaButton();
            this.gchb_show = new Guna.UI.WinForms.GunaCheckBox();
            this.gtb_database = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_database = new Guna.UI.WinForms.GunaLabel();
            this.gtb_pass = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_pass = new Guna.UI.WinForms.GunaLabel();
            this.gtb_user = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_user = new Guna.UI.WinForms.GunaLabel();
            this.gtb_port = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_port = new Guna.UI.WinForms.GunaLabel();
            this.gtb_host = new Guna.UI.WinForms.GunaTextBox();
            this.glbl_host = new Guna.UI.WinForms.GunaLabel();
            this.gbtn_close = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gbtn_save
            // 
            this.gbtn_save.AnimationHoverSpeed = 0.07F;
            this.gbtn_save.AnimationSpeed = 0.03F;
            this.gbtn_save.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_save.BorderColor = System.Drawing.Color.Black;
            this.gbtn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_save.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_save.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gbtn_save.ForeColor = System.Drawing.Color.White;
            this.gbtn_save.Image = null;
            this.gbtn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_save.Location = new System.Drawing.Point(101, 347);
            this.gbtn_save.Name = "gbtn_save";
            this.gbtn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_save.OnHoverImage = null;
            this.gbtn_save.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_save.Radius = 10;
            this.gbtn_save.Size = new System.Drawing.Size(145, 29);
            this.gbtn_save.TabIndex = 25;
            this.gbtn_save.Text = "Save";
            this.gbtn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_save.Click += new System.EventHandler(this.gbtn_save_Click);
            // 
            // gchb_show
            // 
            this.gchb_show.BaseColor = System.Drawing.Color.White;
            this.gchb_show.CheckedOffColor = System.Drawing.Color.Gray;
            this.gchb_show.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gchb_show.FillColor = System.Drawing.Color.White;
            this.gchb_show.Location = new System.Drawing.Point(212, 252);
            this.gchb_show.Name = "gchb_show";
            this.gchb_show.Size = new System.Drawing.Size(58, 20);
            this.gchb_show.TabIndex = 24;
            this.gchb_show.Text = "Show";
            this.gchb_show.CheckedChanged += new System.EventHandler(this.gchb_show_CheckedChanged);
            // 
            // gtb_database
            // 
            this.gtb_database.BackColor = System.Drawing.Color.Transparent;
            this.gtb_database.BaseColor = System.Drawing.Color.White;
            this.gtb_database.BorderColor = System.Drawing.Color.Silver;
            this.gtb_database.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_database.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_database.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_database.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_database.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_database.Location = new System.Drawing.Point(70, 297);
            this.gtb_database.Name = "gtb_database";
            this.gtb_database.PasswordChar = '\0';
            this.gtb_database.Radius = 10;
            this.gtb_database.SelectedText = "";
            this.gtb_database.Size = new System.Drawing.Size(200, 30);
            this.gtb_database.TabIndex = 23;
            // 
            // glbl_database
            // 
            this.glbl_database.AutoSize = true;
            this.glbl_database.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_database.Location = new System.Drawing.Point(140, 273);
            this.glbl_database.Name = "glbl_database";
            this.glbl_database.Size = new System.Drawing.Size(74, 21);
            this.glbl_database.TabIndex = 22;
            this.glbl_database.Text = "Database";
            // 
            // gtb_pass
            // 
            this.gtb_pass.BackColor = System.Drawing.Color.Transparent;
            this.gtb_pass.BaseColor = System.Drawing.Color.White;
            this.gtb_pass.BorderColor = System.Drawing.Color.Silver;
            this.gtb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_pass.Location = new System.Drawing.Point(70, 216);
            this.gtb_pass.Name = "gtb_pass";
            this.gtb_pass.PasswordChar = '●';
            this.gtb_pass.Radius = 10;
            this.gtb_pass.SelectedText = "";
            this.gtb_pass.Size = new System.Drawing.Size(200, 30);
            this.gtb_pass.TabIndex = 21;
            // 
            // glbl_pass
            // 
            this.glbl_pass.AutoSize = true;
            this.glbl_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_pass.Location = new System.Drawing.Point(137, 192);
            this.glbl_pass.Name = "glbl_pass";
            this.glbl_pass.Size = new System.Drawing.Size(77, 21);
            this.glbl_pass.TabIndex = 20;
            this.glbl_pass.Text = "Password";
            // 
            // gtb_user
            // 
            this.gtb_user.BackColor = System.Drawing.Color.Transparent;
            this.gtb_user.BaseColor = System.Drawing.Color.White;
            this.gtb_user.BorderColor = System.Drawing.Color.Silver;
            this.gtb_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_user.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_user.Location = new System.Drawing.Point(70, 159);
            this.gtb_user.Name = "gtb_user";
            this.gtb_user.PasswordChar = '\0';
            this.gtb_user.Radius = 10;
            this.gtb_user.SelectedText = "";
            this.gtb_user.Size = new System.Drawing.Size(200, 30);
            this.gtb_user.TabIndex = 19;
            // 
            // glbl_user
            // 
            this.glbl_user.AutoSize = true;
            this.glbl_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_user.Location = new System.Drawing.Point(153, 135);
            this.glbl_user.Name = "glbl_user";
            this.glbl_user.Size = new System.Drawing.Size(42, 21);
            this.glbl_user.TabIndex = 18;
            this.glbl_user.Text = "User";
            // 
            // gtb_port
            // 
            this.gtb_port.BackColor = System.Drawing.Color.Transparent;
            this.gtb_port.BaseColor = System.Drawing.Color.White;
            this.gtb_port.BorderColor = System.Drawing.Color.Silver;
            this.gtb_port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_port.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_port.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_port.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_port.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_port.Location = new System.Drawing.Point(70, 102);
            this.gtb_port.Name = "gtb_port";
            this.gtb_port.PasswordChar = '\0';
            this.gtb_port.Radius = 10;
            this.gtb_port.SelectedText = "";
            this.gtb_port.Size = new System.Drawing.Size(200, 30);
            this.gtb_port.TabIndex = 17;
            // 
            // glbl_port
            // 
            this.glbl_port.AutoSize = true;
            this.glbl_port.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_port.Location = new System.Drawing.Point(153, 78);
            this.glbl_port.Name = "glbl_port";
            this.glbl_port.Size = new System.Drawing.Size(39, 21);
            this.glbl_port.TabIndex = 16;
            this.glbl_port.Text = "Port";
            // 
            // gtb_host
            // 
            this.gtb_host.BackColor = System.Drawing.Color.Transparent;
            this.gtb_host.BaseColor = System.Drawing.Color.White;
            this.gtb_host.BorderColor = System.Drawing.Color.Silver;
            this.gtb_host.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_host.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_host.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_host.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_host.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_host.Location = new System.Drawing.Point(70, 45);
            this.gtb_host.Name = "gtb_host";
            this.gtb_host.PasswordChar = '\0';
            this.gtb_host.Radius = 10;
            this.gtb_host.SelectedText = "";
            this.gtb_host.Size = new System.Drawing.Size(200, 30);
            this.gtb_host.TabIndex = 15;
            // 
            // glbl_host
            // 
            this.glbl_host.AutoSize = true;
            this.glbl_host.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.glbl_host.Location = new System.Drawing.Point(153, 21);
            this.glbl_host.Name = "glbl_host";
            this.glbl_host.Size = new System.Drawing.Size(42, 21);
            this.glbl_host.TabIndex = 14;
            this.glbl_host.Text = "Host";
            // 
            // gbtn_close
            // 
            this.gbtn_close.AnimationHoverSpeed = 0.07F;
            this.gbtn_close.AnimationSpeed = 0.03F;
            this.gbtn_close.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_close.BorderColor = System.Drawing.Color.Black;
            this.gbtn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_close.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_close.ForeColor = System.Drawing.Color.White;
            this.gbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_close.Image")));
            this.gbtn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_close.Location = new System.Drawing.Point(313, 2);
            this.gbtn_close.Name = "gbtn_close";
            this.gbtn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_close.OnHoverImage = null;
            this.gbtn_close.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_close.Radius = 10;
            this.gbtn_close.Size = new System.Drawing.Size(24, 25);
            this.gbtn_close.TabIndex = 26;
            this.gbtn_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_close.Click += new System.EventHandler(this.gbtn_close_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 414);
            this.Controls.Add(this.gbtn_close);
            this.Controls.Add(this.gbtn_save);
            this.Controls.Add(this.gchb_show);
            this.Controls.Add(this.gtb_database);
            this.Controls.Add(this.glbl_database);
            this.Controls.Add(this.gtb_pass);
            this.Controls.Add(this.glbl_pass);
            this.Controls.Add(this.gtb_user);
            this.Controls.Add(this.glbl_user);
            this.Controls.Add(this.gtb_port);
            this.Controls.Add(this.glbl_port);
            this.Controls.Add(this.gtb_host);
            this.Controls.Add(this.glbl_host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gbtn_save;
        private Guna.UI.WinForms.GunaCheckBox gchb_show;
        private Guna.UI.WinForms.GunaTextBox gtb_database;
        private Guna.UI.WinForms.GunaLabel glbl_database;
        private Guna.UI.WinForms.GunaTextBox gtb_pass;
        private Guna.UI.WinForms.GunaLabel glbl_pass;
        private Guna.UI.WinForms.GunaTextBox gtb_user;
        private Guna.UI.WinForms.GunaLabel glbl_user;
        private Guna.UI.WinForms.GunaTextBox gtb_port;
        private Guna.UI.WinForms.GunaLabel glbl_port;
        private Guna.UI.WinForms.GunaTextBox gtb_host;
        private Guna.UI.WinForms.GunaLabel glbl_host;
        private Guna.UI.WinForms.GunaButton gbtn_close;
    }
}