using System;
using System.Linq;
using System.Windows.Forms;
using ThaiTanic.Entities;
using ThaiTanic.UserControls;

namespace ThaiTanic.Forms.admin
{
    enum SortByOptions
    {
        Date,
        Quantity,
        Price
    }

    public partial class frmManageOrders : Form
    {
        private OrderStatus? _FilterByStatus;
        private SortByOptions _SortBy;
        private bool _ReversedOrders;
        private int _OrdersPage;
        private User _SelectedUser;

        public frmManageOrders()
        {
            InitializeComponent();

            _OrdersPage = 1;
            _SelectedUser = null;
            _FilterByStatus = null;
            _ReversedOrders = false;
            _SortBy = SortByOptions.Date;

            cbUsers.Items.AddRange(User.GetAllUsers().Where(user => user.Role != UserRole.Admin).ToArray());
            //-----------------------------DUMMY ORDERS--------------------------------------
            //int[] orderNumbers = new int[] { 13123, 42523, 41236, 21893 };
            //int[] itemCounts = new int[] { 4, 3, 2, 7 };
            //double[] totalCosts = new double[] { 1000369.6, 479.6, 675.6, 395.7 };
            //string[] orderStatus = new string[] { "To Receive", "To Ship", "Canceled", "Completed" };

            //for (int i = 0; i < 4; i++)
            //{
            //    ucManageOrderCard ucManageOrderCard = new ucManageOrderCard(orderNumbers[i], itemCounts[i], DateTime.Now, totalCosts[i], orderStatus[i]);

            //    pnlOrders.Controls.Add(ucManageOrderCard);
            //}
        }

        private void cbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUsers.SelectedItem == null) return;

            var selectedUser = (User)cbUsers.SelectedItem;
            _SelectedUser = selectedUser;
            _OrdersPage = 1;

            UpdateOrderItems();
        }

        private void UpdateOrderItems()
        {
            var orders = Orders.OrdersByUser(_SelectedUser).Where(order => _FilterByStatus == null || order.Status == _FilterByStatus);

            pnlOrders.Controls.Clear();
            lblOrderPage.Text = $"{_OrdersPage} / {(Math.Ceiling(orders.Count() / 4m) == 0 ? "1" : Math.Ceiling(orders.Count() / 4m).ToString())}";

            var sorted = orders;

            if (_SortBy == SortByOptions.Date)
            {
                sorted = sorted.OrderBy(order => order.DateOrdered);
            } 
            else if (_SortBy == SortByOptions.Quantity) 
            {
                sorted = sorted.OrderBy(order => order.GetBatch().Count());
            } 
            else if (_SortBy == SortByOptions.Price)
            {
                sorted = sorted.OrderBy(order => order.TotalPrice);
            }

            if (_ReversedOrders)
            {
                sorted = sorted.Reverse();
            }

            sorted = sorted.Skip((_OrdersPage - 1) * 4);

            foreach (var order in sorted.Take(4))
            {
                ucManageOrderCard ucManageOrderCard = new ucManageOrderCard(order.Id, order.GetBatch().Count(), order.DateOrdered, (double)order.TotalPrice, order.Status.CorrectedString(), order.SetStatus);

                pnlOrders.Controls.Add(ucManageOrderCard);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;

            if (_OrdersPage > 1)
            {
                _OrdersPage--;
                UpdateOrderItems();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            var orders = Orders.OrdersByUser(_SelectedUser).Where(order => _FilterByStatus == null || order.Status == _FilterByStatus);

            if (_OrdersPage < Math.Ceiling(orders.Count() / 4m))
            {
                _OrdersPage++;
                UpdateOrderItems();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == null) return;

            _OrdersPage = 1;
            _FilterByStatus = null;
            UpdateOrderItems();
        }

        private void btnToPay_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == OrderStatus.ToPay) return;

            _OrdersPage = 1;
            _FilterByStatus = OrderStatus.ToPay;
            UpdateOrderItems();
        }

        private void btnToShip_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == OrderStatus.ToShip) return;

            _OrdersPage = 1;
            _FilterByStatus = OrderStatus.ToShip;
            UpdateOrderItems();
        }

        private void btnToReceive_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == OrderStatus.ToRecieve) return;

            _OrdersPage = 1;
            _FilterByStatus = OrderStatus.ToRecieve;
            UpdateOrderItems();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == OrderStatus.Cancelled) return;

            _OrdersPage = 1;
            _FilterByStatus = OrderStatus.Cancelled;
            UpdateOrderItems();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_FilterByStatus == OrderStatus.Completed) return;

            _OrdersPage = 1;
            _FilterByStatus = OrderStatus.Completed;
            UpdateOrderItems();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_SortBy == SortByOptions.Date) return;

            _SortBy = SortByOptions.Date;
            UpdateOrderItems();
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if (_SortBy == SortByOptions.Quantity) return;

            _SortBy = SortByOptions.Quantity;
            UpdateOrderItems();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (_SelectedUser == null) return;
            if ( _SortBy == SortByOptions.Price) return;

            _SortBy = SortByOptions.Price;
            UpdateOrderItems();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            _ReversedOrders = !_ReversedOrders;

            UpdateOrderItems();
        }
    }
}
