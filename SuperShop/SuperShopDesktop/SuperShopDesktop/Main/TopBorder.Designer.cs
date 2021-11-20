namespace SuperShopDesktop.Main
{
    partial class TopBorder
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
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_appName = new System.Windows.Forms.Label();
            this.flp_control = new System.Windows.Forms.FlowLayoutPanel();
            this.gbtn_minimize = new Guna.UI.WinForms.GunaButton();
            this.gbtn_maximize = new Guna.UI.WinForms.GunaButton();
            this.gbtn_close = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnl_top.SuspendLayout();
            this.flp_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_top.Controls.Add(this.lbl_appName);
            this.pnl_top.Controls.Add(this.flp_control);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 30);
            this.pnl_top.TabIndex = 1;
            // 
            // lbl_appName
            // 
            this.lbl_appName.AutoSize = true;
            this.lbl_appName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_appName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_appName.Location = new System.Drawing.Point(12, 3);
            this.lbl_appName.Name = "lbl_appName";
            this.lbl_appName.Size = new System.Drawing.Size(112, 21);
            this.lbl_appName.TabIndex = 1;
            this.lbl_appName.Text = "Shop Manager";
            // 
            // flp_control
            // 
            this.flp_control.Controls.Add(this.gbtn_minimize);
            this.flp_control.Controls.Add(this.gbtn_maximize);
            this.flp_control.Controls.Add(this.gbtn_close);
            this.flp_control.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp_control.Location = new System.Drawing.Point(706, 0);
            this.flp_control.Name = "flp_control";
            this.flp_control.Size = new System.Drawing.Size(94, 30);
            this.flp_control.TabIndex = 0;
            // 
            // gbtn_minimize
            // 
            this.gbtn_minimize.AnimationHoverSpeed = 0.07F;
            this.gbtn_minimize.AnimationSpeed = 0.03F;
            this.gbtn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_minimize.BaseColor = System.Drawing.Color.Transparent;
            this.gbtn_minimize.BorderColor = System.Drawing.Color.Black;
            this.gbtn_minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_minimize.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_minimize.ForeColor = System.Drawing.Color.White;
            this.gbtn_minimize.Image = global::SuperShopDesktop.Properties.Resources.minimize;
            this.gbtn_minimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_minimize.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_minimize.Location = new System.Drawing.Point(3, 3);
            this.gbtn_minimize.Name = "gbtn_minimize";
            this.gbtn_minimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(237)))));
            this.gbtn_minimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_minimize.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_minimize.OnHoverImage = null;
            this.gbtn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_minimize.Radius = 5;
            this.gbtn_minimize.Size = new System.Drawing.Size(25, 25);
            this.gbtn_minimize.TabIndex = 0;
            this.gbtn_minimize.Click += new System.EventHandler(this.gbtn_minimize_Click);
            // 
            // gbtn_maximize
            // 
            this.gbtn_maximize.AnimationHoverSpeed = 0.07F;
            this.gbtn_maximize.AnimationSpeed = 0.03F;
            this.gbtn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_maximize.BaseColor = System.Drawing.Color.Transparent;
            this.gbtn_maximize.BorderColor = System.Drawing.Color.Black;
            this.gbtn_maximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_maximize.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_maximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_maximize.ForeColor = System.Drawing.Color.White;
            this.gbtn_maximize.Image = global::SuperShopDesktop.Properties.Resources.maximize;
            this.gbtn_maximize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_maximize.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_maximize.Location = new System.Drawing.Point(34, 3);
            this.gbtn_maximize.Name = "gbtn_maximize";
            this.gbtn_maximize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(237)))));
            this.gbtn_maximize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_maximize.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_maximize.OnHoverImage = null;
            this.gbtn_maximize.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_maximize.Radius = 5;
            this.gbtn_maximize.Size = new System.Drawing.Size(25, 25);
            this.gbtn_maximize.TabIndex = 1;
            this.gbtn_maximize.Click += new System.EventHandler(this.gbtn_maximize_Click);
            // 
            // gbtn_close
            // 
            this.gbtn_close.AnimationHoverSpeed = 0.07F;
            this.gbtn_close.AnimationSpeed = 0.03F;
            this.gbtn_close.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_close.BaseColor = System.Drawing.Color.Transparent;
            this.gbtn_close.BorderColor = System.Drawing.Color.Black;
            this.gbtn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_close.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_close.ForeColor = System.Drawing.Color.White;
            this.gbtn_close.Image = global::SuperShopDesktop.Properties.Resources.close;
            this.gbtn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_close.Location = new System.Drawing.Point(65, 3);
            this.gbtn_close.Name = "gbtn_close";
            this.gbtn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(237)))));
            this.gbtn_close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_close.OnHoverImage = null;
            this.gbtn_close.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_close.Radius = 5;
            this.gbtn_close.Size = new System.Drawing.Size(25, 25);
            this.gbtn_close.TabIndex = 2;
            this.gbtn_close.Click += new System.EventHandler(this.gbtn_close_Click);
            // 
            // gunaDragControl
            // 
            this.gunaDragControl.TargetControl = this.pnl_top;
            // 
            // TopBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_top);
            this.Name = "TopBorder";
            this.Size = new System.Drawing.Size(800, 30);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.flp_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_appName;
        private System.Windows.Forms.FlowLayoutPanel flp_control;
        private Guna.UI.WinForms.GunaButton gbtn_minimize;
        private Guna.UI.WinForms.GunaButton gbtn_maximize;
        private Guna.UI.WinForms.GunaButton gbtn_close;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl;
    }
}
