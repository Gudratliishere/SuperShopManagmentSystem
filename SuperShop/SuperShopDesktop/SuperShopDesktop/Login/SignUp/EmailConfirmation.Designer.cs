namespace SuperShopDesktop.Login.SignUp
{
    partial class EmailConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailConfirmation));
            this.gbtn_ok = new Guna.UI.WinForms.GunaButton();
            this.gtb_code = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // gbtn_ok
            // 
            this.gbtn_ok.AnimationHoverSpeed = 0.07F;
            this.gbtn_ok.AnimationSpeed = 0.03F;
            this.gbtn_ok.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_ok.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_ok.BorderColor = System.Drawing.Color.Black;
            this.gbtn_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_ok.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_ok.ForeColor = System.Drawing.Color.White;
            this.gbtn_ok.Image = null;
            this.gbtn_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_ok.Location = new System.Drawing.Point(47, 108);
            this.gbtn_ok.Name = "gbtn_ok";
            this.gbtn_ok.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_ok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_ok.OnHoverImage = null;
            this.gbtn_ok.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_ok.Radius = 10;
            this.gbtn_ok.Size = new System.Drawing.Size(160, 42);
            this.gbtn_ok.TabIndex = 6;
            this.gbtn_ok.Text = "OK";
            this.gbtn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_ok.Click += new System.EventHandler(this.gbtn_ok_Click);
            // 
            // gtb_code
            // 
            this.gtb_code.BackColor = System.Drawing.Color.Transparent;
            this.gtb_code.BaseColor = System.Drawing.Color.White;
            this.gtb_code.BorderColor = System.Drawing.Color.Silver;
            this.gtb_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_code.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_code.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_code.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_code.Location = new System.Drawing.Point(47, 56);
            this.gtb_code.Name = "gtb_code";
            this.gtb_code.PasswordChar = '\0';
            this.gtb_code.Radius = 10;
            this.gtb_code.SelectedText = "";
            this.gtb_code.Size = new System.Drawing.Size(160, 30);
            this.gtb_code.TabIndex = 5;
            this.gtb_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_code_KeyDown);
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(47, 9);
            this.lbl_info.MaximumSize = new System.Drawing.Size(160, 44);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(160, 44);
            this.lbl_info.TabIndex = 7;
            this.lbl_info.Text = "Text";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // EmailConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 172);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.gbtn_ok);
            this.Controls.Add(this.gtb_code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Confirmation";
            this.Load += new System.EventHandler(this.EmailConfirmation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gbtn_ok;
        private Guna.UI.WinForms.GunaTextBox gtb_code;
        private System.Windows.Forms.Label lbl_info;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}