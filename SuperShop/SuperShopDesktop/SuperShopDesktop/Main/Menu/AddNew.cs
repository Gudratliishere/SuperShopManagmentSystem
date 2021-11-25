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
using SuperShopDesktop.DesktopConfiguration;

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
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_productNumber_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductNumberEdit edit = new ProductNumberEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_productWeight_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductWeightEdit edit = new ProductWeightEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_company_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductCompanyEdit edit = new ProductCompanyEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_kind_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            ProductKindEdit edit = new ProductKindEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_workSector_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            WorkSectorEdit edit = new WorkSectorEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void gbtn_cashier_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            CashierEdit edit = new CashierEdit();
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }

        private void AddNew_Load (object sender, EventArgs e)
        {
            LoadControlTexts();

            if (MainForm.Session == 2)
            {
                gbtn_worker.Visible = false;
                gbtn_workSector.Visible = false;
                gbtn_cashier.Visible = false;
            }
        }

        private void LoadControlTexts ()
        {
            gbtn_product.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_product");
            gbtn_productNumber.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_productNumber");
            gbtn_productWeight.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_productWeight");
            gbtn_company.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_company");
            gbtn_kind.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_kind");
            gbtn_worker.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_worker");
            gbtn_workSector.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_workSector");
            gbtn_cashier.Text = LanguageConfig.RM.GetString("Main_AddNew_gbtn_cashier");
        }
    }
}
