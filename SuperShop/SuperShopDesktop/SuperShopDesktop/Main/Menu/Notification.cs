using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using SuperShopDesktop.Properties;

namespace SuperShopDesktop.Main.Menu
{
    public partial class Notification : UserControl
    {
        public static List<string> Notifications = new List<string>();

        public Notification ()
        {
            InitializeComponent();

            Notifications.Add("Notification 1");
            Notifications.Add("Notification 2");
        }

        private void Notification_Load (object sender, EventArgs e)
        {
            Notifications.ForEach((notification) =>
           {
               pnl_notification.Controls.Add(GetPanel(notification));
           });
        }

        private Panel GetPanel (string notification)
        {
            Panel panel = new Panel()
            {
                BackColor = Color.FromArgb(203, 215, 240),
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                MinimumSize = new Size(0, 30),
                Dock = DockStyle.Top
            };
            GunaButton button = GetButton();
            Label label = GetLabel(notification);

            button.Click += delegate (object sender, EventArgs e)
            {
                pnl_notification.Controls.Remove(panel);
            };
            panel.Controls.Add(label);
            panel.Controls.Add(button);

            return panel;
        }

        private GunaButton GetButton ()
        {
            GunaButton button = new GunaButton()
            {
                BackColor = Color.Transparent,
                Image = Resources.remove,
                Size = new Size(42, 42),
                Dock = DockStyle.Right
            };
            return button;
        }

        private Label GetLabel (string data)
        {
            Label label = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Text = data,
                Dock = DockStyle.Fill
            };
            return label;
        }
    }
}
