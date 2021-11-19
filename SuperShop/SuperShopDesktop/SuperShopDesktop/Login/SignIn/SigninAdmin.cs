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
using SuperShopDatabase.Entity;

namespace SuperShopDesktop.Login.SignIn
{
    public partial class SigninAdmin : UserControl
    {
        private IAdminDAO adminDAO;

        public SigninAdmin ()
        {
            InitializeComponent();
        }

        private void gchb_showpass_CheckedChanged (object sender, EventArgs e)
        {
            gtb_password.PasswordChar = (gtb_password.PasswordChar == '\0') ? '●' : '\0';
        }

        private void btn_signin_Click (object sender, EventArgs e)
        {
            adminDAO = Context.GetAdminDAO();

            string email = gtb_email.Text.Trim();
            string password = gtb_password.Text.Trim();
            //password = Cryption.Encrypt(password);

            Admin admin = adminDAO.GetAdminByEmail(email);
            if (admin == null)
                GiveErrorMessage("Admin doesn't exist with this email!");
            else
            {
                glbl_errorMessage.Visible = false;

                if (!admin.Password.Equals(password))
                    GiveErrorMessage("Password is wrong!");
                else
                {

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
