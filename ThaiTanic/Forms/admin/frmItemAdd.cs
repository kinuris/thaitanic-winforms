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

namespace ThaiTanic.Forms.admin
{
    public partial class frmItemAdd : Form
    {
        private readonly string _Username;
        private readonly string _Password;

        public frmItemAdd(string username, string password)
        {
            InitializeComponent();

            _Username = username;
            _Password = password;

            string[] itemsCategory = Enum.GetValues(typeof(ItemCategory))
                .Cast<ItemCategory>()
                .Where(cat => cat != ItemCategory.Invalid)
                .Select(cat => cat.DBString())
                .ToArray();

            cbItemCategory.Items.AddRange(itemsCategory);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrEmpty(txtProductPrice.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) || cbItemCategory.SelectedItem == null)
            {
                MessageBox.Show("All fields are required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal itemPrice = decimal.Parse(txtProductPrice.Text);

            bool success = Items.CreateItem(txtProductName.Text, txtDescription.Text, itemPrice, Items.ParseItemCategory(cbItemCategory.Text), true, _Username, _Password);

            if (!success)
            {
                MessageBox.Show("Failed to create Item", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtProductName.ResetText();
            txtDescription.ResetText();
            txtProductPrice.ResetText();
            cbItemCategory.ResetText();

            MessageBox.Show("Successfully created Item", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
