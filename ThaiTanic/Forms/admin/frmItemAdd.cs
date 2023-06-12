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
    public partial class frmItemAdd : Form
    {
        public frmItemAdd()
        {
            InitializeComponent();

            //------------------------DUMMY CATEGORY DROPDOWN---------------------------
            string[] itemsCategory = new string[] { "Breakfast", "Burgers", "Soup", "Dessert", "Drinks", "Alcohol", "Main Course", "Pasta" };
            cbItemCategory.Items.AddRange(itemsCategory);
        }
    }
}
