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

namespace SuperShopDesktop.Main.Menu.Cashier
{
    public partial class CashierEdit : UserControl
    {
        private ICashierDAO cashierDAO;
        private IWorkerDAO workerDAO;

        public CashierEdit ()
        {
            InitializeComponent();

            cashierDAO = Context.GetCashierDAO();
            workerDAO = Context.GetWorkerDAO();
        }

        public SuperShopDatabase.Entity.Cashier Cashier { get; set; }

        private void CashierEdit_Load (object sender, EventArgs e)
        {
            gcb_worker.DataSource = workerDAO.GetAll();
            gcb_worker.DisplayMember = "Name";
            gcb_worker.ValueMember = "Id";

            if (Cashier != null)
            {
                gtb_name.Text = Cashier.Name;
                gcb_worker.SelectedItem = Cashier.Worker.Name;
            } else
            {
                pnl_reset.Visible = false;
                pnl_remove.Visible = false;
            }
        }

        private void LoadControlTexts ()
        {
            lbl_name.Text = LanguageConfig.RM.GetString("Main_Menu_CashierEdit_lbl_name");
            lbl_worker.Text = LanguageConfig.RM.GetString("Main_Menu_CashierEdit_lbl_worker");
            gbtn_save.Text = LanguageConfig.RM.GetString("Main_Menu_CashierEdit_gbtn_save");
            gbtn_remove.Text = LanguageConfig.RM.GetString("Main_Menu_CashierEdit_gbtn_remove");
            gbtn_reset.Text = LanguageConfig.RM.GetString("Main_Menu_CashierEdit_gbtn_reset");
        }

        private void gbtn_reset_Click (object sender, EventArgs e)
        {
            Cashier.Sales = 0;
            Cashier.LastResetTime = DateTime.Now;

            cashierDAO.UpdateCashier(Cashier);

            var cashier = new Cashiers();
            cashier.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(cashier);
        }

        private void gbtn_remove_Click (object sender, EventArgs e)
        {
            cashierDAO.RemoveCashier(Cashier);

            var cashier = new Cashiers();
            cashier.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(cashier);
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            if (Cashier == null)
                Cashier = new SuperShopDatabase.Entity.Cashier();

            Cashier.Name = gtb_name.Text;
            int workerId = int.Parse(gcb_worker.SelectedValue.ToString());
            Cashier.Worker = workerDAO.GetWorkerById(workerId);

            if (cashierDAO.GetCashierById(Cashier.Id) != null)
                cashierDAO.UpdateCashier(Cashier);
            else
                cashierDAO.AddCashier(Cashier);


            var cashier = new Cashiers();
            cashier.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(cashier);
        }
    }
}
