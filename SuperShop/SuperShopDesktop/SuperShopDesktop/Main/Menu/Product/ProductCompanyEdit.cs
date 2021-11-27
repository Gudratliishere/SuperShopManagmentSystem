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
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class ProductCompanyEdit : UserControl
    {
        private IProductCompanyDAO productCompanyDAO;

        public ProductCompanyEdit ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
        }

        public ProductCompany ProductCompany { get; set; }

        private void ProductCompanyEdit_Load (object sender, EventArgs e)
        {
            if (ProductCompany != null)
            {
                gtb_name.Text = ProductCompany.Name;
                gtb_email.Text = ProductCompany.Email;
                gtb_phone.Text = ProductCompany.Phone;
                try
                {
                    gdtp_lastComeDate.Value = ProductCompany.LastComeDate;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    gdtp_beginDate.Value = ProductCompany.BeginDate;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    gdtp_endDate.Value = ProductCompany.EndDate;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            lbl_name.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_name");
            lbl_email.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_email");
            lbl_phone.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_phone");
            lbl_lastComeDate.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_lastComeDate");
            lbl_beginDate.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_beginDate");
            lbl_endDate.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_lbl_endDate");
            gbtn_save.Text = LanguageConfig.RM.GetString("Main_ProductCompanyEdit_gbtn_save");
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            if (ProductCompany == null)
                ProductCompany = new SuperShopDatabase.Entity.ProductCompany();

            ProductCompany.Name = gtb_name.Text;
            ProductCompany.Email = gtb_email.Text;
            ProductCompany.Phone = gtb_phone.Text;
            ProductCompany.LastComeDate = gdtp_lastComeDate.Value;
            ProductCompany.BeginDate = gdtp_beginDate.Value;
            ProductCompany.EndDate = gdtp_endDate.Value;

            if (productCompanyDAO.GetProductCompanyById(ProductCompany.Id) != null)
                productCompanyDAO.UpdateProductCompany(ProductCompany);
            else
                productCompanyDAO.AddProductCompany(ProductCompany);

            Products products = new Products();
            products.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(products);
        }
    }
}
