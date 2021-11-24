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
using SuperShopDatabase.Entity;
using SuperShopDatabase.Config;

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class WorkSectorEdit : UserControl
    {
        private IWorkSectorDAO workSectorDAO;

        public WorkSector sector;

        public WorkSectorEdit ()
        {
            InitializeComponent();

            workSectorDAO = Context.GetWorkSectorDAO();
        }

        private void WorkSectorEdit_Load (object sender, EventArgs e)
        {
            if (sector != null)
                gtb_name.Text = sector.Name;
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            if (sector == null)
                sector = new WorkSector();

            sector.Name = gtb_name.Text;

            if (workSectorDAO.GetWorkSectorById(sector.Id) != null)
                workSectorDAO.UpdateWorkSector(sector);
            else
                workSectorDAO.AddWorkSector(sector);

            Workers workers = new Workers();
            workers.Dock = DockStyle.Fill;
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            MainAdmin.Instance.pnl_windows.Controls.Add(workers);
        }
    }
}
