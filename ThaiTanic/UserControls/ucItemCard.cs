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
    public partial class ucItemCard : UserControl
    {
        public ucItemCard()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get { return txtItemTitle.Text; }
            set { txtItemTitle.Text = value; }
        }

        public string ItemPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
    }
}
