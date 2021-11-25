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
using SuperShopDatabase.Entity;
using SuperShopDesktop.Main;
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Login.SignIn
{
    public partial class SigninOperator : UserControl
    {
        private IOperatorDAO operatorDAO;

        public SigninOperator ()
        {
            InitializeComponent();

            operatorDAO = Context.GetOperatorDAO();
        }

        private void gtb_email_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_password.Focus();
        }

        private void gtb_password_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_signin.PerformClick();
        }

        private void gbtn_signin_Click (object sender, EventArgs e)
        {
            var email = gtb_email.Text.Trim();
            var password = gtb_password.Text.Trim();

            Operator oper = operatorDAO.GetOperatorByEmail(email);
            if (oper == null)
            {
                GiveErrorMessage(LanguageConfig.RM.GetString("Login_SigninOperator_operatorNotExist"));
                gtb_email.BorderColor = Color.Red;
            }
            else
            {

                glbl_errorMessage.Visible = false;
                gtb_email.BorderColor = Color.Silver;

                if (!oper.Password.Equals(Cryption.Encrypt(password)))
                {
                    GiveErrorMessage(LanguageConfig.RM.GetString("Login_SigninOperator_passwordWrong"));
                    gtb_password.BorderColor = Color.Red;
                }
                else
                {
                    gtb_password.BorderColor = Color.Silver;

                    MainForm main = new MainForm();
                    MainForm.Session = 2;
                    main.Show();
                    MainLogin.Instance.Hide();
                }
            }
        }

        private void GiveErrorMessage (string message)
        {
            glbl_errorMessage.Text = message;
            glbl_errorMessage.Visible = true;
        }

        private void gchb_showpass_CheckedChanged (object sender, EventArgs e)
        {
            gtb_password.PasswordChar = (gtb_password.PasswordChar == '●') ? '\0' : '●';
        }

        private void SigninOperator_Load (object sender, EventArgs e)
        {
            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            glbl_email.Text = LanguageConfig.RM.GetString("Login_Signin_glbl_email");
            glbl_password.Text = LanguageConfig.RM.GetString("Login_Signin_glbl_password");
            glbl_forgotPassword.Text = LanguageConfig.RM.GetString("Login_Signin_glbl_forgetPassword");
            gbtn_signin.Text = LanguageConfig.RM.GetString("Login_Signin_gbtn_signin");
            gchb_showpass.Text = LanguageConfig.RM.GetString("Login_Signin_gchb_showpass");
        }
    }
}
