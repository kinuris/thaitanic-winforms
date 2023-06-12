using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.Forms
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile();
            frmAccountProfile.TopLevel = false;
            frmAccountProfile.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountProfile);
            frmAccountProfile.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();

            frmAccountProfile frmAccountProfile = new frmAccountProfile();
            frmAccountProfile.TopLevel = false;
            frmAccountProfile.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountProfile);
            frmAccountProfile.Show();

            lblAccountLabel.Text = "User Account";
        }

        private void btnBillingAddress_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();

            frmAccountBillingAddress frmAccountBillingAddress = new frmAccountBillingAddress();
            frmAccountBillingAddress.TopLevel = false;
            frmAccountBillingAddress.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmAccountBillingAddress);
            frmAccountBillingAddress.Show();

            lblAccountLabel.Text = "Billing Address";
        }
    }
}
