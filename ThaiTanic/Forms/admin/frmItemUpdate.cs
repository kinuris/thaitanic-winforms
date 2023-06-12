using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.Forms.admin
{
    public partial class frmItemUpdate : Form
    {
        public frmItemUpdate()
        {
            InitializeComponent();

            //------------------------DUMMY CATEGORY DROPDOWN---------------------------
            string[] itemsCategory = new string[] { "Breakfast", "Burgers", "Soup", "Dessert", "Drinks", "Alcohol", "Main Course", "Pasta" };
            cbItemCategory.Items.AddRange(itemsCategory);

            //------------------------DUMMY CATEGORY DROPDOWN---------------------------
            cbAvailable.Items.Add(true);
            cbAvailable.Items.Add(false);
        }
    }
}
