namespace SuperShopDesktop.Main
{
    partial class MainAdmin
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
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.gresize = new Guna.UI.WinForms.GunaResize(this.components);
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_windows = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.gbtn_products = new Guna.UI.WinForms.GunaButton();
            this.gbtn_workers = new Guna.UI.WinForms.GunaButton();
            this.gbtn_cashiers = new Guna.UI.WinForms.GunaButton();
            this.gbtn_settings = new Guna.UI.WinForms.GunaButton();
            this.gbtn_add = new Guna.UI.WinForms.GunaButton();
            this.pnl_body.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.flp_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 30);
            this.pnl_top.TabIndex = 0;
            // 
            // gresize
            // 
            this.gresize.TargetForm = this;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_body.Controls.Add(this.pnl_windows);
            this.pnl_body.Controls.Add(this.pnl_menu);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 30);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(800, 420);
            this.pnl_body.TabIndex = 1;
            // 
            // pnl_windows
            // 
            this.pnl_windows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_windows.Location = new System.Drawing.Point(0, 43);
            this.pnl_windows.Name = "pnl_windows";
            this.pnl_windows.Size = new System.Drawing.Size(800, 377);
            this.pnl_windows.TabIndex = 3;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.gbtn_add);
            this.pnl_menu.Controls.Add(this.flp_menu);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(800, 43);
            this.pnl_menu.TabIndex = 2;
            // 
            // flp_menu
            // 
            this.flp_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.flp_menu.Controls.Add(this.gbtn_products);
            this.flp_menu.Controls.Add(this.gbtn_workers);
            this.flp_menu.Controls.Add(this.gbtn_cashiers);
            this.flp_menu.Controls.Add(this.gbtn_settings);
            this.flp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_menu.Location = new System.Drawing.Point(0, 0);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Size = new System.Drawing.Size(800, 43);
            this.flp_menu.TabIndex = 0;
            // 
            // gbtn_products
            // 
            this.gbtn_products.AnimationHoverSpeed = 0.07F;
            this.gbtn_products.AnimationSpeed = 0.03F;
            this.gbtn_products.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_products.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.gbtn_products.BorderColor = System.Drawing.Color.Black;
            this.gbtn_products.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_products.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_products.ForeColor = System.Drawing.Color.White;
            this.gbtn_products.Image = null;
            this.gbtn_products.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_products.Location = new System.Drawing.Point(3, 3);
            this.gbtn_products.Name = "gbtn_products";
            this.gbtn_products.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_products.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_products.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_products.OnHoverImage = null;
            this.gbtn_products.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_products.Radius = 10;
            this.gbtn_products.Size = new System.Drawing.Size(100, 36);
            this.gbtn_products.TabIndex = 0;
            this.gbtn_products.Text = "Products";
            this.gbtn_products.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_products.Click += new System.EventHandler(this.gbtn_products_Click);
            // 
            // gbtn_workers
            // 
            this.gbtn_workers.AnimationHoverSpeed = 0.07F;
            this.gbtn_workers.AnimationSpeed = 0.03F;
            this.gbtn_workers.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_workers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.gbtn_workers.BorderColor = System.Drawing.Color.Black;
            this.gbtn_workers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_workers.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_workers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_workers.ForeColor = System.Drawing.Color.White;
            this.gbtn_workers.Image = null;
            this.gbtn_workers.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_workers.Location = new System.Drawing.Point(109, 3);
            this.gbtn_workers.Name = "gbtn_workers";
            this.gbtn_workers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_workers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_workers.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_workers.OnHoverImage = null;
            this.gbtn_workers.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_workers.Radius = 10;
            this.gbtn_workers.Size = new System.Drawing.Size(100, 36);
            this.gbtn_workers.TabIndex = 1;
            this.gbtn_workers.Text = "Workers";
            this.gbtn_workers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_workers.Click += new System.EventHandler(this.gbtn_personals_Click);
            // 
            // gbtn_cashiers
            // 
            this.gbtn_cashiers.AnimationHoverSpeed = 0.07F;
            this.gbtn_cashiers.AnimationSpeed = 0.03F;
            this.gbtn_cashiers.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_cashiers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.gbtn_cashiers.BorderColor = System.Drawing.Color.Black;
            this.gbtn_cashiers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_cashiers.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_cashiers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_cashiers.ForeColor = System.Drawing.Color.White;
            this.gbtn_cashiers.Image = null;
            this.gbtn_cashiers.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_cashiers.Location = new System.Drawing.Point(215, 3);
            this.gbtn_cashiers.Name = "gbtn_cashiers";
            this.gbtn_cashiers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_cashiers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_cashiers.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_cashiers.OnHoverImage = null;
            this.gbtn_cashiers.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_cashiers.Radius = 10;
            this.gbtn_cashiers.Size = new System.Drawing.Size(100, 36);
            this.gbtn_cashiers.TabIndex = 2;
            this.gbtn_cashiers.Text = "Cashiers";
            this.gbtn_cashiers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_cashiers.Click += new System.EventHandler(this.gbtn_cashiers_Click);
            // 
            // gbtn_settings
            // 
            this.gbtn_settings.AnimationHoverSpeed = 0.07F;
            this.gbtn_settings.AnimationSpeed = 0.03F;
            this.gbtn_settings.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.gbtn_settings.BorderColor = System.Drawing.Color.Black;
            this.gbtn_settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_settings.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_settings.ForeColor = System.Drawing.Color.White;
            this.gbtn_settings.Image = null;
            this.gbtn_settings.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_settings.Location = new System.Drawing.Point(321, 3);
            this.gbtn_settings.Name = "gbtn_settings";
            this.gbtn_settings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_settings.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_settings.OnHoverImage = null;
            this.gbtn_settings.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_settings.Radius = 10;
            this.gbtn_settings.Size = new System.Drawing.Size(100, 36);
            this.gbtn_settings.TabIndex = 3;
            this.gbtn_settings.Text = "Settings";
            this.gbtn_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbtn_add
            // 
            this.gbtn_add.AnimationHoverSpeed = 0.07F;
            this.gbtn_add.AnimationSpeed = 0.03F;
            this.gbtn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.gbtn_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.gbtn_add.BorderColor = System.Drawing.Color.Black;
            this.gbtn_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbtn_add.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.gbtn_add.Image = global::SuperShopDesktop.Properties.Resources.add;
            this.gbtn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_add.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_add.Location = new System.Drawing.Point(755, 0);
            this.gbtn_add.Name = "gbtn_add";
            this.gbtn_add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_add.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_add.OnHoverImage = null;
            this.gbtn_add.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_add.Size = new System.Drawing.Size(45, 43);
            this.gbtn_add.TabIndex = 1;
            this.gbtn_add.Click += new System.EventHandler(this.gbtn_add_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(220, 40);
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Manager";
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.pnl_body.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.flp_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private Guna.UI.WinForms.GunaResize gresize;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
        private System.Windows.Forms.Panel pnl_menu;
        private Guna.UI.WinForms.GunaButton gbtn_add;
        public System.Windows.Forms.Panel pnl_windows;
        public Guna.UI.WinForms.GunaButton gbtn_products;
        public Guna.UI.WinForms.GunaButton gbtn_workers;
        public Guna.UI.WinForms.GunaButton gbtn_cashiers;
        public Guna.UI.WinForms.GunaButton gbtn_settings;
    }
}