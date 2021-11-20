﻿using System;
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

namespace SuperShopDesktop.Login.SignUp
{
    public partial class SignupOperator : UserControl
    {
        private IOperatorDAO operatorDAO;

        public SignupOperator ()
        {
            InitializeComponent();

            operatorDAO = Context.GetOperatorDAO();
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
                GiveMessage("Please fill information fully!", false);
            else if (operatorDAO.GetOperatorByEmail(email) != null)
                GiveMessage("Operator already exists with this email!", false);
            else
            {
                glbl_errorMessage.Visible = false;

                if (operatorDAO.GetOperatorByPhone(phone) != null)
                    GiveMessage("Operator already exists with this phone!", false);
                else
                {
                    glbl_errorMessage.Visible = false;

                    if (!password.Equals(confirmPassword))
                        GiveMessage("Password doesn't match!", false);
                    else
                    {
                        glbl_errorMessage.Visible = false;

                        Operator oper = new Operator();
                        oper.Name = name;
                        oper.Surname = surname;
                        oper.Email = email;
                        oper.Phone = phone;
                        oper.Password = password;

                        operatorDAO.AddOperator(oper);

                        GiveMessage("Successfully created!", true);
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
    }
}
