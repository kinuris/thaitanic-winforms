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
    public partial class frmItemUpdate : Form
    {
        private readonly string _Username;
        private readonly string _Password;

        public frmItemUpdate(string username, string password)
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

            cbAvailable.Items.Add(true);
            cbAvailable.Items.Add(false);

            cbItems.Enabled = false;
            cbAvailable.Enabled = false;
            txtProductName.Enabled = false;
            txtProductPrice.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (cbItems.SelectedItem == null)
            {
                return;
            }

            var selectedItem = (Items)cbItems.SelectedItem;

            selectedItem.UpdateItem(txtProductName.Text, txtDescription.Text, decimal.Parse(txtProductPrice.Text), selectedItem.Category, bool.Parse(cbAvailable.Text), _Username, _Password);
        }

        private void cbItemCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbItemCategory.SelectedItem == null)
            {
                return;
            }

            cbItems.Enabled = true;

            cbAvailable.ResetText();
            txtProductName.ResetText();
            txtProductPrice.ResetText();
            txtDescription.ResetText();

            cbAvailable.Enabled = false;
            txtProductName.Enabled = false;
            txtProductPrice.Enabled = false;
            txtDescription.Enabled = false;

            var selectedCategory = Items.ParseItemCategory(cbItemCategory.Text);

            cbItems.Items.Clear();
            cbItems.Items.AddRange(Items.GetAllItems().Where(item => item.Category == selectedCategory).ToArray());
        }

        private void cbItems_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbItems.SelectedItem == null)
            {
                return;
            }

            cbAvailable.Enabled = true;
            txtProductName.Enabled = true;
            txtProductPrice.Enabled = true;
            txtDescription.Enabled = true;

            var selectedItem = (Items) cbItems.SelectedItem;

            cbAvailable.Text = selectedItem.Available.ToString();
            txtProductName.Text = selectedItem.Name;
            txtProductPrice.Text = selectedItem.Price.ToString();
            txtDescription.Text = selectedItem.Description;
        }
    }
}
