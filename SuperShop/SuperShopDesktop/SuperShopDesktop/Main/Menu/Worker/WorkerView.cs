using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDatabase.Entity;
using SuperShopDesktop.Properties;
using SuperShopDesktop.DesktopConfiguration;
using SuperShopDatabase.Config;

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class WorkerView : UserControl
    {
        private static readonly Logger _log = new Logger("EmailConfirmation");

        public SuperShopDatabase.Entity.Worker Worker { get; set; }

        public WorkerView ()
        {
            InitializeComponent();
        }

        private void WorkerView_Load (object sender, EventArgs e)
        {
            LoadControlTexts();

            try
            {
                gpb_profilePhoto.Image = Image.FromFile(Worker.ImagePath);
            } catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
            }

            gpb_profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_nameSurname.Text = Worker.Name + " " + Worker.Surname + " " + Worker.FatherName;

            pb_gender.BackgroundImage = (Worker.Gender.Equals("male")) ? Resources.male : Resources.female;

            lbl_email.Text = Worker.Email;
            lbl_phone.Text = Worker.Phone;
            lbl_address.Text = Worker.Address;
            lbl_birthday.Text = Worker.Birthday.ToLongDateString();
            lbl_sector.Text = Worker.Sector.Name;
            lbl_wage.Text = Worker.Wage.ToString();
            lbl_startTime.Text = Worker.StartTime;
            lbl_endTime.Text = Worker.EndTime;
        }

        private void LoadControlTexts ()
        {
            lbl_contact.Text = LanguageConfig.RM.GetString("Main_WorkerView_lbl_contact");
            lbl_birthdayHeader.Text = LanguageConfig.RM.GetString("Main_WorkerView_lbl_birthdayHeader");
            lbl_sectorHeader.Text = LanguageConfig.RM.GetString("Main_WorkerView_lbl_sectorHeader");
            lbl_wageHeader.Text = LanguageConfig.RM.GetString("Main_WorkerView_lbl_wageHeader");
            lbl_workTimeHeader.Text = LanguageConfig.RM.GetString("Main_WorkerView_lbl_workTimeHeader");
        }

        private void gbtn_back_Click (object sender, EventArgs e)
        {
            MainForm.Instance.pnl_windows.Controls.Clear();
            var worker = new Workers();
            worker.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Add(worker);
        }

        private void gbtn_edit_Click (object sender, EventArgs e)
        {
            MainForm.Instance.pnl_windows.Controls.Clear();
            WorkerEdit edit = new WorkerEdit();
            edit.Worker = Worker;
            edit.Dock = DockStyle.Fill;
            MainForm.Instance.pnl_windows.Controls.Add(edit);
        }
    }
}
