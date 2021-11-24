using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDatabase.Config;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Entity;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class ProductWeightEdit : UserControl
    {
        private ProductWeight product;
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;
        private IProductWeightDAO productWeightDAO;

        public ProductWeightEdit ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
            productWeightDAO = Context.GetProductWeightDAO();
        }

        public ProductWeight Product { set => product = value; }

        private void ProductWeightEdit_Load (object sender, EventArgs e)
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
                gtb_weight.Text = product.Weight.ToString();
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
            gtb_weight.BorderColor = Color.Silver;
            gtb_arrivalPrice.BorderColor = Color.Silver;
            gtb_salePrice.BorderColor = Color.Silver;

            if (product == null)
                product = new ProductWeight();

            product.Name = gtb_name.Text;
            try
            {
                var weight = gtb_weight.Text.Replace('.', ',');
                product.Weight = double.Parse(weight);
            }
            catch
            {
                gtb_weight.BorderColor = Color.Red;
            }
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
                int companyId = int.Parse(gcb_productCompany.SelectedValue.ToString());
                product.Company = productCompanyDAO.GetProductCompanyById(companyId);
                int kindId = int.Parse(gcb_productKind.SelectedValue.ToString());
                product.Kind = productKindDAO.GetProductKindById(kindId);
                product.LastComeDate = gdtp_lastComeDate.Value;

                if (productWeightDAO.GetProductWeightById(product.Id) == null)
                    productWeightDAO.AddProductWeight(product);
                else
                    productWeightDAO.UpdateProductWeight(product);

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
