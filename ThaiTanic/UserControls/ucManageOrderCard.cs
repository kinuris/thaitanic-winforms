using System;
using System.Drawing;
using System.Windows.Forms;
using ThaiTanic.Entities;

namespace ThaiTanic.UserControls
{
    public partial class ucManageOrderCard : UserControl
    {
        private readonly Action<OrderStatus> _SetStatus;

        public ucManageOrderCard(int orderNumber, int itemCount, DateTime orderDate, double totalCost, string orderStatus, Action<OrderStatus> setStatus)
        {
            InitializeComponent();

            _SetStatus = setStatus;

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
            OrderStatus selectedStatus = OrderStatus.Invalid;

            switch (cbOrderStatus.SelectedIndex)
            {
                case 0:
                    cbOrderStatus.FillColor = Color.FromArgb(225, 177, 44);
                    selectedStatus = OrderStatus.ToPay;
                    break;
                case 1:
                    cbOrderStatus.FillColor = Color.FromArgb(12, 140, 233);
                    selectedStatus = OrderStatus.ToShip;
                    break;
                case 2:
                    cbOrderStatus.FillColor = Color.FromArgb(75, 162, 78);
                    selectedStatus = OrderStatus.ToRecieve;
                    break;
                case 3:
                    cbOrderStatus.FillColor = Color.FromArgb(195, 29, 29);
                    selectedStatus = OrderStatus.Cancelled;
                    break;
                case 4:
                    cbOrderStatus.FillColor = Color.FromArgb(147, 109, 212);
                    selectedStatus = OrderStatus.Completed;
                    break;
            }

            _SetStatus(selectedStatus);
        }
    }
}
