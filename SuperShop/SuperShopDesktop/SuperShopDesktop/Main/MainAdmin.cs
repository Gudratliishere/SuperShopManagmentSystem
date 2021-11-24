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

namespace SuperShopDesktop.Main
{
    public partial class MainAdmin : Form
    {
        public static MainAdmin Instance;

        public MainAdmin ()
        {
            InitializeComponent();
            InitializeTopBorder();

            Instance = this;
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
            gbtn_products.PerformClick();
        }
    }
}
