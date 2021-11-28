using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDatabase.Config;
using SuperShopDesktop.DesktopConfiguration;
using SuperShopDesktop.Login;

namespace SuperShopDesktop
{
    public partial class Settings : Form
    {
        public Settings ()
        {
            InitializeComponent();
        }

        private void gchb_show_CheckedChanged (object sender, EventArgs e)
        {
            gtb_pass.PasswordChar = (gtb_pass.PasswordChar == '\0') ? '●' : '\0';
        }

        private void gbtn_save_Click (object sender, EventArgs e)
        {
            gpbar_save.Visible = true;
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        private void gbtn_close_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Load (object sender, EventArgs e)
        {
            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            glbl_user.Text = LanguageConfig.RM.GetString("Login_Settings_glbl_user");
            glbl_pass.Text = LanguageConfig.RM.GetString("Login_Settings_glbl_pass");
            glbl_database.Text = LanguageConfig.RM.GetString("Login_Settings_glbl_database");
            gbtn_save.Text = LanguageConfig.RM.GetString("Login_Settings_gbtn_save");
            gchb_show.Text = LanguageConfig.RM.GetString("Login_Settings_gchb_show");
        }

        private void backgroundWorker_DoWork (object sender, DoWorkEventArgs e)
        {
            Connection connection = new Connection();
            connection.Host = gtb_host.Text.Trim();
            connection.Port = gtb_port.Text.Trim();
            connection.Username = gtb_user.Text.Trim();
            connection.Password = gtb_pass.Text.Trim();
            connection.Database = gtb_database.Text.Trim();
            connection.CryptPower = 4;

            Configuration config = Configuration.GetConfig();
            config.WriteConnection(connection);
            config.ResetConnection();

            config.CreateDatabase();
            Invoke((MethodInvoker)(() => Close()));
            LoginPanelManager.Clear();
            Context.Clear();
        }

        private void backgroundWorker_ProgressChanged (object sender, ProgressChangedEventArgs e)
        {
            gpbar_save.Value = e.ProgressPercentage;
        }

        private void gtb_host_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_port.Focus();
        }

        private void gtb_port_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_user.Focus();
        }

        private void gtb_user_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_pass.Focus();
        }

        private void gtb_pass_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gtb_database.Focus();
        }

        private void gtb_database_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_save.PerformClick();
        }
    }
}
