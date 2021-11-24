using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDesktop.Main.Menu.Worker;
using SuperShopDesktop.Main.Menu.Product;
using SuperShopDesktop.Main.Menu.Cashier;

namespace SuperShopDesktop.Main.Menu
{
    public partial class AddNew : UserControl
    {
        public AddNew ()
        {
            InitializeComponent();
        }

        private void gbtn_product_Click (object sender, EventArgs e)
        {
            pnl_productSub.Visible = !pnl_productSub.Visible;
        }

        private void gbtn_worker_Click (object sender, EventArgs e)
        {
            WorkerEdit edit = new WorkerEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_productNumber_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductNumberEdit edit = new ProductNumberEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_productWeight_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductWeightEdit edit = new ProductWeightEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_company_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductCompanyEdit edit = new ProductCompanyEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_kind_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductKindEdit edit = new ProductKindEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_workSector_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            WorkSectorEdit edit = new WorkSectorEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_cashier_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            CashierEdit edit = new CashierEdit();
            edit.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }
    }
}
