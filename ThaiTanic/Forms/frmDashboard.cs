using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            frmMenu frmMenu = new frmMenu();
            frmMenu.TopLevel = false;
            frmMenu.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frmMenu);
            frmMenu.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
