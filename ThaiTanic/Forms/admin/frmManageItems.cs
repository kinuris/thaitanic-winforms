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
        private readonly string _Username;
        private readonly string _Password;

        public frmManageItems(string username, string password)
        {
            InitializeComponent();

            _Username = username;
            _Password = password;
        }

        private void frmManageItems_Load(object sender, EventArgs e)
        {
            frmItemAdd frmItemAdd = new frmItemAdd(_Username, _Password);
            frmItemAdd.TopLevel = false;
            frmItemAdd.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemAdd);
            frmItemAdd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlManageItemsContainer.Controls.Clear();

            frmItemAdd frmItemAdd = new frmItemAdd(_Username, _Password);
            frmItemAdd.TopLevel = false;
            frmItemAdd.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemAdd);
            frmItemAdd.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlManageItemsContainer.Controls.Clear();

            frmItemUpdate frmItemUpdate = new frmItemUpdate(_Username, _Password);
            frmItemUpdate.TopLevel = false;
            frmItemUpdate.Dock = DockStyle.Fill;
            pnlManageItemsContainer.Controls.Add(frmItemUpdate);
            frmItemUpdate.Show();
        }
    }
}
