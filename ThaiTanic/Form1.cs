using MySql.Data.MySqlClient;
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
using ThaiTanic.State;

namespace ThaiTanic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var user = User.AuthUser(guna2TextBox1.Text, guna2TextBox3.Text);
            var items = Items.GetAllItems();

            Cart.Items = items.Select(item => new CartEntry()
            {
                Item = item,
                Quantity = 23
            }).ToList();

            Cart.Serialize();

            if (user == null)
            {
                MessageBox.Show("User does not Exist!");
                return;
            }

            MessageBox.Show(Orders.GetOrderById(16).GetBatch().First().AssociatedItem.Name);

            MessageBox.Show($"User Exists: ID -> {user.Id} & Name -> {user.FullName} & Role -> {user.Role}");
        }
    }
}
