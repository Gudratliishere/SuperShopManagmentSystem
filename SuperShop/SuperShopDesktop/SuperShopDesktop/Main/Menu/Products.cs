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

namespace SuperShopDesktop.Main.Menu
{
    public partial class Products : UserControl
    {
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;
        //private IProduct

        public Products ()
        {
            InitializeComponent();

            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
        }

        private void gcb_specify_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (gcb_specify.SelectedIndex == 0)
            {
                var list = productCompanyDAO.GetAll();
                var data = from entity in list select new { entity.Id, entity.Name };
                gdgv_sidebar.DataSource = data.ToList();
                gdgv_sidebar.Columns[0].Visible = false;
            }
            else
            {
                var list = productKindDAO.GetAll();
                var data = from entity in list select new { entity.Id, entity.Name };
                gdgv_sidebar.DataSource = data.ToList();
                gdgv_sidebar.Columns[0].Visible = false;
            }
        }

        private void gdgv_sidebar_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(gdgv_sidebar.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
