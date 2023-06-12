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
    public partial class frmManageItems : Form
    {
        public frmManageItems()
        {
            InitializeComponent();
        }

        private void frmManageItems_Load(object sender, EventArgs e)
        {
            frmItemAdd frmItemAdd = new frmItemAdd();
            frmItemAdd.TopLevel = false;
            frmItemAdd.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemAdd);
            frmItemAdd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlManageItemsContainer.Controls.Clear();

            frmItemAdd frmItemAdd = new frmItemAdd();
            frmItemAdd.TopLevel = false;
            frmItemAdd.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemAdd);
            frmItemAdd.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlManageItemsContainer.Controls.Clear();

            frmItemUpdate frmItemUpdate = new frmItemUpdate();
            frmItemUpdate.TopLevel = false;
            frmItemUpdate.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemUpdate);
            frmItemUpdate.Show();
        }
    }
}
