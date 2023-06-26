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
using ThaiTanic.Forms.Reusable;

namespace ThaiTanic.Forms
{
    public partial class frmAccountProfile : Form
    {
        private readonly User _LoggedInUser;

        public frmAccountProfile(User loggedInUser)
        {
            InitializeComponent();

            _LoggedInUser = loggedInUser;
        }

        private void frmAccountProfile_Load(object sender, EventArgs e)
        {
            txtUsername.Text = _LoggedInUser.Username;
            txtFirstName.Text = _LoggedInUser.FirstName;
            txtMiddleName.Text = _LoggedInUser.MiddleName;
            txtEmail.Text = _LoggedInUser.Email;
            txtLastName.Text = _LoggedInUser.LastName;
            txtPhoneNumber.Text = _LoggedInUser.PhoneNumber;
            dtpBirthday.Value = _LoggedInUser.Birthday;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                frmPassPrompt frmPassPrompt = new frmPassPrompt(_LoggedInUser);

                if (frmPassPrompt.ShowDialog(this) == DialogResult.OK)
                    _LoggedInUser.UpdatePassword(frmPassPrompt.TextPassword, txtNewPassword.Text);
                else 
                    return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(dtpBirthday.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required if not otherwise specified", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _LoggedInUser.Update(txtUsername.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, dtpBirthday.Value);
            MessageBox.Show("Profile successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
