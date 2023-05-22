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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();            
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.PasswordChar = '●';
                btnShowPass.Image = Properties.Resources.show_pass;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                btnShowPass.Image = Properties.Resources.show_pass_pressed;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
