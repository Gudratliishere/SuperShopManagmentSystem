using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDatabase.Entity;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Config;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class ProductNumberEdit : UserControl
    {
        private ProductNumber product;
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;
        private IProductNumberDAO productNumberDAO;

        public ProductNumberEdit ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
            productNumberDAO = Context.GetProductNumberDAO();
        }

        public ProductNumber Product { set => product = value; }

        private void ProductNumberEdit_Load (object sender, EventArgs e)
        {
            var companyNames = new List<String>();
            productCompanyDAO.GetAll().ForEach((company) => companyNames.Add(company.Name));
            gcb_productCompany.DataSource = companyNames;

            var kindNames = new List<String>();
            productKindDAO.GetAll().ForEach((kind) => kindNames.Add(kind.Name));
            gcb_productKind.DataSource = kindNames;

            if (product != null)
            {
                gtb_name.Text = product.Name;
                gnum_number.Value = product.Number;
                gtb_arrivalPrice.Text = product.ArrivalPrice.ToString();
                gtb_salePrice.Text = product.SalePrice.ToString();
                gdtp_lastComeDate.Value = product.LastComeDate;
                gcb_productCompany.SelectedItem = product.Company.Name;
                gcb_productKind.SelectedItem = product.Kind.Name;
            }
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            gtb_arrivalPrice.BorderColor = Color.Silver;
            gtb_salePrice.BorderColor = Color.Silver;

            if (product == null)
                product = new ProductNumber();

            product.Name = gtb_name.Text;
            product.Number = (int) gnum_number.Value;
            try
            {
                product.ArrivalPrice = double.Parse(gtb_arrivalPrice.Text);
            } catch
            {
                MessageBox.Show("Please write arrival price at right format!");
                gtb_arrivalPrice.BorderColor = Color.Red;
            }
            try
            {
                product.SalePrice = double.Parse(gtb_salePrice.Text);
            }
            catch
            {
                MessageBox.Show("Please write sale price at right format!");
                gtb_salePrice.BorderColor = Color.Red;
            }
            product.Company = productCompanyDAO.GetProductCompanyByName(gcb_productCompany.SelectedItem.ToString());
            product.Kind = productKindDAO.GetProductKindByName(gcb_productKind.SelectedItem.ToString());

            if (productNumberDAO.GetProductNumberById(product.Id) == null)
                productNumberDAO.AddProductNumber(product);
            else
                productNumberDAO.UpdateProductNumber(product);

            Products products = new Products();
            products.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(products);
        }
    }
}
