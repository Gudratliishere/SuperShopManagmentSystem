using SuperShopDesktop.Main.Menu;
using SuperShopDesktop.Main.Menu.Worker;
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

namespace SuperShopDesktop.Main
{
    public partial class MainAdmin : Form
    {
        public MainAdmin ()
        {
            InitializeComponent();
            InitializeTopBorder();
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
    }
}
