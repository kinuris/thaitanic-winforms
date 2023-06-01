using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiTanic.UserControls;

namespace ThaiTanic.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            int itemCount = 1;
            string[] items = new[] { "Egg Sandwich", "Tuna Sandwich", "Butterscotch Muffins", "Tuna Pie", "Thai Sandwich", "Crispy Hashbrowns", "Cheesy Potatoes", "Applesauce Muffins" };
            double[] prices = new[] { 10.50, 100.43, 99.99, 59.90, 69.69, 96.96, 11.11, 55.55 };

            for (int i = 0; i < itemCount; i++)
            {
                ucItemCard ucItemCard = new ucItemCard();

                ucItemCard.ItemName = items[i];
                ucItemCard.ItemPrice = prices[i].ToString("N");
                pnlItemContainer.Controls.Add(ucItemCard);
            }            
        }

        
    }
}
