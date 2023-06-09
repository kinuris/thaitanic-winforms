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
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            //--------------------------DUMMY--------------------------------------------------------
            int[] orderNums = new int[] { 13123, 42523, 41236, 21893 };
            int[] itemCounts = new int[] { 4, 3, 2, 7 };
            double[] totalCosts = new double[] { 369.6, 479.6, 675.6, 395};
            string[] status = new string[] { "To Receive", "To Ship", "Canceled", "To Pay" };

            for (int i = 0; i < 4; i++)
            {
                ucOrder order = new ucOrder(orderNumber: orderNums[i], itemCount: itemCounts[i], orderDate: DateTime.Now, totalCost: totalCosts[i], orderStatus: status[i]);

                pnlOrders.Controls.Add(order);
            } 
        }
    }
}
