using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDesktop.Properties;

namespace SuperShopDesktop.Main
{
    public partial class TopBorder : UserControl
    {
        private MainAdmin mainAdmin;

        public TopBorder (MainAdmin mainAdmin)
        {
            InitializeComponent();

            this.mainAdmin = mainAdmin;
        }

        private void gbtn_close_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbtn_maximize_Click (object sender, EventArgs e)
        {
            if (mainAdmin.WindowState == FormWindowState.Maximized)
            {
                mainAdmin.WindowState = FormWindowState.Normal;
                gbtn_maximize.Image = Resources.maximize;
            }
            else
            {
                mainAdmin.WindowState = FormWindowState.Maximized;
                gbtn_maximize.Image = Resources.normalize;
            }
        }

        private void gbtn_minimize_Click (object sender, EventArgs e)
        {
            mainAdmin.WindowState = FormWindowState.Minimized;
        }
    }
}
