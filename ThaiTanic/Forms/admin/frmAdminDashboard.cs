using System;
using System.Windows.Forms;

namespace ThaiTanic.Forms.admin
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            //frmManageItems frmManageItems = new frmManageItems();
            //frmManageItems.TopLevel = false;
            //frmManageItems.Dock = DockStyle.Fill;
            //pnlContainer.Controls.Add(frmManageItems);
            //frmManageItems.Show();

            frmManageOrders frmManageOrders = new frmManageOrders();
            frmManageOrders.TopLevel = false;
            frmManageOrders.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmManageOrders);
            frmManageOrders.Show();
        }
    }
}
