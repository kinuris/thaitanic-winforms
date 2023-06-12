using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.UserControls
{
    public partial class ucOrderItemCard : UserControl
    {
        private readonly string _ItemName;
        private readonly decimal _ItemPrice;
        private readonly int _ItemQuantity;

        public ucOrderItemCard(string itemName, decimal itemPrice, int quantity)
        {
            InitializeComponent();

            _ItemName = itemName;
            _ItemPrice = itemPrice;
            _ItemQuantity = quantity;

            lblItemName.Text = _ItemName;
            lblItemPrice.Text = string.Format("{0:n}", itemPrice);
            lblQuantity.Text = "x" + quantity;
            lblTotalPrice.Text = string.Format("{0:n}", quantity * itemPrice);
        }
    }
}
