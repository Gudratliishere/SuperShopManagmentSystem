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
using SuperShopDatabase.Entity;
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Login.SignUp
{
    public partial class SignupAdmin : UserControl
    {
        private IAdminDAO adminDAO;

        public SignupAdmin ()
        {
            InitializeComponent();

            adminDAO = Context.GetAdminDAO();
        }

        private void gchb_showpass_CheckedChanged (object sender, EventArgs e)
        {
            gtb_password.PasswordChar = (gtb_password.PasswordChar == '\0') ? '●' : '\0';
            gtb_confirmPassword.PasswordChar = (gtb_confirmPassword.PasswordChar == '\0') ? '●' : '\0';
        }

        private void gbtn_signup_Click (object sender, EventArgs e)
        {
            var name = gtb_name.Text.Trim();
            var surname = gtb_surname.Text.Trim();
            var email = gtb_email.Text.Trim();
            var phone = gtb_phone.Text.Trim();
            var password = gtb_password.Text.Trim();
            var confirmPassword = gtb_confirmPassword.Text.Trim();

            bool emptyTextBoxExists = false;
            foreach (Control control in Controls)
            {
                if (control is GunaTextBox)
                {
                    GunaTextBox gtb = control as GunaTextBox;
                    if (String.IsNullOrEmpty(gtb.Text.Trim()))
                    {
                        gtb.BorderColor = Color.Red;
                        emptyTextBoxExists = true;
                    }
                    else
                        gtb.BorderColor = Color.Silver;
                }
            }

            if (emptyTextBoxExists)
                GiveMessage(LanguageConfig.RM.GetString("Login_SignupAdmin_fullInformation"), false);
            else if (adminDAO.GetAdminByEmail(email) != null)
                GiveMessage(LanguageConfig.RM.GetString("Login_SignupAdmin_adminExistEmail"), false);
            else
            {
                glbl_errorMessage.Visible = false;

                if (adminDAO.GetAdminByPhone(phone) != null)
                    GiveMessage(LanguageConfig.RM.GetString("Login_SignupAdmin_adminExistPhone"), false);
                else
                {
                    if (!email.Contains("@"))
                    {
                        GiveMessage(LanguageConfig.RM.GetString("Login_Signup_validEmail"), false);
                    }
                    else
                    {
                        glbl_errorMessage.Visible = false;

                        if (!password.Equals(confirmPassword))
                            GiveMessage(LanguageConfig.RM.GetString("Login_Signup_passwordNotMatch"), false);
                        else
                        {
                            glbl_errorMessage.Visible = false;

                            Admin admin = new Admin();
                            admin.Name = name;
                            admin.Surname = surname;
                            admin.Email = email;
                            admin.Phone = phone;
                            admin.Password = Cryption.Encrypt(password);
                            admin.Status = true;

                            adminDAO.AddAdmin(admin);

                            GiveMessage(LanguageConfig.RM.GetString("Login_Signup_success"), true);
                        }
                    }
                }
            }

        }

        private void GiveMessage (string message, bool isSuccess)
        {
            glbl_errorMessage.Text = message;
            if (isSuccess)
                glbl_errorMessage.ForeColor = Color.Green;
            else
                glbl_errorMessage.ForeColor = Color.Red;
            glbl_errorMessage.Visible = true;
        }

        private void gtb_name_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_surname.Focus();
        }

        private void gtb_surname_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_email.Focus();
        }

        private void gtb_email_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_phone.Focus();
        }

        private void gtb_phone_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_password.Focus();
        }

        private void gtb_password_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_confirmPassword.Focus();
        }

        private void gtb_confirmPassword_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_signup.PerformClick();
        }

        private void SignupAdmin_Load (object sender, EventArgs e)
        {
            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            glbl_email.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_email");
            glbl_surname.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_surname");
            glbl_email.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_email");
            glbl_phone.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_phone");
            glbl_password.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_password");
            glbl_confirmPassword.Text = LanguageConfig.RM.GetString("Login_Signup_glbl_confirmPassword");
            gbtn_signup.Text = LanguageConfig.RM.GetString("Login_Signup_gbtn_signup");
            gchb_showpass.Text = LanguageConfig.RM.GetString("Login_Signup_gchb_showpass");
        }
    }
}
