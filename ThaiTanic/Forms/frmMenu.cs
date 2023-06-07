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
using Org.BouncyCastle.Asn1;

namespace ThaiTanic.Forms
{
    public partial class frmMenu : Form
    {
        private readonly Action<Items, int> _AddCartEntry;
        private int _CategoryPage;
        private ItemCategory _CurrentCategory;
        private List<Items> _CurrentItems;

        public frmMenu(Action<Items, int> addCartEntry, Action<DataGridView> addEntriesToDGV)
        {
            InitializeComponent();
            lblSubtotal.Text = "0.00";
            lblShippingCost.Text = "50.00";

            // Hooking into _AddCartEntry
            _AddCartEntry = (Items items, int quantity) => {
                addCartEntry(items, quantity);
                dgvCart.Rows.Clear();
                addEntriesToDGV(dgvCart);

                lblSubtotal.Text = string.Format("{0:n}", dgvCart.Rows.Cast<DataGridViewRow>().Select(e => Convert.ToDecimal(e.Cells[2].Value)).Sum());
                lblVat.Text = string.Format("{0:n}", Convert.ToDecimal(lblSubtotal.Text) * 0.12m);
            };

            _CategoryPage = 1;
            _CurrentCategory = ItemCategory.Breakfast;
            _CurrentItems = Items.GetAllItems().Where(i => i.Category == _CurrentCategory).ToList();

            UpdateShownMenuItems();

            //------------------- DUMMY CATEGORIES -------------------------------------
            Color[] colors = new Color[] { Color.FromArgb(170, 216, 213), Color.FromArgb(194, 156, 156), Color.FromArgb(174, 201, 217), Color.FromArgb(255, 200, 221), Color.FromArgb(162, 210, 255), Color.FromArgb(205, 180, 219), Color.FromArgb(255, 178, 178), Color.FromArgb(246, 234, 194) };
            int iteration = 0;
            foreach (ItemCategory category in Enum.GetValues(typeof(ItemCategory)))
            {
                if (category == ItemCategory.Invalid)
                    continue;

                ucCategoryCard categoryCard = new ucCategoryCard(category.AsString(), Items.GetAllItems().Where(e => e.Category == category).Count())
                {
                    BgColor = colors[iteration++]
                };

                pnlContainerCategories.Controls.Add(categoryCard);
            }

            //-------------------DUMMY CART DATA -------------------------------------
            //dgvCart.Rows.Add("Egg Sandwich", 10, 1000.19);
            //dgvCart.Rows.Add("Tuna Sandwich", 10, 10.10);
            //dgvCart.Rows.Add("ButetrScotch Muffins", 10, 10.10);
            //dgvCart.Rows.Add("Tuna Pie", 10, 10.10);
            //dgvCart.Rows.Add("Thai Sandwich", 10, 10.10);
            //dgvCart.Rows.Add("Crispy Hashbrowns", 10, 10.10);
            //dgvCart.Rows.Add("Cheesy Potatoes", 10, 10.10);
            //dgvCart.Rows.Add("Applesauce Muffins", 10, 10.10);
        }

        private void UpdateShownMenuItems()
        {
            pnlContainerItems.Controls.Clear();

            // foreach (var dessert in Items.GetAllItems().Where(i => i.Category == category).Skip((page - 1) * 8).Take(8 * page))
            // {
            //     ucItemCard itemCard = new ucItemCard(AddCartEntry)
            //     {
            //         Item = dessert
            //     };

            //     pnlContainerItems.Controls.Add(itemCard);
            // }

            foreach (var item in _CurrentItems.Skip((_CategoryPage - 1) * 8).Take(_CategoryPage * 8)) 
            {
                ucItemCard itemCard = new ucItemCard(_AddCartEntry)
                {
                    Item = item
                };

                pnlContainerItems.Controls.Add(itemCard);
            }
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            dgvCart.ClearSelection();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_CategoryPage <= _CurrentItems.Count / 8)
            {
                _CategoryPage++;
                UpdateShownMenuItems();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_CategoryPage > 1)
            {
                _CategoryPage--;
                UpdateShownMenuItems();
            }
        }
    }
}
