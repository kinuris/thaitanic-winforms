using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiTanic.Entities;
using ThaiTanic.State;

namespace ThaiTanic.Forms
{
    public partial class frmDashboard : Form
    {
        private readonly User _LoggedInUser;
        private readonly Cart _Cart;

        public frmDashboard(User user)
        {
            InitializeComponent();

            _LoggedInUser = user;
            _Cart = new Cart(user);

            try
            {
                _Cart.Deserialize();
            }
            catch (FileNotFoundException)
            {
                // PASS
            }

            frmMenu frmMenu = new frmMenu(_LoggedInUser, DisplayInDashBoardFormHook, AddCartEntry, _Cart.SubtractCartEntry, _Cart.AddEntriesToDGV, _Cart.Clear, _Cart.Entries)
            {
                TopLevel = false,
            };

            DisplayInDashBoardFormHook(frmMenu);
        }

        private void AddCartEntry(Items item, int quantity)
        {
            _Cart.AddCartEntry(item.Id, quantity);
        }

        private void DisplayInDashBoardFormHook(Form form)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DisplayInDashBoardFormHook(new frmMenu(_LoggedInUser, DisplayInDashBoardFormHook, AddCartEntry, _Cart.SubtractCartEntry, _Cart.AddEntriesToDGV, _Cart.Clear, _Cart.Entries)
            {
                TopLevel = false,
            });
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            var frmDelivery = new frmDelivery
            {
                TopLevel = false
            };

            DisplayInDashBoardFormHook(frmDelivery);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _Cart.Serialize();
                Close();
            }
        }
    }
}
