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
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class Workers : UserControl
    {
        private IWorkerDAO workerDAO;
        private IWorkSectorDAO workSectorDAO;

        public Workers ()
        {
            InitializeComponent();

            workerDAO = Context.GetWorkerDAO();
            workSectorDAO = Context.GetWorkSectorDAO();
        }

        private void Workers_Load (object sender, EventArgs e)
        {
            try
            {
                FillWorkers(workerDAO.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            var list = new List<Specify>();
            list.Add(new Specify("az", LanguageConfig.RM.GetString("Main_Workers_cb_all")));
            list.Add(new Specify("en", LanguageConfig.RM.GetString("Main_Workers_cb_sector")));
            gcb_sector.DataSource = list;
            gcb_sector.DisplayMember = "Name";
            gcb_sector.ValueMember = "Id";
        }

        private void FillWorkers (List<SuperShopDatabase.Entity.Worker> workers)
        {
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

            gdgv_workers.DataSource = data.ToList();
            gdgv_workers.Columns[0].Visible = false;
        }

        private void gdgv_workers_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int workerId = int.Parse(gdgv_workers.CurrentRow.Cells[0].Value.ToString());
            WorkerView view = new WorkerView();
            view.Worker = workerDAO.GetWorkerById(workerId);
            view.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Clear();
            MainForm.Instance.pnl_windows.Controls.Add(view);
        }

        private void gcb_sector_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (gcb_sector.SelectedIndex == 0)
                FillWorkers(workerDAO.GetAll());
            else
            {
                var sectors = workSectorDAO.GetAll();
                var data = from sector in sectors
                           select new
                           {
                               sector.Id,
                               sector.Name
                           };
                gdgv_sidebar.DataSource = data.ToList();
                gdgv_sidebar.Columns[0].Visible = false;
            }
        }

        private void gdgv_sidebar_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
            FillWorkers(workerDAO.GetAllBySector(workSectorDAO.GetWorkSectorById(id)));
        }

        private void gbtn_remove_Click (object sender, EventArgs e)
        {
            if (gcb_sector.SelectedIndex == 1)
            {
                DialogResult dt =
                    MessageBox.Show(LanguageConfig.RM.GetString("Main_SureRemove"),
                    LanguageConfig.RM.GetString("Main_Remove"), MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
                    workSectorDAO.RemoveWorkSector(workSectorDAO.GetWorkSectorById(id));
                    MainForm.Instance.gbtn_workers.PerformClick();
                }
            }
        }

        private void gbtn_edit_Click (object sender, EventArgs e)
        {
            if (gcb_sector.SelectedIndex == 1)
            {
                int id = int.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
                WorkSectorEdit edit = new WorkSectorEdit();
                edit.sector = workSectorDAO.GetWorkSectorById(id);
                edit.Dock = DockStyle.Fill;
                MainForm.Instance.pnl_windows.Controls.Clear();
                MainForm.Instance.pnl_windows.Controls.Add(edit);
            }
        }

        private void gbtn_searchByName_Click (object sender, EventArgs e)
        {
            FillWorkers(workerDAO.GetAllByNameAndSurnameAndFatherName(gtb_searchByName.Text, gtb_searchBySurname.Text,
                gtb_searchByFatherName.Text));
        }

        private void gtb_searchByName_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_searchByName.PerformClick();
        }

        private void gtb_searchBySurname_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_searchByName.PerformClick();
        }

        private void gtb_searchByFatherName_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_searchByName.PerformClick();
        }

        class Specify
        {
            public Specify (string id, string name)
            {
                Id = id;
                Name = name;
            }

            public string Id { get; set; }
            public string Name { get; set; }
        }
    }
}
