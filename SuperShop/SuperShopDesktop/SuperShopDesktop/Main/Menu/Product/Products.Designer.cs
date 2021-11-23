namespace SuperShopDesktop.Main.Menu.Product
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.gdgv_sidebar = new Guna.UI.WinForms.GunaDataGridView();
            this.gcb_productClass = new Guna.UI.WinForms.GunaComboBox();
            this.gcb_specify = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.gdgv_products = new Guna.UI.WinForms.GunaDataGridView();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_sidebar)).BeginInit();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.pnl_sidebar.Controls.Add(this.gdgv_sidebar);
            this.pnl_sidebar.Controls.Add(this.gcb_productClass);
            this.pnl_sidebar.Controls.Add(this.gcb_specify);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(200, 421);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // gdgv_sidebar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgv_sidebar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgv_sidebar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgv_sidebar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.gdgv_sidebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgv_sidebar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_sidebar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgv_sidebar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgv_sidebar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgv_sidebar.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgv_sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdgv_sidebar.EnableHeadersVisualStyles = false;
            this.gdgv_sidebar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_sidebar.Location = new System.Drawing.Point(0, 52);
            this.gdgv_sidebar.Name = "gdgv_sidebar";
            this.gdgv_sidebar.RowHeadersVisible = false;
            this.gdgv_sidebar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgv_sidebar.Size = new System.Drawing.Size(200, 369);
            this.gdgv_sidebar.TabIndex = 1;
            this.gdgv_sidebar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgv_sidebar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_sidebar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgv_sidebar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgv_sidebar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgv_sidebar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgv_sidebar.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.gdgv_sidebar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdgv_sidebar.ThemeStyle.HeaderStyle.Height = 23;
            this.gdgv_sidebar.ThemeStyle.ReadOnly = false;
            this.gdgv_sidebar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_sidebar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_sidebar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_sidebar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_sidebar.ThemeStyle.RowsStyle.Height = 22;
            this.gdgv_sidebar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_sidebar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_sidebar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdgv_sidebar_CellContentClick);
            // 
            // gcb_productClass
            // 
            this.gcb_productClass.BackColor = System.Drawing.Color.Transparent;
            this.gcb_productClass.BaseColor = System.Drawing.Color.White;
            this.gcb_productClass.BorderColor = System.Drawing.Color.Silver;
            this.gcb_productClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcb_productClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_productClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_productClass.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_productClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb_productClass.ForeColor = System.Drawing.Color.Black;
            this.gcb_productClass.FormattingEnabled = true;
            this.gcb_productClass.Items.AddRange(new object[] {
            "Numbered products",
            "Weight products"});
            this.gcb_productClass.Location = new System.Drawing.Point(0, 26);
            this.gcb_productClass.Name = "gcb_productClass";
            this.gcb_productClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_productClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_productClass.Radius = 10;
            this.gcb_productClass.Size = new System.Drawing.Size(200, 26);
            this.gcb_productClass.Sorted = true;
            this.gcb_productClass.StartIndex = 0;
            this.gcb_productClass.TabIndex = 0;
            this.gcb_productClass.SelectedIndexChanged += new System.EventHandler(this.gcb_productClass_SelectedIndexChanged);
            // 
            // gcb_specify
            // 
            this.gcb_specify.BackColor = System.Drawing.Color.Transparent;
            this.gcb_specify.BaseColor = System.Drawing.Color.White;
            this.gcb_specify.BorderColor = System.Drawing.Color.Silver;
            this.gcb_specify.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcb_specify.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_specify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_specify.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_specify.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb_specify.ForeColor = System.Drawing.Color.Black;
            this.gcb_specify.FormattingEnabled = true;
            this.gcb_specify.Items.AddRange(new object[] {
            "All",
            "Company",
            "Kind"});
            this.gcb_specify.Location = new System.Drawing.Point(0, 0);
            this.gcb_specify.Name = "gcb_specify";
            this.gcb_specify.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_specify.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_specify.Radius = 10;
            this.gcb_specify.Size = new System.Drawing.Size(200, 26);
            this.gcb_specify.Sorted = true;
            this.gcb_specify.StartIndex = 0;
            this.gcb_specify.TabIndex = 0;
            this.gcb_specify.SelectedIndexChanged += new System.EventHandler(this.gcb_specify_SelectedIndexChanged);
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.gdgv_products);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(200, 0);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(464, 421);
            this.pnl_body.TabIndex = 1;
            // 
            // gdgv_products
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gdgv_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgv_products.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgv_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgv_products.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdgv_products.EnableHeadersVisualStyles = false;
            this.gdgv_products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_products.Location = new System.Drawing.Point(0, 0);
            this.gdgv_products.Name = "gdgv_products";
            this.gdgv_products.RowHeadersVisible = false;
            this.gdgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgv_products.Size = new System.Drawing.Size(464, 421);
            this.gdgv_products.TabIndex = 0;
            this.gdgv_products.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgv_products.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_products.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgv_products.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgv_products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgv_products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgv_products.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.gdgv_products.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_products.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgv_products.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgv_products.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_products.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgv_products.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdgv_products.ThemeStyle.HeaderStyle.Height = 23;
            this.gdgv_products.ThemeStyle.ReadOnly = false;
            this.gdgv_products.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_products.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_products.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_products.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_products.ThemeStyle.RowsStyle.Height = 22;
            this.gdgv_products.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_products.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_products.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdgv_products_CellContentDoubleClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_sidebar);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(664, 421);
            this.Load += new System.EventHandler(this.Products_Load);
            this.pnl_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_sidebar)).EndInit();
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private Guna.UI.WinForms.GunaComboBox gcb_specify;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI.WinForms.GunaDataGridView gdgv_products;
        private Guna.UI.WinForms.GunaDataGridView gdgv_sidebar;
        private Guna.UI.WinForms.GunaComboBox gcb_productClass;
    }
}
