using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiTanic.Entities;

namespace ThaiTanic.Forms.admin
{
    public partial class frmManageUsers : Form
    {
        private readonly string _Username;
        private readonly string _Password;

        public frmManageUsers(string username, string password)
        {
            InitializeComponent();

            _Username = username;
            _Password = password;

            cbUserRole.Enabled = false;

            string[] role = new string[] { "user", "admin" };
            cbUserRole.Items.AddRange(role);
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cbUsers.Items.AddRange(User.GetAllUsers().Where(user => user.Username != _Username).ToArray());
        }

        private void cbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUsers.SelectedItem == null) return;

            var selectedUser = cbUsers.SelectedItem as User;
            cbUserRole.SelectedIndex = selectedUser.Role == UserRole.Admin ? 1 : 0;

            cbUserRole.Enabled = true;
        }

        private void cbUserRole_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUserRole.SelectedItem == null) return;

            var selectedUser = cbUsers.SelectedItem as User;

            selectedUser.UpdateRole(cbUserRole.SelectedItem as string == "admin" ? UserRole.Admin : UserRole.User, _Username, _Password);
        }
    }
}
