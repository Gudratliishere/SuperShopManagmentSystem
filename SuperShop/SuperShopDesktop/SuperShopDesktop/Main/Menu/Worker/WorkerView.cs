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

namespace SuperShopDesktop.Main.Menu.Worker
{
    public partial class WorkerView : UserControl
    {
        public SuperShopDatabase.Entity.Worker Worker { get; set; }
        public Workers WorkersPanel { get; set; }

        public WorkerView ()
        {
            InitializeComponent();
        }

        private void WorkerView_Load (object sender, EventArgs e)
        {
            gpb_profilePhoto.Image = Image.FromFile(Worker.ImagePath);
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

        private void gbtn_back_Click (object sender, EventArgs e)
        {
            WorkersPanel.pnl_body.Controls.Clear();
            WorkersPanel.pnl_body.Controls.Add(WorkersPanel.Gunadgv);
        }
    }
}
