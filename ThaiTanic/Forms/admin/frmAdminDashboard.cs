using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            frmManageItems frmManageItems = new frmManageItems();
            frmManageItems.TopLevel = false;
            frmManageItems.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmManageItems);
            frmManageItems.Show();
        }
    }
}
