using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDesktop.Properties;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Config;
using SuperShopDatabase.Entity;

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class WorkerEdit : UserControl
    {
        public SuperShopDatabase.Entity.Worker Worker { get; set; }

        private IWorkSectorDAO sectorDAO;
        private IWorkerDAO workerDAO;

        private string imagePath;

        public WorkerEdit ()
        {
            InitializeComponent();

            sectorDAO = Context.GetWorkSectorDAO();
            workerDAO = Context.GetWorkerDAO();
        }

        private void gbtn_gender_Click (object sender, EventArgs e)
        {
            pnl_gender.Visible = !pnl_gender.Visible;
        }

        private void gbtn_genderMale_Click (object sender, EventArgs e)
        {
            gbtn_gender.Image = Resources.male;
            gbtn_gender.Tag = "male";
            pnl_gender.Visible = false;
        }

        private void gbtn_genderFemale_Click (object sender, EventArgs e)
        {
            gbtn_gender.Image = Resources.female;
            gbtn_gender.Tag = "female";
            pnl_gender.Visible = false;
        }

        private void WorkerEdit_Load (object sender, EventArgs e)
        {
            var sectors = sectorDAO.GetAll();
            var sectorNames = new List<string>();
            foreach (WorkSector sector in sectors)
                sectorNames.Add(sector.Name);

            gcb_sector.DataSource = sectorNames;

            if (Worker != null)
            {
                try
                {
                    gpb_profilePhoto.Image = Image.FromFile(Worker.ImagePath);
                    imagePath = Worker.ImagePath;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                gtb_name.Text = Worker.Name;
                gtb_surname.Text = Worker.Surname;
                gtb_fatherName.Text = Worker.FatherName;
                gtb_email.Text = Worker.Email;
                gtb_phone.Text = Worker.Phone;
                gtb_address.Text = Worker.Address;
                gtb_startTime.Text = Worker.StartTime;
                gtb_endTime.Text = Worker.EndTime;
                gbtn_gender.Image = (Worker.Gender.Equals("male")) ? Resources.male : Resources.female;
                gdtp_birthday.Value = Worker.Birthday;
                gcb_sector.SelectedItem = Worker.Sector.Name;
                gnum_wage.Value = Worker.Wage;
            }
        }

        private void gpb_profilePhoto_MouseDoubleClick (object sender, MouseEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = @"workers\images\" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
                System.IO.File.Copy(fileDialog.FileName, imagePath);
                gpb_profilePhoto.Image = Image.FromFile(imagePath);
            }
        }

        private void gbtn_back_Click (object sender, EventArgs e)
        {
            MainAdmin.Instance.pnl_windows.Controls.Clear();
            if (Worker != null)
            {
                WorkerView view = new WorkerView();
                view.Worker = Worker;
                view.Dock = DockStyle.Fill;
                MainAdmin.Instance.pnl_windows.Controls.Add(view);
            }
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            if (Worker == null)
                Worker = new SuperShopDatabase.Entity.Worker();

            Worker.Name = gtb_name.Text;
            Worker.Surname = gtb_surname.Text;
            Worker.FatherName = gtb_fatherName.Text;
            Worker.Email = gtb_email.Text;
            Worker.Phone = gtb_phone.Text;
            Worker.Address = gtb_address.Text;
            Worker.StartTime = gtb_startTime.Text;
            Worker.EndTime = gtb_endTime.Text;
            Worker.Gender = gbtn_gender.Tag.ToString();
            Worker.ImagePath = imagePath;
            Worker.Birthday = gdtp_birthday.Value;
            Worker.Wage = (int) gnum_wage.Value;
            Worker.Sector = sectorDAO.GetWorkSectorByName(gcb_sector.SelectedItem.ToString());

            if (workerDAO.GetWorkerById(Worker.Id) != null)
                workerDAO.UpdateWorker(Worker);
            else
                workerDAO.AddWorker(Worker);
        }
    }
}
