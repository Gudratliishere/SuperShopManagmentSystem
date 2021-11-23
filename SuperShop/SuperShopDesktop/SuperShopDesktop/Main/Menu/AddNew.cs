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

        private void gbtn_workSector_Click (object sender, EventArgs e)
        {

        }
    }
}
