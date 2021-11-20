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
using Guna.UI.WinForms;

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class Workers: UserControl
    {
        private IWorkerDAO workerDAO;
        private GunaDataGridView gunadgv;

        public GunaDataGridView Gunadgv { get => gunadgv; }

        public Workers ()
        {
            InitializeComponent();

            workerDAO = Context.GetWorkerDAO();
        }

        private void Workers_Load (object sender, EventArgs e)
        {
            var workers = workerDAO.GetAll();

            var data = from worker in workers
                       select new
                       {
                           worker.Id,
                           No = workers.IndexOf(worker) + 1,
                           worker.Name,
                           worker.Surname,
                           worker.Email,
                           worker.Phone
                       };

            gdgv_personals.DataSource = data.ToList();
            gdgv_personals.Columns[0].Visible = false;
        }

        private void gdgv_personals_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int workerId = Int32.Parse(gdgv_personals.CurrentRow.Cells[0].Value.ToString());
            WorkerView view = new WorkerView();
            view.Worker = workerDAO.GetWorkerById(workerId);
            view.WorkersPanel = this;
            view.Dock = DockStyle.Fill;
            gunadgv = gdgv_personals;
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(view);
        }
    }
}
