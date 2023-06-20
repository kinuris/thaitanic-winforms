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
        }
    }
}
