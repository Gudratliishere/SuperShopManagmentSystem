namespace SuperShopDesktop.Main.Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.flp_main = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_language = new System.Windows.Forms.Panel();
            this.gcb_language = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.flp_main.SuspendLayout();
            this.pnl_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_main
            // 
            this.flp_main.AutoScroll = true;
            this.flp_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.flp_main.Controls.Add(this.pnl_language);
            this.flp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_main.Location = new System.Drawing.Point(0, 0);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(690, 448);
            this.flp_main.TabIndex = 4;
            // 
            // pnl_language
            // 
            this.pnl_language.Controls.Add(this.gcb_language);
            this.pnl_language.Controls.Add(this.lbl_language);
            this.pnl_language.Location = new System.Drawing.Point(3, 3);
            this.pnl_language.Name = "pnl_language";
            this.pnl_language.Size = new System.Drawing.Size(320, 90);
            this.pnl_language.TabIndex = 0;
            // 
            // gcb_language
            // 
            this.gcb_language.BackColor = System.Drawing.Color.Transparent;
            this.gcb_language.BaseColor = System.Drawing.Color.White;
            this.gcb_language.BorderColor = System.Drawing.Color.Silver;
            this.gcb_language.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_language.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gcb_language.ForeColor = System.Drawing.Color.Black;
            this.gcb_language.FormattingEnabled = true;
            this.gcb_language.Location = new System.Drawing.Point(48, 41);
            this.gcb_language.Name = "gcb_language";
            this.gcb_language.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_language.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_language.Radius = 10;
            this.gcb_language.Size = new System.Drawing.Size(228, 30);
            this.gcb_language.TabIndex = 1;
            this.gcb_language.SelectedIndexChanged += new System.EventHandler(this.gcb_language_SelectedIndexChanged);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_language.Location = new System.Drawing.Point(44, 17);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(78, 21);
            this.lbl_language.TabIndex = 0;
            this.lbl_language.Text = "Language";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_main);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(690, 448);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flp_main.ResumeLayout(false);
            this.pnl_language.ResumeLayout(false);
            this.pnl_language.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_language;
        private Guna.UI.WinForms.GunaComboBox gcb_language;
        private System.Windows.Forms.Label lbl_language;
    }
}
