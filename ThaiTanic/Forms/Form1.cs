using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ThaiTanic.Entities;
using ThaiTanic.Forms;

namespace ThaiTanic
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // SAMPLE LOGIC
            var user = User.AuthUser(txtUsername.Text, txtPassword.Text);

            if (user == null) 
            {
                MessageBox.Show("User does not exist");
                return;
            }

            var orders = Orders.OrdersByUser(user);

            foreach (var order in orders)
                foreach (var batch in order.GetBatch())
                    MessageBox.Show($"From Order: {order.Id} => Item: {batch.AssociatedItem.Name}");

            MessageBox.Show($"Welcome {user.FullName}");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.ShowDialog(this);
        }
    }
}
