namespace SuperShopDesktop.Main.Menu.Cashier
{
    partial class CashierEdit
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
            this.flp_main = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_sales = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.gtb_name = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.gbtn_save = new Guna.UI.WinForms.GunaButton();
            this.pnl_worker = new System.Windows.Forms.Panel();
            this.lbl_worker = new System.Windows.Forms.Label();
            this.gcb_worker = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_reset = new System.Windows.Forms.Panel();
            this.gbtn_reset = new Guna.UI.WinForms.GunaButton();
            this.pnl_remove = new System.Windows.Forms.Panel();
            this.gbtn_remove = new Guna.UI.WinForms.GunaButton();
            this.flp_main.SuspendLayout();
            this.pnl_sales.SuspendLayout();
            this.pnl_save.SuspendLayout();
            this.pnl_worker.SuspendLayout();
            this.pnl_reset.SuspendLayout();
            this.pnl_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_main
            // 
            this.flp_main.AutoScroll = true;
            this.flp_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.flp_main.Controls.Add(this.pnl_sales);
            this.flp_main.Controls.Add(this.pnl_worker);
            this.flp_main.Controls.Add(this.pnl_save);
            this.flp_main.Controls.Add(this.pnl_reset);
            this.flp_main.Controls.Add(this.pnl_remove);
            this.flp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_main.Location = new System.Drawing.Point(0, 0);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(685, 438);
            this.flp_main.TabIndex = 6;
            // 
            // pnl_sales
            // 
            this.pnl_sales.Controls.Add(this.lbl_name);
            this.pnl_sales.Controls.Add(this.gtb_name);
            this.pnl_sales.Location = new System.Drawing.Point(3, 3);
            this.pnl_sales.Name = "pnl_sales";
            this.pnl_sales.Size = new System.Drawing.Size(320, 94);
            this.pnl_sales.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(44, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
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
            this.gtb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_name.Location = new System.Drawing.Point(48, 41);
            this.gtb_name.Name = "gtb_name";
            this.gtb_name.PasswordChar = '\0';
            this.gtb_name.Radius = 10;
            this.gtb_name.SelectedText = "";
            this.gtb_name.Size = new System.Drawing.Size(241, 32);
            this.gtb_name.TabIndex = 1;
            // 
            // pnl_save
            // 
            this.pnl_save.Controls.Add(this.gbtn_save);
            this.pnl_save.Location = new System.Drawing.Point(3, 103);
            this.pnl_save.Name = "pnl_save";
            this.pnl_save.Size = new System.Drawing.Size(320, 94);
            this.pnl_save.TabIndex = 7;
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
            this.gbtn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_save.ForeColor = System.Drawing.Color.White;
            this.gbtn_save.Image = null;
            this.gbtn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_save.Location = new System.Drawing.Point(49, 37);
            this.gbtn_save.Name = "gbtn_save";
            this.gbtn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_save.OnHoverImage = null;
            this.gbtn_save.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_save.Radius = 10;
            this.gbtn_save.Size = new System.Drawing.Size(151, 32);
            this.gbtn_save.TabIndex = 0;
            this.gbtn_save.Text = "Save";
            this.gbtn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_save.Click += new System.EventHandler(this.gbtn_save_Click);
            // 
            // pnl_worker
            // 
            this.pnl_worker.Controls.Add(this.gcb_worker);
            this.pnl_worker.Controls.Add(this.lbl_worker);
            this.pnl_worker.Location = new System.Drawing.Point(329, 3);
            this.pnl_worker.Name = "pnl_worker";
            this.pnl_worker.Size = new System.Drawing.Size(320, 94);
            this.pnl_worker.TabIndex = 8;
            // 
            // lbl_worker
            // 
            this.lbl_worker.AutoSize = true;
            this.lbl_worker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_worker.Location = new System.Drawing.Point(44, 17);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(62, 21);
            this.lbl_worker.TabIndex = 0;
            this.lbl_worker.Text = "Worker";
            // 
            // gcb_worker
            // 
            this.gcb_worker.BackColor = System.Drawing.Color.Transparent;
            this.gcb_worker.BaseColor = System.Drawing.Color.White;
            this.gcb_worker.BorderColor = System.Drawing.Color.Silver;
            this.gcb_worker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_worker.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_worker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gcb_worker.ForeColor = System.Drawing.Color.Black;
            this.gcb_worker.FormattingEnabled = true;
            this.gcb_worker.Location = new System.Drawing.Point(48, 41);
            this.gcb_worker.Name = "gcb_worker";
            this.gcb_worker.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_worker.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_worker.Radius = 10;
            this.gcb_worker.Size = new System.Drawing.Size(228, 30);
            this.gcb_worker.TabIndex = 1;
            // 
            // pnl_reset
            // 
            this.pnl_reset.Controls.Add(this.gbtn_reset);
            this.pnl_reset.Location = new System.Drawing.Point(329, 103);
            this.pnl_reset.Name = "pnl_reset";
            this.pnl_reset.Size = new System.Drawing.Size(321, 94);
            this.pnl_reset.TabIndex = 9;
            // 
            // gbtn_reset
            // 
            this.gbtn_reset.AnimationHoverSpeed = 0.07F;
            this.gbtn_reset.AnimationSpeed = 0.03F;
            this.gbtn_reset.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_reset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_reset.BorderColor = System.Drawing.Color.Black;
            this.gbtn_reset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_reset.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_reset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_reset.ForeColor = System.Drawing.Color.White;
            this.gbtn_reset.Image = null;
            this.gbtn_reset.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_reset.Location = new System.Drawing.Point(49, 37);
            this.gbtn_reset.Name = "gbtn_reset";
            this.gbtn_reset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_reset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_reset.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_reset.OnHoverImage = null;
            this.gbtn_reset.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_reset.Radius = 10;
            this.gbtn_reset.Size = new System.Drawing.Size(151, 32);
            this.gbtn_reset.TabIndex = 0;
            this.gbtn_reset.Text = "Reset";
            this.gbtn_reset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_reset.Click += new System.EventHandler(this.gbtn_reset_Click);
            // 
            // pnl_remove
            // 
            this.pnl_remove.Controls.Add(this.gbtn_remove);
            this.pnl_remove.Location = new System.Drawing.Point(3, 203);
            this.pnl_remove.Name = "pnl_remove";
            this.pnl_remove.Size = new System.Drawing.Size(321, 94);
            this.pnl_remove.TabIndex = 10;
            // 
            // gbtn_remove
            // 
            this.gbtn_remove.AnimationHoverSpeed = 0.07F;
            this.gbtn_remove.AnimationSpeed = 0.03F;
            this.gbtn_remove.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_remove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_remove.BorderColor = System.Drawing.Color.Black;
            this.gbtn_remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_remove.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_remove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_remove.ForeColor = System.Drawing.Color.White;
            this.gbtn_remove.Image = null;
            this.gbtn_remove.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_remove.Location = new System.Drawing.Point(49, 37);
            this.gbtn_remove.Name = "gbtn_remove";
            this.gbtn_remove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_remove.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_remove.OnHoverImage = null;
            this.gbtn_remove.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_remove.Radius = 10;
            this.gbtn_remove.Size = new System.Drawing.Size(151, 32);
            this.gbtn_remove.TabIndex = 0;
            this.gbtn_remove.Text = "Remove";
            this.gbtn_remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_remove.Click += new System.EventHandler(this.gbtn_remove_Click);
            // 
            // CashierEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.flp_main);
            this.Name = "CashierEdit";
            this.Size = new System.Drawing.Size(685, 438);
            this.Load += new System.EventHandler(this.CashierEdit_Load);
            this.flp_main.ResumeLayout(false);
            this.pnl_sales.ResumeLayout(false);
            this.pnl_sales.PerformLayout();
            this.pnl_save.ResumeLayout(false);
            this.pnl_worker.ResumeLayout(false);
            this.pnl_worker.PerformLayout();
            this.pnl_reset.ResumeLayout(false);
            this.pnl_remove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_sales;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI.WinForms.GunaTextBox gtb_name;
        private System.Windows.Forms.Panel pnl_worker;
        private System.Windows.Forms.Label lbl_worker;
        private System.Windows.Forms.Panel pnl_save;
        private Guna.UI.WinForms.GunaButton gbtn_save;
        private Guna.UI.WinForms.GunaComboBox gcb_worker;
        private System.Windows.Forms.Panel pnl_reset;
        private Guna.UI.WinForms.GunaButton gbtn_reset;
        private System.Windows.Forms.Panel pnl_remove;
        private Guna.UI.WinForms.GunaButton gbtn_remove;
    }
}
