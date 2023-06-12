using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiTanic.Entities;
using ThaiTanic.UserControls;

namespace ThaiTanic.Forms
{
    public partial class frmDelivery : Form
    {
        private readonly List<Orders> _Orders;
        private readonly User _User;
        private OrderStatus? _FilterByStatus;
        private int _CurrentItemPage;
        private int _CurrentOrderPage;
        private int? _SelectedId;

        public frmDelivery(User user)
        {
            InitializeComponent();

            _User = user;
            _CurrentItemPage = 1;
            _CurrentOrderPage = 1;
            _FilterByStatus = null;
            _SelectedId = null;
            _Orders = Orders.OrdersByUser(_User);
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            UpdateOrderList();

            //--------------------------DUMMY--------------------------------------------------------
            //int[] orderNums = new int[] { 13123, 42523, 41236, 21893 };
            //int[] itemCounts = new int[] { 4, 3, 2, 7 };
            //double[] totalCosts = new double[] { 369.6, 479.6, 675.6, 395};
            //string[] status = new string[] { "To Receive", "To Ship", "Canceled", "To Pay" };

            //for (int i = 0; i < 4; i++)
            //{
            //    ucOrder order = new ucOrder(orderNumber: orderNums[i], itemCount: itemCounts[i], orderDate: DateTime.Now, totalCost: totalCosts[i], orderStatus: status[i]);

            //    pnlOrders.Controls.Add(order);
            //} 

            pnlOrderedBatch.Controls.Clear();

            lblOrderNumber.Text = "(Select An Order)"; 
            lblSubtotal.Text = "";
            lblVat.Text = "";
            lblShippingFee.Text = "";
            lblTotal.Text = "";
        }

        private void SetSelectedId(int id)
        {
            _SelectedId = id;
            _CurrentItemPage = 1;
            UpdateOrderSummary();
            UpdateOrderItemsList();
        }

        private void UpdateOrderList()
        {
            pnlOrders.Controls.Clear();
            foreach (var order in _Orders.Where(order => _FilterByStatus == null || order.Status == _FilterByStatus).Reverse().Skip((_CurrentOrderPage - 1) * 4).Take(4))
            {
                ucOrder ucOrder = new ucOrder(orderNumber: order.Id, itemCount: order.GetBatch().Count(), order.DateOrdered, totalCost: (double)order.TotalPrice, orderStatus: order.Status.CorrectedString(), SetSelectedId);

                pnlOrders.Controls.Add(ucOrder);
            }

            lblOrderPage.Text = $"{_CurrentOrderPage} / {(Math.Ceiling(_Orders.Where(order => _FilterByStatus == null || order.Status == _FilterByStatus).Count() / 4m) == 0m ? "1" :  Math.Ceiling(_Orders.Where(order => _FilterByStatus == null || order.Status == _FilterByStatus).Count() / 4m).ToString())}";
        }

        private void UpdateOrderItemsList()
        {
            var selectedOrder = _Orders.Find(order => order.Id == _SelectedId);

            lblOrderNumber.Text = selectedOrder.Id.ToString();

            pnlOrderedBatch.Controls.Clear();

            foreach (var batch in selectedOrder.GetBatch().Skip((_CurrentItemPage - 1) * 4).Take(4))
            {
                ucOrderItemCard card = new ucOrderItemCard(batch.AssociatedItem.Name, batch.AssociatedItem.Price, batch.Quantity);
                pnlOrderedBatch.Controls.Add(card);
            }

            lblItemPageIndicator.Text = $"{_CurrentItemPage} / {Math.Ceiling(selectedOrder.GetBatch().Count() / 4m)}";
        }

        private void UpdateOrderSummary()
        {
            var selectedOrder = _Orders.Find(order => order.Id == _SelectedId);

            lblSubtotal.Text = "₱ " + selectedOrder.TotalPrice.ToString();
            lblVat.Text = "₱ " + string.Format("{0:n}", selectedOrder.TotalPrice * 0.12m);
            lblShippingFee.Text = "₱ 50.00";
            lblTotal.Text = "₱ " + string.Format("{0:n}", (selectedOrder.TotalPrice * 0.12m) + selectedOrder.TotalPrice + 50m);
        }

        private void btnItemsPageForward_Click(object sender, EventArgs e)
        {
            if (_SelectedId == null) return;

            var selectedOrder = _Orders.Find(order => order.Id == _SelectedId);
            var batches = selectedOrder.GetBatch();

            if (_CurrentItemPage < Math.Ceiling(batches.Count() / 4m))
            {
                _CurrentItemPage++;
                UpdateOrderItemsList();
            }
        }

        private void btnItemsPageBackward_Click(object sender, EventArgs e)
        {
            if (_CurrentItemPage > 1)
            {
                _CurrentItemPage--;
                UpdateOrderItemsList();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_CurrentOrderPage < Math.Ceiling(_Orders.Where(order => _FilterByStatus == null || order.Status == _FilterByStatus).Count() / 4m))
            {
                _CurrentOrderPage++;
                UpdateOrderList();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_CurrentOrderPage > 1)
            {
                _CurrentOrderPage--;
                UpdateOrderList();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == null) return;

            _FilterByStatus = null;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }

        private void btnToPay_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == OrderStatus.ToPay) return;

            _FilterByStatus = OrderStatus.ToPay;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }

        private void btnToShip_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == OrderStatus.ToShip) return;

            _FilterByStatus = OrderStatus.ToShip;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }

        private void btnToReceive_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == OrderStatus.ToRecieve) return;

            _FilterByStatus = OrderStatus.ToRecieve;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == OrderStatus.Completed) return;

            _FilterByStatus = OrderStatus.Completed;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            if (_FilterByStatus == OrderStatus.Cancelled) return;
         
            _FilterByStatus = OrderStatus.Cancelled;
            _CurrentOrderPage = 1;
            UpdateOrderList();
        }
    }
}
