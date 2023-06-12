using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThaiTanic.UserControls
{
    public partial class ucManageOrderCard : UserControl
    {
        public ucManageOrderCard(int orderNumber, int itemCount, DateTime orderDate, double totalCost, string orderStatus)
        {
            InitializeComponent();

            string[] status = new[] { "To Pay", "To Ship", "To Receive", "Canceled", "Completed" };
            cbOrderStatus.Items.AddRange(status);

            lblOrderNumber.Text = orderNumber.ToString();
            lblItemCount.Text = itemCount.ToString();
            lblOrderDate.Text = orderDate.ToString("f");
            lblTotalCost.Text = totalCost.ToString("₱#,###.00");
            cbOrderStatus.Text = orderStatus;
        }

        private void cbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOrderStatus.SelectedIndex)
            {
                case 0:
                    cbOrderStatus.FillColor = Color.FromArgb(225, 177, 44);
                    break;
                case 1:
                    cbOrderStatus.FillColor = Color.FromArgb(12, 140, 233);
                    break;
                case 2:
                    cbOrderStatus.FillColor = Color.FromArgb(75, 162, 78);
                    break;
                case 3:
                    cbOrderStatus.FillColor = Color.FromArgb(195, 29, 29);
                    break;
                case 4:
                    cbOrderStatus.FillColor = Color.FromArgb(147, 109, 212);
                    break;
            }
        }

        
    }
}
