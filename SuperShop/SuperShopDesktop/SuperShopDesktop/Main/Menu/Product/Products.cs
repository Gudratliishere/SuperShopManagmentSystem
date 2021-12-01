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
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class Products : UserControl
    {
        private static readonly Logger _log = new Logger("Products");

        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;
        private IProductNumberDAO productNumberDAO;
        private IProductWeightDAO productWeightDAO;
        private IBarcodeDAO barcodeDAO;

        private ProductCompany selectedProductCompany;
        private ProductKind selectedProductKind;
        private int lastIndex;
        private int selectedProductRow = 0;

        public Products ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
            productNumberDAO = Context.GetProductNumberDAO();
            productWeightDAO = Context.GetProductWeightDAO();
            barcodeDAO = Context.GetBarcodeDAO();
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
            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            var list = new List<Specify>();
            list.Add(new Specify("az", LanguageConfig.RM.GetString("Main_Products_gcb_all")));
            list.Add(new Specify("en", LanguageConfig.RM.GetString("Main_Products_gcb_company")));
            list.Add(new Specify("en", LanguageConfig.RM.GetString("Main_Products_gcb_kind")));
            gcb_specify.DataSource = list;
            gcb_specify.DisplayMember = "Name";
            gcb_specify.ValueMember = "Id";

            var list2 = new List<ProductClass>();
            list2.Add(new ProductClass("az", LanguageConfig.RM.GetString("Main_Products_gcb_productNumber")));
            list2.Add(new ProductClass("en", LanguageConfig.RM.GetString("Main_Products_gcb_productWeight")));
            gcb_productClass.DataSource = list2;
            gcb_productClass.DisplayMember = "Name";
            gcb_productClass.ValueMember = "Id";
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
                MainForm.Instance.pnl_windows.Controls.Clear();
                MainForm.Instance.pnl_windows.Controls.Add(edit);
            }
            else
            {
                ProductWeightEdit edit = new ProductWeightEdit();
                edit.Product = productWeightDAO.GetProductWeightById(id);
                edit.Dock = DockStyle.Fill;
                MainForm.Instance.pnl_windows.Controls.Clear();
                MainForm.Instance.pnl_windows.Controls.Add(edit);
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
                    selectedProductRow = hit.RowIndex;
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
            try
            {
                int id = int.Parse(gdgv_products.Rows[selectedProductRow].Cells[0].Value.ToString());
                if (lastIndex == 0)
                {
                    Barcode barcode = barcodeDAO.GetBarcodeByProductNumber(productNumberDAO.GetProductNumberById(id));
                    barcodeDAO.RemoveBarcode(barcode);
                    productNumberDAO.RemoveProductNumber(productNumberDAO.GetProductNumberById(id));
                }
                else
                    productWeightDAO.RemoveProductWeight(productWeightDAO.GetProductWeightById(id));
            } catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void RemoveSpecifyBar ()
        {
            int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
            if (gcb_specify.SelectedIndex == 1)
            {
                var company = productCompanyDAO.GetProductCompanyById(id);
                productNumberDAO.GetAllByCompany(company).ForEach((product) =>
                {
                    productNumberDAO.RemoveProductNumber(product);
                });
                productWeightDAO.GetAllByCompany(company).ForEach((product) =>
                {
                    productWeightDAO.RemoveProductWeight(product);
                });
                productCompanyDAO.RemoveProductCompany(company);
            }
            else if (gcb_specify.SelectedIndex == 2)
            {
                var kind = productKindDAO.GetProductKindById(id);
                productNumberDAO.GetAllByKind(kind).ForEach((product) =>
                {
                    productNumberDAO.RemoveProductNumber(product);
                });
                productWeightDAO.GetAllByKind(kind).ForEach((product) =>
                {
                    productWeightDAO.RemoveProductWeight(product);
                });
                productKindDAO.RemoveProductKind(productKindDAO.GetProductKindById(id));
            }
        }

        private GunaButton GenerateRemoveButton (Point point, Action action)
        {
            GunaButton button = new GunaButton()
            {
                Image = null,
                Text = LanguageConfig.RM.GetString("Main_Remove"),
                Size = new Size(63, 23),
                Location = point,
                TabIndex = 1
            };
            button.Click += delegate (object sender, EventArgs e)
            {
                DialogResult dt =
                MessageBox.Show(LanguageConfig.RM.GetString("Main_SureRemove"),
                    LanguageConfig.RM.GetString("Main_Remove"), MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    action.Invoke();
                    MainForm.Instance.gbtn_products.PerformClick();
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
                    MainForm.Instance.pnl_windows.Controls.Clear();
                    MainForm.Instance.pnl_windows.Controls.Add(edit);
                }
                else if (gcb_specify.SelectedIndex == 2)
                {
                    ProductKindEdit edit = new ProductKindEdit();
                    edit.ProductKind = productKindDAO.GetProductKindById(id);
                    edit.Dock = DockStyle.Fill;
                    MainForm.Instance.pnl_windows.Controls.Clear();
                    MainForm.Instance.pnl_windows.Controls.Add(edit);
                }
            }
        }

        private void gbtn_remove_Click (object sender, EventArgs e)
        {
            if (gcb_specify.SelectedIndex != 0)
            {
                DialogResult dt =
                    MessageBox.Show(LanguageConfig.RM.GetString("Main_SureRemove"),
                    LanguageConfig.RM.GetString("Main_Remove"), MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    RemoveSpecifyBar();
                    MainForm.Instance.gbtn_products.PerformClick();
                }
            }
        }

        private void gbtn_searchByName_Click (object sender, EventArgs e)
        {
            if (gcb_productClass.SelectedIndex == 0)
                FillDataSourceForNumberedProcuts(productNumberDAO.GetAllByName(gtb_searchByName.Text.Trim()));
            else
                FillDataSourceForWeightProcuts(productWeightDAO.GetAllByName(gtb_searchByName.Text.Trim()));
        }

        private void gtb_searchByName_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_searchByName.PerformClick();
        }

        private void gtb_searchByBarcode_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_searchByBarcode.PerformClick();
        }

        private void gbtn_searchByBarcode_Click (object sender, EventArgs e)
        {
            try
            {
                var barcode = barcodeDAO.GetBarcodeById(int.Parse(gtb_searchByBarcode.Text.Trim()));
                if (barcode.ProductNumber != null)
                {
                    var list = new List<ProductNumber>();
                    list.Add(barcode.ProductNumber);
                    FillDataSourceForNumberedProcuts(list);
                }
                else
                {
                    var list = new List<ProductScales>();
                    list.Add(barcode.ProductScales);
                    FillDataSourceForScaledProducts(list);
                }
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void FillDataSourceForScaledProducts (List<ProductScales> products)
        {
            var data = from product in products
                       select new
                       {
                           product.Id,
                           product.MeasureDate,
                           product.Weight,
                           product.ProductWeight.Name
                       };
            gdgv_products.DataSource = data.ToList();
        }
    }

    class Specify
    {
        public Specify (string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }

    class ProductClass
    {
        public ProductClass (string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
