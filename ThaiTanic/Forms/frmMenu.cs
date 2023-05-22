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

            int itemCount = 2;
            string[] items = new[] { "Egg Sandwich", "Tuna Sandwich", "Butterscotch Muffins", "Tuna Pie", "Thai Sandwich", "Crispy Hashbrowns", "Cheesy Potatoes", "Applesauce Muffins" };

            for (int i = 0; i < itemCount; i++)
            {
                ucItemCard ucItemCard = new ucItemCard();

                ucItemCard.ItemName = items[i];
                pnlItemContainer.Controls.Add(ucItemCard);
            }            
        }
    }
}
