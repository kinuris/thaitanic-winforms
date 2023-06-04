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
using Guna.UI2.WinForms;
using ThaiTanic.Entities;

namespace ThaiTanic.Forms
{
    public partial class frmMenu : Form
    {
        private readonly Action<Items, int> AddCartEntry;

        public frmMenu(Action<Items, int> addCartEntry)
        {
            InitializeComponent();

            AddCartEntry = addCartEntry;

            LoadMenuWithItems(ItemCategory.Drinks);


            //------------------- DUMMY CATEGORIES -------------------------------------
            Color[] colors = new Color[] { Color.FromArgb(170, 216, 213), Color.FromArgb(194, 156, 156), Color.FromArgb(174, 201, 217), Color.FromArgb(255, 200, 221), Color.FromArgb(162, 210, 255), Color.FromArgb(205, 180, 219), Color.FromArgb(255, 178, 178), Color.FromArgb(246, 234, 194) };
            
            for (int i = 0; i < 8; i++)
            {
                ucCategoryCard categoryCard = new ucCategoryCard();
                categoryCard.BgColor = colors[i];

                pnlContainerCategories.Controls.Add(categoryCard);
            }

            //------------------- DUMMY CART DATA -------------------------------------
            dgvCart.Rows.Add("Egg Sandwich", 10, 1000.19);
            dgvCart.Rows.Add("Tuna Sandwich", 10, 10.10);
            dgvCart.Rows.Add("ButetrScotch Muffins", 10, 10.10);
            dgvCart.Rows.Add("Tuna Pie", 10, 10.10);
            dgvCart.Rows.Add("Thai Sandwich", 10, 10.10);
            dgvCart.Rows.Add("Crispy Hashbrowns", 10, 10.10);
            dgvCart.Rows.Add("Cheesy Potatoes", 10, 10.10);
            dgvCart.Rows.Add("Applesauce Muffins", 10, 10.10);           
        }

        private void LoadMenuWithItems(ItemCategory category)
        {
            //pnlContainerCart.Controls.Clear();

            foreach (var dessert in Items.GetAllItems().Where(i => i.Category == category))
            {
                ucItemCard itemCard = new ucItemCard(AddCartEntry)
                {
                    Item = dessert
                };

                pnlContainerItems.Controls.Add(itemCard);
            }
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            dgvCart.ClearSelection();
        }
    }
}
