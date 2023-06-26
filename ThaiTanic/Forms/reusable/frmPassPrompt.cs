using Guna.UI2.WinForms;
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

namespace ThaiTanic.Forms.Reusable
{
    public partial class frmPassPrompt : Form
    {
        private readonly User _LoggedInUser;

        public string TextPassword
        {
            get 
            {
                return txtPassword.Text;
            }
        }

        public frmPassPrompt(User loggedInUser)
        {
            InitializeComponent();

            _LoggedInUser = loggedInUser;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = User.AuthUser(_LoggedInUser.Username, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Wrong Password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
