using System;
using System.Windows.Forms;
using ThaiTanic.Entities;

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
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!checkBoxTermsAndConditions.Checked)
            {
                MessageBox.Show("Agree to terms and conditions", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add validation

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(dateTimeBirthday.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required if not otherwise specified", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (User.AssertUserExistsByUsername(txtUsername.Text))
            {
                MessageBox.Show("Username already exists", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return;
            }

            bool success = User.CreateUser(txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, txtPhoneNumber.Text, dateTimeBirthday.Value, txtEmail.Text);
        
            if (!success)
            {
                MessageBox.Show("Failed to create user", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Successfully created user", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
