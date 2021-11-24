namespace SuperShopDesktop.Main.Menu.Worker
{
    partial class WorkSectorEdit
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
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.gtb_name = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.gbtn_save = new Guna.UI.WinForms.GunaButton();
            this.flp_main.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_main
            // 
            this.flp_main.AutoScroll = true;
            this.flp_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.flp_main.Controls.Add(this.pnl_name);
            this.flp_main.Controls.Add(this.pnl_save);
            this.flp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_main.Location = new System.Drawing.Point(0, 0);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(787, 461);
            this.flp_main.TabIndex = 5;
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.lbl_name);
            this.pnl_name.Controls.Add(this.gtb_name);
            this.pnl_name.Location = new System.Drawing.Point(3, 3);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(320, 90);
            this.pnl_name.TabIndex = 0;
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
            this.pnl_save.Location = new System.Drawing.Point(329, 3);
            this.pnl_save.Name = "pnl_save";
            this.pnl_save.Size = new System.Drawing.Size(319, 94);
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
            // WorkSectorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_main);
            this.Name = "WorkSectorEdit";
            this.Size = new System.Drawing.Size(787, 461);
            this.Load += new System.EventHandler(this.WorkSectorEdit_Load);
            this.flp_main.ResumeLayout(false);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI.WinForms.GunaTextBox gtb_name;
        private System.Windows.Forms.Panel pnl_save;
        private Guna.UI.WinForms.GunaButton gbtn_save;
    }
}
