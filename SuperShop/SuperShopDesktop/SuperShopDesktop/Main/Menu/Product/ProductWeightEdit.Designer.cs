namespace SuperShopDesktop.Main.Menu.Product
{
    partial class ProductWeightEdit
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
            this.pnl_weight = new System.Windows.Forms.Panel();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.pnl_arrivalPrice = new System.Windows.Forms.Panel();
            this.gtb_arrivalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_arrivalPrice = new System.Windows.Forms.Label();
            this.pnl_salePrice = new System.Windows.Forms.Panel();
            this.gtb_salePrice = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_salePrice = new System.Windows.Forms.Label();
            this.pnl_lastComeDate = new System.Windows.Forms.Panel();
            this.gdtp_lastComeDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_lastComeDate = new System.Windows.Forms.Label();
            this.pnl_productCompany = new System.Windows.Forms.Panel();
            this.gcb_productCompany = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_productCompany = new System.Windows.Forms.Label();
            this.pnl_productKind = new System.Windows.Forms.Panel();
            this.gcb_productKind = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_productKind = new System.Windows.Forms.Label();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.gbtn_save = new Guna.UI.WinForms.GunaButton();
            this.gtb_weight = new Guna.UI.WinForms.GunaTextBox();
            this.flp_main.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_weight.SuspendLayout();
            this.pnl_arrivalPrice.SuspendLayout();
            this.pnl_salePrice.SuspendLayout();
            this.pnl_lastComeDate.SuspendLayout();
            this.pnl_productCompany.SuspendLayout();
            this.pnl_productKind.SuspendLayout();
            this.pnl_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_main
            // 
            this.flp_main.AutoScroll = true;
            this.flp_main.Controls.Add(this.pnl_name);
            this.flp_main.Controls.Add(this.pnl_weight);
            this.flp_main.Controls.Add(this.pnl_arrivalPrice);
            this.flp_main.Controls.Add(this.pnl_salePrice);
            this.flp_main.Controls.Add(this.pnl_lastComeDate);
            this.flp_main.Controls.Add(this.pnl_productCompany);
            this.flp_main.Controls.Add(this.pnl_productKind);
            this.flp_main.Controls.Add(this.pnl_save);
            this.flp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_main.Location = new System.Drawing.Point(0, 0);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(678, 399);
            this.flp_main.TabIndex = 3;
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
            // pnl_weight
            // 
            this.pnl_weight.Controls.Add(this.gtb_weight);
            this.pnl_weight.Controls.Add(this.lbl_weight);
            this.pnl_weight.Location = new System.Drawing.Point(329, 3);
            this.pnl_weight.Name = "pnl_weight";
            this.pnl_weight.Size = new System.Drawing.Size(320, 90);
            this.pnl_weight.TabIndex = 1;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weight.Location = new System.Drawing.Point(44, 17);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(60, 21);
            this.lbl_weight.TabIndex = 0;
            this.lbl_weight.Text = "Weight";
            // 
            // pnl_arrivalPrice
            // 
            this.pnl_arrivalPrice.Controls.Add(this.gtb_arrivalPrice);
            this.pnl_arrivalPrice.Controls.Add(this.lbl_arrivalPrice);
            this.pnl_arrivalPrice.Location = new System.Drawing.Point(3, 99);
            this.pnl_arrivalPrice.Name = "pnl_arrivalPrice";
            this.pnl_arrivalPrice.Size = new System.Drawing.Size(320, 90);
            this.pnl_arrivalPrice.TabIndex = 2;
            // 
            // gtb_arrivalPrice
            // 
            this.gtb_arrivalPrice.BackColor = System.Drawing.Color.Transparent;
            this.gtb_arrivalPrice.BaseColor = System.Drawing.Color.White;
            this.gtb_arrivalPrice.BorderColor = System.Drawing.Color.Silver;
            this.gtb_arrivalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_arrivalPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_arrivalPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_arrivalPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_arrivalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_arrivalPrice.Location = new System.Drawing.Point(48, 41);
            this.gtb_arrivalPrice.Name = "gtb_arrivalPrice";
            this.gtb_arrivalPrice.PasswordChar = '\0';
            this.gtb_arrivalPrice.Radius = 10;
            this.gtb_arrivalPrice.SelectedText = "";
            this.gtb_arrivalPrice.Size = new System.Drawing.Size(131, 32);
            this.gtb_arrivalPrice.TabIndex = 2;
            // 
            // lbl_arrivalPrice
            // 
            this.lbl_arrivalPrice.AutoSize = true;
            this.lbl_arrivalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_arrivalPrice.Location = new System.Drawing.Point(44, 17);
            this.lbl_arrivalPrice.Name = "lbl_arrivalPrice";
            this.lbl_arrivalPrice.Size = new System.Drawing.Size(94, 21);
            this.lbl_arrivalPrice.TabIndex = 0;
            this.lbl_arrivalPrice.Text = "Arrival price";
            // 
            // pnl_salePrice
            // 
            this.pnl_salePrice.Controls.Add(this.gtb_salePrice);
            this.pnl_salePrice.Controls.Add(this.lbl_salePrice);
            this.pnl_salePrice.Location = new System.Drawing.Point(329, 99);
            this.pnl_salePrice.Name = "pnl_salePrice";
            this.pnl_salePrice.Size = new System.Drawing.Size(319, 90);
            this.pnl_salePrice.TabIndex = 3;
            // 
            // gtb_salePrice
            // 
            this.gtb_salePrice.BackColor = System.Drawing.Color.Transparent;
            this.gtb_salePrice.BaseColor = System.Drawing.Color.White;
            this.gtb_salePrice.BorderColor = System.Drawing.Color.Silver;
            this.gtb_salePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_salePrice.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_salePrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_salePrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_salePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_salePrice.Location = new System.Drawing.Point(48, 41);
            this.gtb_salePrice.Name = "gtb_salePrice";
            this.gtb_salePrice.PasswordChar = '\0';
            this.gtb_salePrice.Radius = 10;
            this.gtb_salePrice.SelectedText = "";
            this.gtb_salePrice.Size = new System.Drawing.Size(131, 32);
            this.gtb_salePrice.TabIndex = 2;
            // 
            // lbl_salePrice
            // 
            this.lbl_salePrice.AutoSize = true;
            this.lbl_salePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_salePrice.Location = new System.Drawing.Point(43, 17);
            this.lbl_salePrice.Name = "lbl_salePrice";
            this.lbl_salePrice.Size = new System.Drawing.Size(77, 21);
            this.lbl_salePrice.TabIndex = 0;
            this.lbl_salePrice.Text = "Sale price";
            // 
            // pnl_lastComeDate
            // 
            this.pnl_lastComeDate.Controls.Add(this.gdtp_lastComeDate);
            this.pnl_lastComeDate.Controls.Add(this.lbl_lastComeDate);
            this.pnl_lastComeDate.Location = new System.Drawing.Point(3, 195);
            this.pnl_lastComeDate.Name = "pnl_lastComeDate";
            this.pnl_lastComeDate.Size = new System.Drawing.Size(319, 94);
            this.pnl_lastComeDate.TabIndex = 4;
            // 
            // gdtp_lastComeDate
            // 
            this.gdtp_lastComeDate.BackColor = System.Drawing.Color.Transparent;
            this.gdtp_lastComeDate.BaseColor = System.Drawing.Color.White;
            this.gdtp_lastComeDate.BorderColor = System.Drawing.Color.Silver;
            this.gdtp_lastComeDate.CustomFormat = null;
            this.gdtp_lastComeDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gdtp_lastComeDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtp_lastComeDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdtp_lastComeDate.ForeColor = System.Drawing.Color.Black;
            this.gdtp_lastComeDate.Location = new System.Drawing.Point(48, 41);
            this.gdtp_lastComeDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtp_lastComeDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtp_lastComeDate.Name = "gdtp_lastComeDate";
            this.gdtp_lastComeDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.gdtp_lastComeDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtp_lastComeDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtp_lastComeDate.OnPressedColor = System.Drawing.Color.Black;
            this.gdtp_lastComeDate.Radius = 10;
            this.gdtp_lastComeDate.Size = new System.Drawing.Size(223, 30);
            this.gdtp_lastComeDate.TabIndex = 1;
            this.gdtp_lastComeDate.Text = "24 Kasım 2021 Çarşamba";
            this.gdtp_lastComeDate.Value = new System.DateTime(2021, 11, 24, 0, 45, 20, 425);
            // 
            // lbl_lastComeDate
            // 
            this.lbl_lastComeDate.AutoSize = true;
            this.lbl_lastComeDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastComeDate.Location = new System.Drawing.Point(44, 17);
            this.lbl_lastComeDate.Name = "lbl_lastComeDate";
            this.lbl_lastComeDate.Size = new System.Drawing.Size(114, 21);
            this.lbl_lastComeDate.TabIndex = 0;
            this.lbl_lastComeDate.Text = "Last come date";
            // 
            // pnl_productCompany
            // 
            this.pnl_productCompany.Controls.Add(this.gcb_productCompany);
            this.pnl_productCompany.Controls.Add(this.lbl_productCompany);
            this.pnl_productCompany.Location = new System.Drawing.Point(328, 195);
            this.pnl_productCompany.Name = "pnl_productCompany";
            this.pnl_productCompany.Size = new System.Drawing.Size(319, 94);
            this.pnl_productCompany.TabIndex = 5;
            // 
            // gcb_productCompany
            // 
            this.gcb_productCompany.BackColor = System.Drawing.Color.Transparent;
            this.gcb_productCompany.BaseColor = System.Drawing.Color.White;
            this.gcb_productCompany.BorderColor = System.Drawing.Color.Silver;
            this.gcb_productCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_productCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_productCompany.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_productCompany.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gcb_productCompany.ForeColor = System.Drawing.Color.Black;
            this.gcb_productCompany.FormattingEnabled = true;
            this.gcb_productCompany.Location = new System.Drawing.Point(48, 41);
            this.gcb_productCompany.Name = "gcb_productCompany";
            this.gcb_productCompany.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_productCompany.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_productCompany.Radius = 10;
            this.gcb_productCompany.Size = new System.Drawing.Size(197, 28);
            this.gcb_productCompany.TabIndex = 1;
            // 
            // lbl_productCompany
            // 
            this.lbl_productCompany.AutoSize = true;
            this.lbl_productCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productCompany.Location = new System.Drawing.Point(44, 17);
            this.lbl_productCompany.Name = "lbl_productCompany";
            this.lbl_productCompany.Size = new System.Drawing.Size(77, 21);
            this.lbl_productCompany.TabIndex = 0;
            this.lbl_productCompany.Text = "Company";
            // 
            // pnl_productKind
            // 
            this.pnl_productKind.Controls.Add(this.gcb_productKind);
            this.pnl_productKind.Controls.Add(this.lbl_productKind);
            this.pnl_productKind.Location = new System.Drawing.Point(3, 295);
            this.pnl_productKind.Name = "pnl_productKind";
            this.pnl_productKind.Size = new System.Drawing.Size(319, 94);
            this.pnl_productKind.TabIndex = 6;
            // 
            // gcb_productKind
            // 
            this.gcb_productKind.BackColor = System.Drawing.Color.Transparent;
            this.gcb_productKind.BaseColor = System.Drawing.Color.White;
            this.gcb_productKind.BorderColor = System.Drawing.Color.Silver;
            this.gcb_productKind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_productKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_productKind.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_productKind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gcb_productKind.ForeColor = System.Drawing.Color.Black;
            this.gcb_productKind.FormattingEnabled = true;
            this.gcb_productKind.Location = new System.Drawing.Point(48, 41);
            this.gcb_productKind.Name = "gcb_productKind";
            this.gcb_productKind.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_productKind.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_productKind.Radius = 10;
            this.gcb_productKind.Size = new System.Drawing.Size(197, 28);
            this.gcb_productKind.TabIndex = 2;
            // 
            // lbl_productKind
            // 
            this.lbl_productKind.AutoSize = true;
            this.lbl_productKind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productKind.Location = new System.Drawing.Point(44, 17);
            this.lbl_productKind.Name = "lbl_productKind";
            this.lbl_productKind.Size = new System.Drawing.Size(41, 21);
            this.lbl_productKind.TabIndex = 0;
            this.lbl_productKind.Text = "Kind";
            // 
            // pnl_save
            // 
            this.pnl_save.Controls.Add(this.gbtn_save);
            this.pnl_save.Location = new System.Drawing.Point(328, 295);
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
            // gtb_weight
            // 
            this.gtb_weight.BackColor = System.Drawing.Color.Transparent;
            this.gtb_weight.BaseColor = System.Drawing.Color.White;
            this.gtb_weight.BorderColor = System.Drawing.Color.Silver;
            this.gtb_weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_weight.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_weight.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_weight.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_weight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_weight.Location = new System.Drawing.Point(47, 41);
            this.gtb_weight.Name = "gtb_weight";
            this.gtb_weight.PasswordChar = '\0';
            this.gtb_weight.Radius = 10;
            this.gtb_weight.SelectedText = "";
            this.gtb_weight.Size = new System.Drawing.Size(132, 32);
            this.gtb_weight.TabIndex = 3;
            // 
            // ProductWeightEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.flp_main);
            this.Name = "ProductWeightEdit";
            this.Size = new System.Drawing.Size(678, 399);
            this.Load += new System.EventHandler(this.ProductWeightEdit_Load);
            this.flp_main.ResumeLayout(false);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_weight.ResumeLayout(false);
            this.pnl_weight.PerformLayout();
            this.pnl_arrivalPrice.ResumeLayout(false);
            this.pnl_arrivalPrice.PerformLayout();
            this.pnl_salePrice.ResumeLayout(false);
            this.pnl_salePrice.PerformLayout();
            this.pnl_lastComeDate.ResumeLayout(false);
            this.pnl_lastComeDate.PerformLayout();
            this.pnl_productCompany.ResumeLayout(false);
            this.pnl_productCompany.PerformLayout();
            this.pnl_productKind.ResumeLayout(false);
            this.pnl_productKind.PerformLayout();
            this.pnl_save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI.WinForms.GunaTextBox gtb_name;
        private System.Windows.Forms.Panel pnl_weight;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Panel pnl_arrivalPrice;
        private Guna.UI.WinForms.GunaTextBox gtb_arrivalPrice;
        private System.Windows.Forms.Label lbl_arrivalPrice;
        private System.Windows.Forms.Panel pnl_salePrice;
        private Guna.UI.WinForms.GunaTextBox gtb_salePrice;
        private System.Windows.Forms.Label lbl_salePrice;
        private System.Windows.Forms.Panel pnl_lastComeDate;
        private Guna.UI.WinForms.GunaDateTimePicker gdtp_lastComeDate;
        private System.Windows.Forms.Label lbl_lastComeDate;
        private System.Windows.Forms.Panel pnl_productCompany;
        private Guna.UI.WinForms.GunaComboBox gcb_productCompany;
        private System.Windows.Forms.Label lbl_productCompany;
        private System.Windows.Forms.Panel pnl_productKind;
        private Guna.UI.WinForms.GunaComboBox gcb_productKind;
        private System.Windows.Forms.Label lbl_productKind;
        private System.Windows.Forms.Panel pnl_save;
        private Guna.UI.WinForms.GunaButton gbtn_save;
        private Guna.UI.WinForms.GunaTextBox gtb_weight;
    }
}
