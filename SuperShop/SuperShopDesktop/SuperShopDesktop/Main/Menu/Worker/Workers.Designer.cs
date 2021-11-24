namespace SuperShopDesktop.Main.Menu.Worker
{
    partial class Workers
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
            this.gcb_sector = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_editRemove = new System.Windows.Forms.Panel();
            this.gbtn_remove = new Guna.UI.WinForms.GunaButton();
            this.gbtn_edit = new Guna.UI.WinForms.GunaButton();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.gdgv_workers = new Guna.UI.WinForms.GunaDataGridView();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_sidebar)).BeginInit();
            this.pnl_productClass.SuspendLayout();
            this.pnl_editRemove.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_workers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.pnl_sidebar.Controls.Add(this.gdgv_sidebar);
            this.pnl_sidebar.Controls.Add(this.pnl_productClass);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(200, 444);
            this.pnl_sidebar.TabIndex = 4;
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
            this.gdgv_sidebar.Location = new System.Drawing.Point(0, 31);
            this.gdgv_sidebar.Name = "gdgv_sidebar";
            this.gdgv_sidebar.RowHeadersVisible = false;
            this.gdgv_sidebar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgv_sidebar.Size = new System.Drawing.Size(200, 413);
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
            this.gdgv_sidebar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdgv_sidebar_CellContentClick);
            // 
            // pnl_productClass
            // 
            this.pnl_productClass.Controls.Add(this.gcb_sector);
            this.pnl_productClass.Controls.Add(this.pnl_editRemove);
            this.pnl_productClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_productClass.Location = new System.Drawing.Point(0, 0);
            this.pnl_productClass.Name = "pnl_productClass";
            this.pnl_productClass.Size = new System.Drawing.Size(200, 31);
            this.pnl_productClass.TabIndex = 2;
            // 
            // gcb_sector
            // 
            this.gcb_sector.BackColor = System.Drawing.Color.Transparent;
            this.gcb_sector.BaseColor = System.Drawing.Color.White;
            this.gcb_sector.BorderColor = System.Drawing.Color.Silver;
            this.gcb_sector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcb_sector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_sector.FocusedColor = System.Drawing.Color.Empty;
            this.gcb_sector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb_sector.ForeColor = System.Drawing.Color.Black;
            this.gcb_sector.FormattingEnabled = true;
            this.gcb_sector.Items.AddRange(new object[] {
            "All",
            "Sector"});
            this.gcb_sector.Location = new System.Drawing.Point(0, 0);
            this.gcb_sector.Name = "gcb_sector";
            this.gcb_sector.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcb_sector.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcb_sector.Radius = 10;
            this.gcb_sector.Size = new System.Drawing.Size(149, 26);
            this.gcb_sector.Sorted = true;
            this.gcb_sector.StartIndex = 0;
            this.gcb_sector.TabIndex = 2;
            this.gcb_sector.SelectedIndexChanged += new System.EventHandler(this.gcb_sector_SelectedIndexChanged);
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
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.gdgv_workers);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(200, 0);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(499, 444);
            this.pnl_body.TabIndex = 5;
            // 
            // gdgv_workers
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gdgv_workers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdgv_workers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgv_workers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdgv_workers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgv_workers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_workers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgv_workers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdgv_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgv_workers.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdgv_workers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdgv_workers.EnableHeadersVisualStyles = false;
            this.gdgv_workers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_workers.Location = new System.Drawing.Point(0, 0);
            this.gdgv_workers.Name = "gdgv_workers";
            this.gdgv_workers.RowHeadersVisible = false;
            this.gdgv_workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgv_workers.Size = new System.Drawing.Size(499, 444);
            this.gdgv_workers.TabIndex = 1;
            this.gdgv_workers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgv_workers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_workers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgv_workers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgv_workers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgv_workers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgv_workers.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.gdgv_workers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_workers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgv_workers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgv_workers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_workers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgv_workers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdgv_workers.ThemeStyle.HeaderStyle.Height = 23;
            this.gdgv_workers.ThemeStyle.ReadOnly = false;
            this.gdgv_workers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_workers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_workers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgv_workers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_workers.ThemeStyle.RowsStyle.Height = 22;
            this.gdgv_workers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_workers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_workers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdgv_workers_CellContentDoubleClick);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_sidebar);
            this.Name = "Workers";
            this.Size = new System.Drawing.Size(699, 444);
            this.Load += new System.EventHandler(this.Workers_Load);
            this.pnl_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_sidebar)).EndInit();
            this.pnl_productClass.ResumeLayout(false);
            this.pnl_editRemove.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_workers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private Guna.UI.WinForms.GunaDataGridView gdgv_sidebar;
        private System.Windows.Forms.Panel pnl_productClass;
        private Guna.UI.WinForms.GunaComboBox gcb_sector;
        private System.Windows.Forms.Panel pnl_editRemove;
        private Guna.UI.WinForms.GunaButton gbtn_remove;
        private Guna.UI.WinForms.GunaButton gbtn_edit;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI.WinForms.GunaDataGridView gdgv_workers;
    }
}
