using System;
using System.Windows.Forms;
using ThaiTanic.Entities;

namespace ThaiTanic.UserControls
{
    public partial class ucItemCard : UserControl
    {
        private readonly Action<Items, int> _AddCartEntry;

        public ucItemCard(Action<Items, int> addCartEntry)
        {
            InitializeComponent();

            _AddCartEntry = addCartEntry;
        }

        private Items item;
        public Items Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                txtItemTitle.Text = item.Name;
                lblPrice.Text = string.Format("{0:n}", item.Price);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                _AddCartEntry(Item, 1);
                txtQuantity.Text = "";

                return;
            }

            if (int.Parse(txtQuantity.Text) < 1)
            {
                MessageBox.Show("Must specify quantity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Text = "";

                return;
            }

            _AddCartEntry(Item, int.Parse(txtQuantity.Text));
            txtQuantity.Text = "";
        }
    }
}
