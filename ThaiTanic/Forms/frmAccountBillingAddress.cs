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
    enum AddressSlots
    {
        First,
        Second,
        Third,
        Fourth
    }

    public partial class frmAccountBillingAddress : Form
    {
        private User _LoggedInUser;
        private readonly List<BillingAddress> _BillingAddresses;

        private AddressSlots _SelectedSlot;

        public frmAccountBillingAddress(User loggedInUser)
        {
            InitializeComponent();
            _LoggedInUser = loggedInUser;
            _BillingAddresses = BillingAddress.BillingAddressesOfUser(loggedInUser);
            _SelectedSlot = AddressSlots.First;
        }

        private void frmAccountBillingAddress_Load(object sender, EventArgs e)
        {
            txtAddressLabel.Enabled = false;
            txtRegion.Enabled = false;
            txtCity.Enabled = false;
            txtPostalCode.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtProvince.Enabled = false;
            txtBarangay.Enabled = false;

            int iteration = 1;
            foreach (var billingAddress in _BillingAddresses.Take(4))
            {
                switch (iteration)
                {
                    case 1:
                        lblAddressLabel.Text = billingAddress.FullName;
                        lblRegion.Text = billingAddress.Region;
                        lblPostalCode.Text = billingAddress.PostalCode;
                        lblPhoneNumber.Text = billingAddress.PhoneNumber;
                        lblProvince.Text = billingAddress.Province;
                        lblBarangay.Text = billingAddress.Barangay;
                        break;
                    case 2:
                        lblAddressLabel2.Text = billingAddress.FullName;
                        lblRegion2.Text = billingAddress.Region;
                        lblPostalCode2.Text = billingAddress.PostalCode;
                        lblPhoneNumber2.Text = billingAddress.PhoneNumber;
                        lblProvince2.Text = billingAddress.Province;
                        lblBarangay2.Text = billingAddress.Barangay;
                        break;
                    case 3:
                        lblAddressLabel3.Text = billingAddress.FullName;
                        lblRegion3.Text = billingAddress.Region;
                        lblPostalCode3.Text = billingAddress.PostalCode;
                        lblPhoneNumber3.Text = billingAddress.PhoneNumber;
                        lblProvince3.Text = billingAddress.Province;
                        lblBarangay3.Text = billingAddress.Barangay;
                        break;
                    case 4:
                        lblAddressLabel4.Text = billingAddress.FullName;
                        lblRegion4.Text = billingAddress.Region;
                        lblPostalCode4.Text = billingAddress.PostalCode;
                        lblPhoneNumber4.Text = billingAddress.PhoneNumber;
                        lblProvince4.Text = billingAddress.Province;
                        lblBarangay4.Text = billingAddress.Barangay;
                        break;
                }

                iteration++;
            }

            EnableTextboxes();

            txtAddressLabel.Text = _BillingAddresses[0].FullName;
            txtRegion.Text = _BillingAddresses[0].Region;
            txtPostalCode.Text = _BillingAddresses[0].PostalCode;
            txtPhoneNumber.Text = _BillingAddresses[0].PhoneNumber;
            txtProvince.Text = _BillingAddresses[0].Province;
            txtBarangay.Text = _BillingAddresses[0].Barangay;
            txtCity.Text = _BillingAddresses[0].City;
        }

        private void pnlBillingAddress1_Click(object sender, EventArgs e)
        {
            if (_SelectedSlot == AddressSlots.First) return;

            _SelectedSlot = AddressSlots.First;

            ResetTextboxes();

            txtAddressLabel.Text = _BillingAddresses[0].FullName;
            txtRegion.Text = _BillingAddresses[0].Region;
            txtPostalCode.Text = _BillingAddresses[0].PostalCode;
            txtPhoneNumber.Text = _BillingAddresses[0].PhoneNumber;
            txtProvince.Text = _BillingAddresses[0].Province;
            txtBarangay.Text = _BillingAddresses[0].Barangay;
            txtCity.Text = _BillingAddresses[0].City;

            EnableTextboxes();
            MessageBox.Show("Selected 1st slot", "1st Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlBillingAddress2_Click(object sender, EventArgs e)
        {
            if (_BillingAddresses.Count < 1)
            {
                MessageBox.Show("Must fill 1st address slot first");

                return;
            }

            if (_SelectedSlot == AddressSlots.Second) return;

            _SelectedSlot = AddressSlots.Second;

            ResetTextboxes();

            if (_BillingAddresses.Count() == 2)
            {
                txtAddressLabel.Text = _BillingAddresses[1].FullName;
                txtRegion.Text = _BillingAddresses[1].Region;
                txtPostalCode.Text = _BillingAddresses[1].PostalCode;
                txtPhoneNumber.Text = _BillingAddresses[1].PhoneNumber;
                txtProvince.Text = _BillingAddresses[1].Province;
                txtBarangay.Text = _BillingAddresses[1].Barangay;
                txtCity.Text = _BillingAddresses[1].City;
            }

            EnableTextboxes();
            MessageBox.Show("Selected 2nd slot", "2nd Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlBillingAddress3_Click(object sender, EventArgs e)
        {
            if (_BillingAddresses.Count() < 2)
            {
                MessageBox.Show("Must fill 2nd address slot first");

                return;
            }

            if (_SelectedSlot == AddressSlots.Third) return;

            _SelectedSlot = AddressSlots.Third;

            ResetTextboxes();

            if (_BillingAddresses.Count() == 3)
            {
                txtAddressLabel.Text = _BillingAddresses[2].FullName;
                txtRegion.Text = _BillingAddresses[2].Region;
                txtPostalCode.Text = _BillingAddresses[2].PostalCode;
                txtPhoneNumber.Text = _BillingAddresses[2].PhoneNumber;
                txtProvince.Text = _BillingAddresses[2].Province;
                txtBarangay.Text = _BillingAddresses[2].Barangay;
                txtCity.Text = _BillingAddresses[2].City;
            }
            

            EnableTextboxes();
            MessageBox.Show("Selected 3rd slot", "3rd Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlBillingAddress4_Click(object sender, EventArgs e)
        {
            if (_BillingAddresses.Count() < 3)
            {
                MessageBox.Show("Must fill 3rd address slot first");

                return;
            }

            if (_SelectedSlot == AddressSlots.Fourth) return;

            _SelectedSlot = AddressSlots.Fourth;

            ResetTextboxes();

            if (_BillingAddresses.Count() == 4)
            {
                txtAddressLabel.Text = _BillingAddresses[3].FullName;
                txtRegion.Text = _BillingAddresses[3].Region;
                txtPostalCode.Text = _BillingAddresses[3].PostalCode;
                txtPhoneNumber.Text = _BillingAddresses[3].PhoneNumber;
                txtProvince.Text = _BillingAddresses[3].Province;
                txtBarangay.Text = _BillingAddresses[3].Barangay;
                txtCity.Text = _BillingAddresses[3].City;
            }

            EnableTextboxes();
            MessageBox.Show("Selected 4th slot", "4th Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddressLabel.Text) || string.IsNullOrWhiteSpace(txtRegion.Text) || string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtBarangay.Text))
            {
                MessageBox.Show("All fields are required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return ;
            }

            if (_BillingAddresses.Count() >= (int) _SelectedSlot + 1)
            {
                // Update

                _BillingAddresses[(int)_SelectedSlot].UpdateBillingAddress(txtAddressLabel.Text, txtRegion.Text, txtCity.Text, txtPostalCode.Text, txtPhoneNumber.Text, txtProvince.Text, txtBarangay.Text);
            } else
            {
                // Create

                BillingAddress.CreateBillingAddress(_LoggedInUser, txtAddressLabel.Text, txtRegion.Text, txtCity.Text, txtPostalCode.Text, txtPhoneNumber.Text, txtProvince.Text, txtBarangay.Text);
            }

            switch (_SelectedSlot)
            {
                case AddressSlots.First:
                    lblAddressLabel.Text = txtAddressLabel.Text;
                    lblRegion.Text = txtRegion.Text;
                    lblCity.Text = txtCity.Text;
                    lblPostalCode.Text = txtPostalCode.Text;
                    lblPhoneNumber.Text = txtPhoneNumber.Text;
                    lblProvince.Text = txtProvince.Text;
                    lblBarangay.Text = txtBarangay.Text;

                    break;
                case AddressSlots.Second:
                    lblAddressLabel2.Text = txtAddressLabel.Text;
                    lblRegion2.Text = txtRegion.Text;
                    lblCity2.Text = txtCity.Text;
                    lblPostalCode2.Text = txtPostalCode.Text;
                    lblPhoneNumber2.Text = txtPhoneNumber.Text;
                    lblProvince2.Text = txtProvince.Text;
                    lblBarangay2.Text = txtBarangay.Text;

                    break;
                case AddressSlots.Third:
                    lblAddressLabel2.Text = txtAddressLabel.Text;
                    lblRegion2.Text = txtRegion.Text;
                    lblCity2.Text = txtCity.Text;
                    lblPostalCode2.Text = txtPostalCode.Text;
                    lblPhoneNumber2.Text = txtPhoneNumber.Text;
                    lblProvince2.Text = txtProvince.Text;
                    lblBarangay2.Text = txtBarangay.Text;

                    break;
                case AddressSlots.Fourth:
                    lblAddressLabel2.Text = txtAddressLabel.Text;
                    lblRegion2.Text = txtRegion.Text;
                    lblCity2.Text = txtCity.Text;
                    lblPostalCode2.Text = txtPostalCode.Text;
                    lblPhoneNumber2.Text = txtPhoneNumber.Text;
                    lblProvince2.Text = txtProvince.Text;
                    lblBarangay2.Text = txtBarangay.Text;

                    break;
            }
        }

        private void EnableTextboxes()
        {
            txtAddressLabel.Enabled = true;
            txtRegion.Enabled = true;
            txtCity.Enabled = true;
            txtPostalCode.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtProvince.Enabled = true;
            txtBarangay.Enabled = true;
        }

        private void ResetTextboxes()
        {
            txtAddressLabel.ResetText();
            txtRegion.ResetText();
            txtCity.ResetText();
            txtPostalCode.ResetText();
            txtPhoneNumber.ResetText();
            txtProvince.ResetText();
            txtBarangay.ResetText();
        }

    }
}
