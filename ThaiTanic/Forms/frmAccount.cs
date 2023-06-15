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

namespace ThaiTanic.Forms
{
    public partial class frmAccount : Form
    {
        private readonly User _LoggedInUser;
        private readonly Action<Form> _DisplayInDashboardFormHook;

        public frmAccount(User loggedInUser, Action<Form> displayInDashboardFormHook)
        {
            InitializeComponent();

            _LoggedInUser = loggedInUser;
            _DisplayInDashboardFormHook = displayInDashboardFormHook;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile(_LoggedInUser);
            frmAccountProfile.TopLevel = false;
            frmAccountProfile.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountProfile);
            frmAccountProfile.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();

            frmAccountProfile frmAccountProfile = new frmAccountProfile(_LoggedInUser);
            frmAccountProfile.TopLevel = false;
            frmAccountProfile.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountProfile);
            frmAccountProfile.Show();

            lblAccountLabel.Text = "User Account";
        }

        private void btnBillingAddress_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();

            frmAccountBillingAddress frmAccountBillingAddress = new frmAccountBillingAddress(_LoggedInUser, _DisplayInDashboardFormHook);
            frmAccountBillingAddress.TopLevel = false;
            frmAccountBillingAddress.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountBillingAddress);
            frmAccountBillingAddress.Show();

            lblAccountLabel.Text = "Billing Address";
        }
    }
}
