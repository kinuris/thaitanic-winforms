﻿using System;
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
    public partial class ucOrder : UserControl
    {
        private readonly Action<int> _SetSelectedId;
        private readonly int _OrderId;

        public ucOrder(int orderNumber, int itemCount, DateTime orderDate, double totalCost, string orderStatus, Action<int> setSelectedId)
        {
            InitializeComponent();

            lblOrderNumber.Text = orderNumber.ToString();
            lblItemCount.Text = itemCount.ToString();
            lblOrderDate.Text = orderDate.ToString("f");
            lblTotalCost.Text = totalCost.ToString("₱#,###.00");
            lblOrderStatus.Text = orderStatus;
            _SetSelectedId = setSelectedId;
            _OrderId = orderNumber;

            switch (orderStatus)
            {
                case "To Pay":
                    pnlOrderStatus.FillColor = Color.FromArgb(225, 177, 44);
                    break;
                case "To Ship":
                    pnlOrderStatus.FillColor = Color.FromArgb(12, 140, 233);
                    break;
                case "To Receive":
                    pnlOrderStatus.FillColor = Color.FromArgb(75, 162, 78);
                    break;
                case "Completed":
                    pnlOrderStatus.FillColor = Color.FromArgb(147, 109, 212);
                    break;
                case "Canceled":
                    pnlOrderStatus.FillColor = Color.FromArgb(195, 29, 29);
                    break;
            }
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            _SetSelectedId(_OrderId);
        }
    }
}
