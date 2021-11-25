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
using SuperShopDatabase.Entity;
using SuperShopDatabase.Config;
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main.Menu.Product
{
    public partial class ProductKindEdit : UserControl
    {
        private IProductKindDAO productKindDAO;

        public ProductKindEdit ()
        {
            InitializeComponent();

            productKindDAO = Context.GetProductKindDAO();
        }

        public ProductKind ProductKind { get; set; }

        private void ProductKindEdit_Load (object sender, EventArgs e)
        {
            if (ProductKind != null)
                gtb_name.Text = ProductKind.Name;

            LoadControlTexts(); 
        }

        private void LoadControlTexts ()
        {
            lbl_name.Text = LanguageConfig.RM.GetString("Main_ProductKindEdit_lbl_name");
            gbtn_save.Text = LanguageConfig.RM.GetString("Main_ProductKindEdit_gbtn_save");
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            if (ProductKind == null)
                ProductKind = new ProductKind();

            ProductKind.Name = gtb_name.Text;

            if (productKindDAO.GetProductKindById(ProductKind.Id) != null)
                productKindDAO.UpdateProductKind(ProductKind);
            else
                productKindDAO.AddProductKind(ProductKind);

            Products products = new Products();
            products.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(products);
        }
    }
}
