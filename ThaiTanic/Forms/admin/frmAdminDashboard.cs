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
        private readonly string _Username;
        private readonly string _Password;   

        public frmAdminDashboard(string username, string password)
        {
            InitializeComponent();

            _Username = username;
            _Password = password;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            frmManageItems frmManageItems = new frmManageItems(_Username, _Password);
            frmManageItems.TopLevel = false;
            frmManageItems.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmManageItems);
            frmManageItems.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
