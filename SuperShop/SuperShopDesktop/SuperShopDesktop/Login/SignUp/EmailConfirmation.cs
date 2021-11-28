using SuperShopDesktop.DesktopConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopDesktop.Login.SignUp
{
    public partial class EmailConfirmation : Form
    {
        private readonly string username = "gudratlicompany@gmail.com";
        private readonly string password = "ziqqeshzomumybpl";

        private string email;
        private string code;

        public string Email { set => email = value; }

        public static bool Result = false; 
        public bool AdminConfirmation { get; set; }

        public EmailConfirmation ()
        {
            InitializeComponent();
        }

        private void EmailConfirmation_Load (object sender, EventArgs e)
        {
            LoadControlTexts();
            code = new Random().Next(1000, 9999).ToString();
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        private void LoadControlTexts ()
        {
            if (AdminConfirmation)
                lbl_info.Text = LanguageConfig.RM.GetString("Login_EmailConfirmation_lbl_infoAdmin");
            else
                lbl_info.Text = LanguageConfig.RM.GetString("Login_EmailConfirmation_lbl_info");
        }

        private void SendEmail ()
        {
            SmtpClient smtp;
            using (smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(username, password);

                var subject = "Email confirmation";
                var body = "Code: " + code;

                try
                {
                    smtp.Send(username, email, subject, body);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            };
        }

        private void gbtn_ok_Click (object sender, EventArgs e)
        {
            Result = gtb_code.Text.Trim().Equals(code);
            Close();
        }

        private void backgroundWorker_DoWork (object sender, DoWorkEventArgs e)
        {
            SendEmail();
        }

        private void gtb_code_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_ok.PerformClick();
        }
    }
}
