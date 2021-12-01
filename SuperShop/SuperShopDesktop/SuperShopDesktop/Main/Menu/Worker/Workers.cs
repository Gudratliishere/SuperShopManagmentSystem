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
        private static readonly Logger _log = new Logger("Workers");

        private IWorkerDAO workerDAO;
        private IWorkSectorDAO workSectorDAO;

        private int selectedProductRow = 0;

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
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
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
                    var sector = workSectorDAO.GetWorkSectorById(id);
                    workerDAO.GetAllBySector(sector).ForEach((worker) =>
                    {
                        workerDAO.RemoveWorker(worker);
                    });
                    workSectorDAO.RemoveWorkSector(sector);
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

        private void gdgv_workers_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = gdgv_workers.HitTest(e.X, e.Y);
                gdgv_workers.ClearSelection();
                if (hit.RowIndex >= 0)
                {
                    gdgv_workers.Rows[hit.RowIndex].Selected = true;
                    selectedProductRow = hit.RowIndex;
                    GunaButton button = GenerateRemoveButton(e.Location, RemoveWorker);
                    button.MouseLeave += delegate (object sender2, EventArgs e2)
                    {
                        button.Visible = false;
                    };
                    gdgv_workers.Controls.Add(button);
                }
            }
        }

        private void RemoveWorker ()
        {
            try
            {
                int id = int.Parse(gdgv_workers.Rows[selectedProductRow].Cells[0].Value.ToString());
                workerDAO.RemoveWorker(workerDAO.GetWorkerById(id));
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private GunaButton GenerateRemoveButton (Point point, Action action)
        {
            GunaButton button = new GunaButton()
            {
                Image = null,
                Text = LanguageConfig.RM.GetString("Main_Remove"),
                Size = new Size(63, 23),
                Location = point,
                TabIndex = 1
            };
            button.Click += delegate (object sender, EventArgs e)
            {
                DialogResult dt =
                MessageBox.Show(LanguageConfig.RM.GetString("Main_SureRemove"),
                    LanguageConfig.RM.GetString("Main_Remove"), MessageBoxButtons.YesNo);
                if (dt == DialogResult.Yes)
                {
                    action.Invoke();
                    MainForm.Instance.gbtn_workers.PerformClick();
                }
            };
            return button;
        }
    }
}
