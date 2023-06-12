using System;
using System.Windows.Forms;
using ThaiTanic.UserControls;

namespace ThaiTanic.Forms.admin
{
    public partial class frmManageOrders : Form
    {
        public frmManageOrders()
        {
            InitializeComponent();

            //-----------------------------DUMMY ORDERS--------------------------------------
            int[] orderNumbers = new int[] { 13123, 42523, 41236, 21893 };
            int[] itemCounts = new int[] { 4, 3, 2, 7 };
            double[] totalCosts = new double[] { 1000369.6, 479.6, 675.6, 395.7 };
            string[] orderStatus = new string[] { "To Receive", "To Ship", "Canceled", "Completed" };

            for (int i = 0; i < 4; i++)
            {
                ucManageOrderCard ucManageOrderCard = new ucManageOrderCard(orderNumbers[i], itemCounts[i], DateTime.Now, totalCosts[i], orderStatus[i]);

                pnlOrders.Controls.Add(ucManageOrderCard);
            }
        }
    }
}
