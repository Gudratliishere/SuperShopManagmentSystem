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
            this.pnl_productClass = new System.Windows.Forms.Panel();
            this.gcb_productClass = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_editRemove = new System.Windows.Forms.Panel();
            this.gbtn_remove = new Guna.UI.WinForms.GunaButton();
            this.gbtn_edit = new Guna.UI.WinForms.GunaButton();
            this.gcb_specify = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_products = new System.Windows.Forms.Panel();
            this.gdgv_products = new Guna.UI.WinForms.GunaDataGridView();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.gbtn_searchByBarcode = new Guna.UI.WinForms.GunaButton();
            this.gtb_searchByBarcode = new Guna.UI.WinForms.GunaTextBox();
            this.gbtn_searchByName = new Guna.UI.WinForms.GunaButton();
            this.gtb_searchByName = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_sidebar)).BeginInit();
            this.pnl_productClass.SuspendLayout();
            this.pnl_editRemove.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_products)).BeginInit();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.pnl_sidebar.Controls.Add(this.gdgv_sidebar);
            this.pnl_sidebar.Controls.Add(this.pnl_productClass);
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
            this.gdgv_sidebar.Location = new System.Drawing.Point(0, 57);
            this.gdgv_sidebar.Name = "gdgv_sidebar";
            this.gdgv_sidebar.RowHeadersVisible = false;
            this.gdgv_sidebar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgv_sidebar.Size = new System.Drawing.Size(200, 364);
            this.gdgv_sidebar.TabIndex = 3;
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
            // pnl_productClass
            // 
            this.pnl_productClass.Controls.Add(this.gcb_productClass);
            this.pnl_productClass.Controls.Add(this.pnl_editRemove);
            this.pnl_productClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_productClass.Location = new System.Drawing.Point(0, 26);
            this.pnl_productClass.Name = "pnl_productClass";
            this.pnl_productClass.Size = new System.Drawing.Size(200, 31);
            this.pnl_productClass.TabIndex = 2;
            // 
            // gcb_productClass
            // 
            this.gcb_productClass.BackColor = System.Drawing.Color.Transparent;
            this.gcb_productClass.BaseColor = System.Drawing.Color.White;
            this.gcb_productClass.BorderColor = System.Drawing.Color.Silver;
            this.gcb_productClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcb_productClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_productClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_productClass.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_productClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb_productClass.ForeColor = System.Drawing.Color.Black;
            this.gcb_productClass.FormattingEnabled = true;
            this.gcb_productClass.Items.AddRange(new object[] {
            "Numbered products",
            "Weight products"});
            this.gcb_productClass.Location = new System.Drawing.Point(0, 0);
            this.gcb_productClass.Name = "gcb_productClass";
            this.gcb_productClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_productClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_productClass.Radius = 10;
            this.gcb_productClass.Size = new System.Drawing.Size(149, 26);
            this.gcb_productClass.StartIndex = 0;
            this.gcb_productClass.TabIndex = 2;
            this.gcb_productClass.SelectedIndexChanged += new System.EventHandler(this.gcb_productClass_SelectedIndexChanged);
            // 
            // pnl_editRemove
            // 
            this.pnl_editRemove.Controls.Add(this.gbtn_remove);
            this.pnl_editRemove.Controls.Add(this.gbtn_edit);
            this.pnl_editRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_editRemove.Location = new System.Drawing.Point(149, 0);
            this.pnl_editRemove.Name = "pnl_editRemove";
            this.pnl_editRemove.Size = new System.Drawing.Size(51, 31);
            this.pnl_editRemove.TabIndex = 1;
            // 
            // gbtn_remove
            // 
            this.gbtn_remove.AnimationHoverSpeed = 0.07F;
            this.gbtn_remove.AnimationSpeed = 0.03F;
            this.gbtn_remove.BaseColor = System.Drawing.Color.Transparent;
            this.gbtn_remove.BorderColor = System.Drawing.Color.Black;
            this.gbtn_remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_remove.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_remove.ForeColor = System.Drawing.Color.White;
            this.gbtn_remove.Image = global::SuperShopDesktop.Properties.Resources.remove;
            this.gbtn_remove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_remove.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_remove.Location = new System.Drawing.Point(26, 4);
            this.gbtn_remove.Name = "gbtn_remove";
            this.gbtn_remove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_remove.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_remove.OnHoverImage = null;
            this.gbtn_remove.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_remove.Size = new System.Drawing.Size(25, 22);
            this.gbtn_remove.TabIndex = 1;
            this.gbtn_remove.Click += new System.EventHandler(this.gbtn_remove_Click);
            // 
            // gbtn_edit
            // 
            this.gbtn_edit.AnimationHoverSpeed = 0.07F;
            this.gbtn_edit.AnimationSpeed = 0.03F;
            this.gbtn_edit.BaseColor = System.Drawing.Color.Transparent;
            this.gbtn_edit.BorderColor = System.Drawing.Color.Black;
            this.gbtn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_edit.ForeColor = System.Drawing.Color.White;
            this.gbtn_edit.Image = global::SuperShopDesktop.Properties.Resources.edit;
            this.gbtn_edit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_edit.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_edit.Location = new System.Drawing.Point(0, 3);
            this.gbtn_edit.Name = "gbtn_edit";
            this.gbtn_edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_edit.OnHoverImage = null;
            this.gbtn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_edit.Size = new System.Drawing.Size(25, 22);
            this.gbtn_edit.TabIndex = 0;
            this.gbtn_edit.Click += new System.EventHandler(this.gbtn_edit_Click);
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
            this.gcb_specify.StartIndex = 0;
            this.gcb_specify.TabIndex = 0;
            this.gcb_specify.SelectedIndexChanged += new System.EventHandler(this.gcb_specify_SelectedIndexChanged);
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.pnl_products);
            this.pnl_body.Controls.Add(this.pnl_search);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(200, 0);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(464, 421);
            this.pnl_body.TabIndex = 1;
            // 
            // pnl_products
            // 
            this.pnl_products.Controls.Add(this.gdgv_products);
            this.pnl_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_products.Location = new System.Drawing.Point(0, 35);
            this.pnl_products.Name = "pnl_products";
            this.pnl_products.Size = new System.Drawing.Size(464, 386);
            this.pnl_products.TabIndex = 2;
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
            this.gdgv_products.Size = new System.Drawing.Size(464, 386);
            this.gdgv_products.TabIndex = 3;
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
            this.gdgv_products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gdgv_products_MouseClick);
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.gbtn_searchByBarcode);
            this.pnl_search.Controls.Add(this.gtb_searchByBarcode);
            this.pnl_search.Controls.Add(this.gbtn_searchByName);
            this.pnl_search.Controls.Add(this.gtb_searchByName);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Location = new System.Drawing.Point(0, 0);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(464, 35);
            this.pnl_search.TabIndex = 1;
            // 
            // gbtn_searchByBarcode
            // 
            this.gbtn_searchByBarcode.AnimationHoverSpeed = 0.07F;
            this.gbtn_searchByBarcode.AnimationSpeed = 0.03F;
            this.gbtn_searchByBarcode.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_searchByBarcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_searchByBarcode.BorderColor = System.Drawing.Color.Black;
            this.gbtn_searchByBarcode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_searchByBarcode.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_searchByBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_searchByBarcode.ForeColor = System.Drawing.Color.White;
            this.gbtn_searchByBarcode.Image = global::SuperShopDesktop.Properties.Resources.search;
            this.gbtn_searchByBarcode.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_searchByBarcode.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_searchByBarcode.Location = new System.Drawing.Point(425, 3);
            this.gbtn_searchByBarcode.Name = "gbtn_searchByBarcode";
            this.gbtn_searchByBarcode.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_searchByBarcode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_searchByBarcode.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_searchByBarcode.OnHoverImage = null;
            this.gbtn_searchByBarcode.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_searchByBarcode.Radius = 10;
            this.gbtn_searchByBarcode.Size = new System.Drawing.Size(34, 29);
            this.gbtn_searchByBarcode.TabIndex = 3;
            this.gbtn_searchByBarcode.Click += new System.EventHandler(this.gbtn_searchByBarcode_Click);
            // 
            // gtb_searchByBarcode
            // 
            this.gtb_searchByBarcode.BackColor = System.Drawing.Color.Transparent;
            this.gtb_searchByBarcode.BaseColor = System.Drawing.Color.White;
            this.gtb_searchByBarcode.BorderColor = System.Drawing.Color.Silver;
            this.gtb_searchByBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_searchByBarcode.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_searchByBarcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_searchByBarcode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_searchByBarcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_searchByBarcode.Location = new System.Drawing.Point(231, 2);
            this.gtb_searchByBarcode.Name = "gtb_searchByBarcode";
            this.gtb_searchByBarcode.PasswordChar = '\0';
            this.gtb_searchByBarcode.Radius = 10;
            this.gtb_searchByBarcode.SelectedText = "";
            this.gtb_searchByBarcode.Size = new System.Drawing.Size(188, 30);
            this.gtb_searchByBarcode.TabIndex = 2;
            this.gtb_searchByBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_searchByBarcode_KeyDown);
            // 
            // gbtn_searchByName
            // 
            this.gbtn_searchByName.AnimationHoverSpeed = 0.07F;
            this.gbtn_searchByName.AnimationSpeed = 0.03F;
            this.gbtn_searchByName.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_searchByName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_searchByName.BorderColor = System.Drawing.Color.Black;
            this.gbtn_searchByName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_searchByName.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_searchByName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_searchByName.ForeColor = System.Drawing.Color.White;
            this.gbtn_searchByName.Image = global::SuperShopDesktop.Properties.Resources.search;
            this.gbtn_searchByName.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_searchByName.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_searchByName.Location = new System.Drawing.Point(170, 3);
            this.gbtn_searchByName.Name = "gbtn_searchByName";
            this.gbtn_searchByName.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_searchByName.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_searchByName.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_searchByName.OnHoverImage = null;
            this.gbtn_searchByName.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_searchByName.Radius = 10;
            this.gbtn_searchByName.Size = new System.Drawing.Size(34, 29);
            this.gbtn_searchByName.TabIndex = 1;
            this.gbtn_searchByName.Click += new System.EventHandler(this.gbtn_searchByName_Click);
            // 
            // gtb_searchByName
            // 
            this.gtb_searchByName.BackColor = System.Drawing.Color.Transparent;
            this.gtb_searchByName.BaseColor = System.Drawing.Color.White;
            this.gtb_searchByName.BorderColor = System.Drawing.Color.Silver;
            this.gtb_searchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_searchByName.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_searchByName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_searchByName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_searchByName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_searchByName.Location = new System.Drawing.Point(3, 2);
            this.gtb_searchByName.Name = "gtb_searchByName";
            this.gtb_searchByName.PasswordChar = '\0';
            this.gtb_searchByName.Radius = 10;
            this.gtb_searchByName.SelectedText = "";
            this.gtb_searchByName.Size = new System.Drawing.Size(161, 30);
            this.gtb_searchByName.TabIndex = 0;
            this.gtb_searchByName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_searchByName_KeyDown);
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
            this.pnl_productClass.ResumeLayout(false);
            this.pnl_editRemove.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_products)).EndInit();
            this.pnl_search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private Guna.UI.WinForms.GunaComboBox gcb_specify;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI.WinForms.GunaDataGridView gdgv_sidebar;
        private System.Windows.Forms.Panel pnl_productClass;
        private Guna.UI.WinForms.GunaComboBox gcb_productClass;
        private System.Windows.Forms.Panel pnl_editRemove;
        private Guna.UI.WinForms.GunaButton gbtn_remove;
        private Guna.UI.WinForms.GunaButton gbtn_edit;
        private System.Windows.Forms.Panel pnl_search;
        private Guna.UI.WinForms.GunaButton gbtn_searchByBarcode;
        private Guna.UI.WinForms.GunaTextBox gtb_searchByBarcode;
        private Guna.UI.WinForms.GunaButton gbtn_searchByName;
        private Guna.UI.WinForms.GunaTextBox gtb_searchByName;
        private System.Windows.Forms.Panel pnl_products;
        private Guna.UI.WinForms.GunaDataGridView gdgv_products;
    }
}
