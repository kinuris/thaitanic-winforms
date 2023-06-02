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
        }

        private void LoadMenuWithItems(ItemCategory category)
        {
            pnlContainerCart.Controls.Clear();

            foreach (var dessert in Items.GetAllItems().Where(i => i.Category == category))
            {
                ucItemCard itemCard = new ucItemCard(AddCartEntry)
                {
                    Item = dessert
                };

                pnlContainerItems.Controls.Add(itemCard);
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.ClearSelection();
        }
    }
}
