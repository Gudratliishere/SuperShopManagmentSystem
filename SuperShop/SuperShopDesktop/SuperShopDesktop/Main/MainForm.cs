using SuperShopDesktop.Main.Menu;
using SuperShopDesktop.Main.Menu.Worker;
using SuperShopDesktop.Main.Menu.Product;
using SuperShopDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDesktop.Main.Menu.Cashier;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Config;
using SuperShopDesktop.Login;
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        public static int Session;

        private IProductNumberDAO productNumberDAO;
        private IProductWeightDAO productWeightDAO;

        public MainForm ()
        {
            InitializeComponent();
            InitializeTopBorder();
            InitializeDAOs();

            Instance = this;
            Session = 1;
        }

        private void InitializeDAOs ()
        {
            productNumberDAO = Context.GetProductNumberDAO();
            productWeightDAO = Context.GetProductWeightDAO();
        }

        private void InitializeTopBorder ()
        {
            TopBorder top = new TopBorder(this);
            top.Dock = DockStyle.Fill;
            pnl_top.Controls.Add(top);
        }

        private void gbtn_products_Click (object sender, EventArgs e)
        {
            Products products = new Products();
            products.Dock = DockStyle.Fill;
            pnl_windows.Controls.Clear();
            pnl_windows.Controls.Add(products);
        }

        private void gbtn_personals_Click (object sender, EventArgs e)
        {
            pnl_windows.Controls.Clear();
            Workers personals = new Workers();
            personals.Dock = DockStyle.Fill;
            pnl_windows.Controls.Add(personals);
        }

        private void gbtn_add_Click (object sender, EventArgs e)
        {
            pnl_windows.Controls.Clear();
            AddNew add = new AddNew();
            add.Dock = DockStyle.Fill;
            pnl_windows.Controls.Add(add);
        }

        private void gbtn_cashiers_Click (object sender, EventArgs e)
        {
            Cashiers cashiers = new Cashiers();
            cashiers.Dock = DockStyle.Fill;
            pnl_windows.Controls.Clear();
            pnl_windows.Controls.Add(cashiers);
        }

        private void MainAdmin_Load (object sender, EventArgs e)
        {
            LoadControlTexts();

            if (Session == 2)
            {
                gbtn_workers.Visible = false;
                gbtn_cashiers.Visible = false;
            }

            gbtn_products.PerformClick();
        }

        private void LoadControlTexts ()
        {
            gbtn_products.Text = LanguageConfig.RM.GetString("Main_MainAdmin_gbtn_products");
            gbtn_workers.Text = LanguageConfig.RM.GetString("Main_MainAdmin_gbtn_workers");
            gbtn_cashiers.Text = LanguageConfig.RM.GetString("Main_MainAdmin_gbtn_cashiers");
            gbtn_settings.Text = LanguageConfig.RM.GetString("Main_MainAdmin_gbtn_settings");
        }

        private void gbtn_logout_Click (object sender, EventArgs e)
        {
            LoginPanelManager.Clear();
            MainLogin login = new MainLogin();
            login.Show();
            Hide();
        }

        private void gbtn_notification_Click (object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Dock = DockStyle.Fill;
            pnl_windows.Controls.Clear();
            pnl_windows.Controls.Add(notification);
        }

        private void gbtn_settings_Click (object sender, EventArgs e)
        {
            Menu.Settings setting = new Menu.Settings();
            setting.Dock = DockStyle.Fill;
            pnl_windows.Controls.Clear();
            pnl_windows.Controls.Add(setting);
        }
    }
}
