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
        private readonly User loggedInUser;
        private readonly Cart cart;

        public frmDashboard(User user)
        {
            InitializeComponent();

            loggedInUser = user;
            cart = new Cart(user);

            try
            {
                cart.Deserialize();
            }
            catch (FileNotFoundException)
            {
                // PASS
            }

            frmMenu frmMenu = new frmMenu(AddCartEntry, cart.SubtractCartEntry, cart.AddEntriesToDGV, cart.Clear)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(frmMenu);
            frmMenu.Show();
        }

        private void AddCartEntry(Items item, int quantity)
        {
            cart.AddCartEntry(item.Id, quantity);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            cart.Serialize();
            Close();
        }
    }
}
