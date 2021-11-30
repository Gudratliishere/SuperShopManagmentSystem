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
    public partial class SignupOperator : UserControl
    {
        private IOperatorDAO operatorDAO;
        private IAdminDAO adminDAO;

        public SignupOperator ()
        {
            InitializeComponent();

            operatorDAO = Context.GetOperatorDAO();
            adminDAO = Context.GetAdminDAO();
        }

        private void gchb_showpass_CheckedChanged (object sender, EventArgs e)
        {
            gtb_password.PasswordChar = (gtb_password.PasswordChar == '\0') ? '●' : '\0';
            gtb_confirmPassword.PasswordChar = (gtb_confirmPassword.PasswordChar == '\0') ? '●' : '\0';
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
                GiveMessage(LanguageConfig.RM.GetString("Login_SignupOper_fullInformation"), false);
            else if (operatorDAO.GetOperatorByEmail(email) != null)
                GiveMessage(LanguageConfig.RM.GetString("Login_SignupOper_operExistEmail"), false);
            else
            {
                glbl_errorMessage.Visible = false;

                if (adminDAO.GetActiveAdmin() == null)
                    GiveMessage(LanguageConfig.RM.GetString("Login_Operator_AdminNotExist"), false);
                else
                {
                    if (operatorDAO.GetOperatorByPhone(phone) != null)
                    {
                        GiveMessage(LanguageConfig.RM.GetString("Login_SignupOper_operExistPhone"), false);
                        gtb_email.BorderColor = Color.Red;
                    }
                    else
                    {
                        if (!email.Contains("@"))
                        {
                            GiveMessage(LanguageConfig.RM.GetString("Login_Signup_validEmail"), false);
                            gtb_email.BorderColor = Color.Red;
                        }
                        else
                        {
                            gtb_email.BorderColor = Color.Silver;
                            glbl_errorMessage.Visible = false;

                            if (!password.Equals(confirmPassword))
                            {
                                GiveMessage(LanguageConfig.RM.GetString("Login_Signup_passwordNotMatch"), false);
                                gtb_password.BorderColor = Color.Red;
                                gtb_confirmPassword.BorderColor = Color.Red;
                            }
                            else
                            {
                                gtb_password.BorderColor = Color.Silver;
                                gtb_confirmPassword.BorderColor = Color.Silver;

                                EmailConfirmation confirmation = new EmailConfirmation();
                                confirmation.Email = email;
                                confirmation.ShowDialog();
                                confirmation.Close();
                                if (EmailConfirmation.Result)
                                {
                                    EmailConfirmation.Result = false;
                                    EmailConfirmation adminConfirmation = new EmailConfirmation();
                                    adminConfirmation.Email = adminDAO.GetActiveAdmin().Email;
                                    adminConfirmation.AdminConfirmation = true;
                                    adminConfirmation.ShowDialog();
                                    adminConfirmation.Close();
                                    if (EmailConfirmation.Result)
                                    {
                                        glbl_errorMessage.Visible = false;

                                        Operator oper = new Operator();
                                        oper.Name = name;
                                        oper.Surname = surname;
                                        oper.Email = email;
                                        oper.Phone = phone;
                                        oper.Password = Cryption.Encrypt(password);

                                        operatorDAO.AddOperator(oper);

                                        GiveMessage(LanguageConfig.RM.GetString("Login_Signup_success"), true);
                                    }
                                    else
                                        GiveMessage(LanguageConfig.RM.GetString("Login_EmailConfirmation_wrongCode"), false);
                                }
                                else
                                    GiveMessage(LanguageConfig.RM.GetString("Login_EmailConfirmation_wrongCode"), false);
                            }
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

        private void SignupOperator_Load (object sender, EventArgs e)
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
