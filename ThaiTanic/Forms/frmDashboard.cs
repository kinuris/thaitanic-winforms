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
    public enum DashBoardOptions
    {
        Menu,
        Delivery,
        Account
    }

    public partial class frmDashboard : Form
    {
        private readonly User _LoggedInUser;
        private readonly Cart _Cart;
        private DashBoardOptions _SelectedOption;

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

            frmMenu frmMenu = new frmMenu(_LoggedInUser, DisplayInDashboardFormHook, AddCartEntry, _Cart.SubtractCartEntry, _Cart.AddEntriesToDGV, _Cart.Clear, _Cart.Entries, SetCurrentSelected)
            {
                TopLevel = false,
            };

            _SelectedOption = DashBoardOptions.Menu;
            DisplayInDashboardFormHook(frmMenu);
        }

        private void AddCartEntry(Items item, int quantity)
        {
            _Cart.AddCartEntry(item.Id, quantity);
        }

        private void DisplayInDashboardFormHook(Form form)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (_SelectedOption == DashBoardOptions.Menu)
            {
                return;
            }

            _SelectedOption = DashBoardOptions.Menu;
            DisplayInDashboardFormHook(new frmMenu(_LoggedInUser, DisplayInDashboardFormHook, AddCartEntry, _Cart.SubtractCartEntry, _Cart.AddEntriesToDGV, _Cart.Clear, _Cart.Entries, SetCurrentSelected)
            {
                TopLevel = false,
            });
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            if (_SelectedOption == DashBoardOptions.Delivery) 
            {
                return;
            }

            _SelectedOption = DashBoardOptions.Delivery;
            var frmDelivery = new frmDelivery(_LoggedInUser)
            {
                TopLevel = false
            };

            DisplayInDashboardFormHook(frmDelivery);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _Cart.Serialize();
                Close();
            }
        }

        private void SetCurrentSelected(DashBoardOptions options)
        {
            _SelectedOption = options;
        }
    }
}
