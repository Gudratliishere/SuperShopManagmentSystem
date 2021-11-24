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
            gcb_productCompany.DataSource = productCompanyDAO.GetAll();
            gcb_productCompany.DisplayMember = "Name";
            gcb_productCompany.ValueMember = "Id";

            gcb_productKind.DataSource = productKindDAO.GetAll();
            gcb_productKind.DisplayMember = "Name";
            gcb_productKind.ValueMember = "Id";

            if (product != null)
            {
                gtb_name.Text = product.Name;
                gnum_number.Value = product.Number;
                gtb_arrivalPrice.Text = product.ArrivalPrice.ToString();
                gtb_salePrice.Text = product.SalePrice.ToString();
                try
                {
                    gdtp_lastComeDate.Value = product.LastComeDate;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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
                var arrivalPrice = gtb_arrivalPrice.Text.Replace('.', ',');
                product.ArrivalPrice = double.Parse(arrivalPrice);
            }
            catch
            {
                gtb_arrivalPrice.BorderColor = Color.Red;
            }
            try
            {
                var salePrice = gtb_salePrice.Text.Replace('.', ',');
                product.SalePrice = double.Parse(salePrice);
                product.LastComeDate = gdtp_lastComeDate.Value;
                int companyId = int.Parse(gcb_productCompany.SelectedValue.ToString());
                product.Company = productCompanyDAO.GetProductCompanyById(companyId);
                int kindId = int.Parse(gcb_productKind.SelectedValue.ToString());
                product.Kind = productKindDAO.GetProductKindById(kindId);

                if (productNumberDAO.GetProductNumberById(product.Id) == null)
                    productNumberDAO.AddProductNumber(product);
                else
                    productNumberDAO.UpdateProductNumber(product);

                Products products = new Products();
                products.Dock = DockStyle.Fill;
                MainAdmin.Instance.pnl_windows.Controls.Clear();
                MainAdmin.Instance.pnl_windows.Controls.Add(products);
            }
            catch
            {
                gtb_salePrice.BorderColor = Color.Red;
            }
        }
    }
}
