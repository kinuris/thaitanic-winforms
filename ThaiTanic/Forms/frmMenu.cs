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
using Guna.UI2.WinForms;

namespace ThaiTanic.Forms
{
    public partial class frmMenu : Form
    {      
        public frmMenu()
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                ucItemCard itemCard = new ucItemCard();

                pnlContainerItems.Controls.Add(itemCard);
            }


            // guna2DataGridView1.DataSource = new { items = "Item 1", quantity = 10, cost = 10.00 };

            guna2DataGridView1.Rows.Add(new object[] { "item2", 10, 50.00 });
            guna2DataGridView1.Rows.Add("item 3", 10, 69.69);

            int index = guna2DataGridView1.Rows.Add();
            var currentRow = guna2DataGridView1.Rows[index];

            currentRow.Cells[0].Value = "Item 1";
            currentRow.Cells[1].Value = 10;
            currentRow.Cells[2].Value = 1.00;

           // guna2DataGridView1.Invoke((Action)delegate
           //{
           //    guna2DataGridView1.Rows.Add();
           //});

           // var rowCount = guna2DataGridView1.Rows.Count;

           // guna2DataGridView1.Rows[rowCount - 1].Cells["items"].Value = "item 2";
           // guna2DataGridView1.Rows[rowCount - 1].Cells["quantity"].Value = 20;
           // guna2DataGridView1.Rows[rowCount - 1].Cells["cost"].Value = 20.00;
        
           // //guna2DataGridView1.Rows[rowCount - 1].EndEdit()

        }
    }
}
