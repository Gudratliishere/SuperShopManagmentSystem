using Guna.UI.WinForms;
using SuperShopDesktop.DesktopConfiguration;
using SuperShopDesktop.Language;
using SuperShopDesktop.Login;
using SuperShopDesktop.Login.SignIn;
using SuperShopDesktop.Login.SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopDesktop
{
    public partial class MainLogin : Form
    {
        public static MainLogin Instance;

        private Color buttonSelectedColor = Color.FromArgb(190, 153, 225);
        private Color buttonColor = Color.FromArgb(100, 153, 225);

        private GunaButton selectedSignButton = null;
        private GunaButton selectedLoginButton = null;

        public MainLogin ()
        {
            InitializeComponent();

            Instance = this;
        }

        private void Main_Load (object sender, EventArgs e)
        {
            LoadControlTexts();
            selectedSignButton = gbtn_signin;
            selectedLoginButton = gbtn_admin;

            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(LoginPanelManager.GetSigninAdminPanel());
        }

        private void LoadControlTexts ()
        {
            gbtn_signin.Text = LanguageConfig.RM.GetString("Login_MainLogin_gbtn_signin");
            gbtn_signup.Text = LanguageConfig.RM.GetString("Login_MainLogin_gbtn_signup");
            gbtn_exit.Text = LanguageConfig.RM.GetString("Login_MainLogin_gbtn_exit");
            gbtn_setting.Text = LanguageConfig.RM.GetString("Login_MainLogin_gbtn_setting");
        }

        private void gbtn_admin_MouseEnter (object sender, EventArgs e)
        {
            gbtn_admin.Width = 115;
        }

        private void gbtn_admin_MouseLeave (object sender, EventArgs e)
        {
            gbtn_admin.Width = 35;
        }

        private void gbtn_operator_MouseEnter (object sender, EventArgs e)
        {
            gbtn_operator.Width = 115;
        }

        private void gbtn_operator_MouseLeave (object sender, EventArgs e)
        {
            gbtn_operator.Width = 35;
        }

        private void gbtn_exit_MouseEnter (object sender, EventArgs e)
        {
            gbtn_exit.Width = 115;
        }

        private void gbtn_exit_MouseLeave (object sender, EventArgs e)
        {
            gbtn_exit.Width = 35;
        }

        private void gbtn_exit_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeSelectedSignButtonColor (GunaButton button)
        {
            selectedSignButton.BaseColor = buttonColor;
            button.BaseColor = buttonSelectedColor;
            selectedSignButton = button;
        }

        private void ChangeSelectedLoginButtonColor (GunaButton button)
        {
            selectedLoginButton.BaseColor = buttonColor;
            button.BaseColor = buttonSelectedColor;
            selectedLoginButton = button;
        }

        private void gbtn_signin_Click (object sender, EventArgs e)
        {
            ChangeSelectedSignButtonColor(gbtn_signin);

            pnl_main.Controls.Clear();
            if (selectedLoginButton.Tag.Equals("admin"))
                pnl_main.Controls.Add(LoginPanelManager.GetSigninAdminPanel());
            else
                pnl_main.Controls.Add(LoginPanelManager.GetSigninOperatorPanel());
        }

        private void gbtn_signup_Click (object sender, EventArgs e)
        {
            ChangeSelectedSignButtonColor(gbtn_signup);

            pnl_main.Controls.Clear();
            if (selectedLoginButton.Tag.Equals("admin"))
                pnl_main.Controls.Add(LoginPanelManager.GetSignupAdminPanel());
            else
                pnl_main.Controls.Add(LoginPanelManager.GetSignupOperatorPanel());
        }

        private void gbtn_admin_Click (object sender, EventArgs e)
        {
            ChangeSelectedLoginButtonColor(gbtn_admin);

            pnl_main.Controls.Clear();
            if (selectedSignButton.Tag.Equals("signin"))
                pnl_main.Controls.Add(LoginPanelManager.GetSigninAdminPanel());
            else
                pnl_main.Controls.Add(LoginPanelManager.GetSignupAdminPanel());
        }

        private void gbtn_operator_Click (object sender, EventArgs e)
        {
            ChangeSelectedLoginButtonColor(gbtn_operator);

            pnl_main.Controls.Clear();
            if (selectedSignButton.Tag.Equals("signin"))
                pnl_main.Controls.Add(LoginPanelManager.GetSigninOperatorPanel());
            else
                pnl_main.Controls.Add(LoginPanelManager.GetSignupOperatorPanel());
        }

        private void gbtn_setting_MouseEnter (object sender, EventArgs e)
        {
            gbtn_setting.Width = 115;
        }

        private void gbtn_setting_MouseLeave (object sender, EventArgs e)
        {
            gbtn_setting.Width = 35;
        }

        private void gbtn_setting_Click (object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
