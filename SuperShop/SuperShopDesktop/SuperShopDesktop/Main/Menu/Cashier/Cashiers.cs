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

namespace SuperShopDesktop.Main.Menu.Cashier
{
    public partial class Cashiers : UserControl
    {
        private ICashierDAO cashierDAO;

        public Cashiers ()
        {
            InitializeComponent();

            cashierDAO = Context.GetCashierDAO();
        }

        private void Cashiers_Load (object sender, EventArgs e)
        {
            var cashiers = cashierDAO.GetAll();
            var data = from cashier in cashiers
                       select new
                       {
                           cashier.Id,
                           cashier.Name,
                           cashier.Sales,
                           cashier.LastResetTime,
                           Worker = cashier.Worker.Name
                       };
            gdgv_cashiers.DataSource = data.ToList();
            gdgv_cashiers.Columns[0].Visible = false;
        }

        private void gdgv_cashiers_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gdgv_cashiers.CurrentRow.Cells[0].Value.ToString());
            CashierEdit edit = new CashierEdit();
            edit.Dock = DockStyle.Fill;
            edit.Cashier = cashierDAO.GetCashierById(id);
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(edit);
        }
    }
}
