using System;
using System.Windows.Forms;

namespace ThaiTanic.Forms.admin
{
    enum AdminDashboardOptions
    {
        ManageItems,
        ManageOrders,
        ManageUsers
    }

    public partial class frmAdminDashboard : Form
    {
        private readonly string _Username;
        private readonly string _Password;   
        private AdminDashboardOptions _SelectedOption;

        public frmAdminDashboard(string username, string password)
        {
            InitializeComponent();

            _Username = username;
            _Password = password;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            _SelectedOption = AdminDashboardOptions.ManageItems;

            frmManageItems frmManageItems = new frmManageItems(_Username, _Password);
            frmManageItems.TopLevel = false;
            frmManageItems.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frmManageItems);
            frmManageItems.Show();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            if (_SelectedOption == AdminDashboardOptions.ManageOrders) return;
            
            _SelectedOption = AdminDashboardOptions.ManageOrders;

            frmManageOrders frmManageOrders = new frmManageOrders();
            frmManageOrders.TopLevel = false;
            frmManageOrders.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frmManageOrders);
            frmManageOrders.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            if (_SelectedOption == AdminDashboardOptions.ManageItems) return;

            _SelectedOption = AdminDashboardOptions.ManageItems;

            frmManageItems frmManageItems = new frmManageItems(_Username, _Password);
            frmManageItems.TopLevel = false;
            frmManageItems.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frmManageItems);
            frmManageItems.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (_SelectedOption == AdminDashboardOptions.ManageUsers) return;

            _SelectedOption = AdminDashboardOptions.ManageUsers;

            frmManageUsers frmManageUsers = new frmManageUsers(_Username, _Password);
            frmManageUsers.TopLevel = false;
            frmManageUsers.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frmManageUsers);
            frmManageUsers.Show();
        }
    }
}
