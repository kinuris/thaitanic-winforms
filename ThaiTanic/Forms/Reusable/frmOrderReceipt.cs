using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.Forms.Reusable
{
    public partial class frmOrderReceipt : Form
    {
        public frmOrderReceipt(int orderNumber, DateTime dateOrdered, string paymentMethod, string initiatorFullName, decimal subtotal)
        {
            InitializeComponent();

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Reports\reportOrderReceipt.rdlc");

            rprtReceipt.LocalReport.ReportPath = file;

            ReportParameterCollection parameters = new ReportParameterCollection()
            {
                new ReportParameter("pTotalPayment", string.Format("{0:n} PHP", subtotal + (subtotal * 0.12m) + 50)),
                new ReportParameter("pOrderNumber", $"#{orderNumber}"),
                new ReportParameter("pDateOrdered", dateOrdered.ToString()),
                new ReportParameter("pPaymentMethod", "COD"),
                new ReportParameter("pOrderInitiatorName", initiatorFullName),
                new ReportParameter("pSubtotal", string.Format("{0:n} PHP", subtotal)),
                new ReportParameter("pVAT", string.Format("{0:n} PHP", subtotal * 0.12m)),
                new ReportParameter("pShippingFee", "50.00 PHP"),
            };

            rprtReceipt.LocalReport.SetParameters(parameters);
            rprtReceipt.RefreshReport();
        }
    }
}
