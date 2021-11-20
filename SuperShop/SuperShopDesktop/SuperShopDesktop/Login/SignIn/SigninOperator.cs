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
                GiveErrorMessage("Operator doesn't exist with this email!");
                gtb_email.BorderColor = Color.Red;
            }
            else
            {

                glbl_errorMessage.Visible = false;
                gtb_email.BorderColor = Color.Silver;

                if (!oper.Password.Equals(password))
                {
                    GiveErrorMessage("Password is wrong!");
                    gtb_password.BorderColor = Color.Red;
                }
                else
                {
                    gtb_password.BorderColor = Color.Silver;
                }
            }
        }

        private void GiveErrorMessage (string message)
        {
            glbl_errorMessage.Text = message;
            glbl_errorMessage.Visible = true;
        }
    }
}
