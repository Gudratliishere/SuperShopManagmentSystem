using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Config;
using SuperShopDatabase.Entity;
using Guna.UI.WinForms;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class Products : UserControl
    {
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;
        private IProductNumberDAO productNumberDAO;
        private IProductWeightDAO productWeightDAO;

        private SuperShopDatabase.Entity.ProductCompany selectedProductCompany;
        private ProductKind selectedProductKind;
        private int lastIndex;

        public Products ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
            productNumberDAO = Context.GetProductNumberDAO();
            productWeightDAO = Context.GetProductWeightDAO();
        }

        private void gcb_specify_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (gcb_specify.SelectedIndex == 0)
            {
                gdgv_sidebar.DataSource = null;
                FillProductsGridWithAll();
                lastIndex = gcb_productClass.SelectedIndex;
            }
            else if (gcb_specify.SelectedIndex == 1)
            {
                var list = productCompanyDAO.GetAll();
                var data = from entity in list select new { entity.Id, entity.Name };
                gdgv_sidebar.DataSource = data.ToList();
                gdgv_sidebar.Columns[0].Visible = false;
                if (list.Count > 0)
                    selectedProductCompany = list.ElementAt(0);
            }
            else
            {
                var list = productKindDAO.GetAll();
                var data = from entity in list select new { entity.Id, entity.Name };
                gdgv_sidebar.DataSource = data.ToList();
                gdgv_sidebar.Columns[0].Visible = false;
                if (list.Count > 0)
                    selectedProductKind = list.ElementAt(0);
            }
        }

        private void gdgv_sidebar_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
            if (gcb_specify.SelectedIndex == 1)
            {
                selectedProductCompany = productCompanyDAO.GetProductCompanyById(id);
                FillProductsGridWithCompany();
            }
            else
            {
                selectedProductKind = productKindDAO.GetProductKindById(id);
                FillProductsGridWithKind();
            }
            lastIndex = gcb_productClass.SelectedIndex;
        }

        private void Products_Load (object sender, EventArgs e)
        {
            FillProductsGridWithAll();
        }

        private void gcb_productClass_SelectedIndexChanged (object sender, EventArgs e)
        {
            lastIndex = gcb_productClass.SelectedIndex;
            switch (gcb_specify.SelectedIndex)
            {
                case 0:
                    FillProductsGridWithAll();
                    break;
                case 1:
                    FillProductsGridWithCompany();
                    break;
                case 2:
                    FillProductsGridWithKind();
                    break;
            }
        }

        private void FillProductsGridWithAll ()
        {
            if (gcb_productClass.SelectedIndex == 0)
                FillDataSourceForNumberedProcuts(productNumberDAO.GetAll());
            else
                FillDataSourceForWeightProcuts(productWeightDAO.GetAll());
            gdgv_products.Columns[0].Visible = false;
        }

        private void FillProductsGridWithCompany ()
        {
            if (gcb_productClass.SelectedIndex == 0)
                FillDataSourceForNumberedProcuts(productNumberDAO.GetAllByCompany(selectedProductCompany));
            else
                FillDataSourceForWeightProcuts(productWeightDAO.GetAllByCompany(selectedProductCompany));
            gdgv_products.Columns[0].Visible = false;
        }

        private void FillProductsGridWithKind ()
        {
            if (gcb_productClass.SelectedIndex == 0)
                FillDataSourceForNumberedProcuts(productNumberDAO.GetAllByKind(selectedProductKind));
            else
                FillDataSourceForWeightProcuts(productWeightDAO.GetAllByKind(selectedProductKind));
            gdgv_products.Columns[0].Visible = false;
        }

        private void FillDataSourceForNumberedProcuts (List<ProductNumber> products)
        {
            var data = from product in products
                       select new
                       {
                           product.Id,
                           product.Name,
                           product.Number,
                           product.ArrivalPrice,
                           product.SalePrice,
                           product.LastComeDate,
                           Company = product.Company.Name,
                           Kind = product.Kind.Name
                       };
            gdgv_products.DataSource = data.ToList();
        }

        private void FillDataSourceForWeightProcuts (List<ProductWeight> products)
        {
            var data = from product in products
                       select new
                       {
                           product.Id,
                           product.Name,
                           product.Weight,
                           product.ArrivalPrice,
                           product.SalePrice,
                           product.LastComeDate,
                           Company = product.Company.Name,
                           Kind = product.Kind.Name
                       };
            gdgv_products.DataSource = data.ToList();
        }

        private void gdgv_products_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gdgv_products.CurrentRow.Cells[0].Value.ToString());
            if (lastIndex == 0)
            {
                ProductNumberEdit edit = new ProductNumberEdit();
                edit.Product = productNumberDAO.GetProductNumberById(id);
                edit.Dock = DockStyle.Fill;
                MainAdmin.Instance.pnl_windows.Controls.Clear();
                MainAdmin.Instance.pnl_windows.Controls.Add(edit);
            }
            else
            {
                ProductWeightEdit edit = new ProductWeightEdit();
                edit.Product = productWeightDAO.GetProductWeightById(id);
                edit.Dock = DockStyle.Fill;
                MainAdmin.Instance.pnl_windows.Controls.Clear();
                MainAdmin.Instance.pnl_windows.Controls.Add(edit);
            }
        }

        private void gdgv_products_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = gdgv_products.HitTest(e.X, e.Y);
                gdgv_products.ClearSelection();
                if (hit.RowIndex >= 0)
                {
                    gdgv_products.Rows[hit.RowIndex].Selected = true;
                    GunaButton button = GenerateRemoveButton(e.Location, RemoveProduct);
                    button.MouseLeave += delegate (object sender2, EventArgs e2)
                    {
                        button.Visible = false;
                    };
                    gdgv_products.Controls.Add(button);
                }
            }
        }

        private void RemoveProduct ()
        {
            int id = int.Parse(gdgv_products.CurrentRow.Cells[0].Value.ToString());
            if (lastIndex == 0)
                productNumberDAO.RemoveProductNumber(productNumberDAO.GetProductNumberById(id));
            else
                productWeightDAO.RemoveProductWeight(productWeightDAO.GetProductWeightById(id));
        }

        private void RemoveSpecifyBar ()
        {
            int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
            if (gcb_specify.SelectedIndex == 1)
                productCompanyDAO.RemoveProductCompany(productCompanyDAO.GetProductCompanyById(id));
            else if (gcb_specify.SelectedIndex == 2)
                productKindDAO.RemoveProductKind(productKindDAO.GetProductKindById(id));
        }

        private GunaButton GenerateRemoveButton (Point point, Action action)
        {
            GunaButton button = new GunaButton()
            {
                Image = null,
                Text = "Remove",
                Size = new Size(63, 23),
                Location = point,
                TabIndex = 1
            };
            button.Click += delegate (object sender, EventArgs e)
            {
                DialogResult dt =
                MessageBox.Show("Are you sure to remove?", "Remove", MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    action.Invoke();
                    MainAdmin.Instance.gbtn_products.PerformClick();
                }
            };
            return button;
        }

        private void gbtn_edit_Click (object sender, EventArgs e)
        {
            if (gcb_specify.SelectedIndex != 0)
            {
                int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
                if (gcb_specify.SelectedIndex == 1)
                {
                    ProductCompanyEdit edit = new ProductCompanyEdit();
                    edit.ProductCompany = productCompanyDAO.GetProductCompanyById(id);
                    edit.Dock = DockStyle.Fill;
                    MainAdmin.Instance.pnl_windows.Controls.Clear();
                    MainAdmin.Instance.pnl_windows.Controls.Add(edit);
                }
                else if (gcb_specify.SelectedIndex == 2)
                {
                    ProductKindEdit edit = new ProductKindEdit();
                    edit.ProductKind = productKindDAO.GetProductKindById(id);
                    edit.Dock = DockStyle.Fill;
                    MainAdmin.Instance.pnl_windows.Controls.Clear();
                    MainAdmin.Instance.pnl_windows.Controls.Add(edit);
                }
            }
        }

        private void gbtn_remove_Click (object sender, EventArgs e)
        {
            if (gcb_specify.SelectedIndex != 0)
            {
                DialogResult dt =
                    MessageBox.Show("Are you sure to remove?", "Remove", MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    RemoveSpecifyBar();
                    MainAdmin.Instance.gbtn_products.PerformClick();
                }
            }
        }

        private void gbtn_searchByName_Click (object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = gdgv_products.DataSource;
            bs.Filter = "Name like '%" + gtb_searchByName.Text + "%'";
            gdgv_products.DataSource = bs;
            pnl_products.Controls.Clear();
            pnl_products.Controls.Add(gdgv_products);
        }
    }
}
