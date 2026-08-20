using DVLDBusinessLayer;
using DVLDPresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_boy;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_girl;
        }

        private void PersonControl_Load(object sender, EventArgs e)
        {
            DataTable dt = clsCountries.GetAllCountries();

            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.DataSource = dt;

            cmbCountry.SelectedIndex = 82;
            dtpDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpDate.MinDate = DateTime.Now.AddYears(-100);
            rbMale.Checked = true;
        }

        private void txbFirst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbFirst.Text))
            {
                errorProvider1.SetError(txbFirst, "First Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txbFirst, "");
            }
        }

        private void txbSecond_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSecond.Text))
            {
                errorProvider1.SetError(txbSecond, "Second Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txbSecond, "");
            }
        }

        private void txbLast_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbLast.Text))
            {
                errorProvider1.SetError(txbLast, "Last Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txbLast, "");
            }
        }

        private void txbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNationalNo.Text))
            {
                errorProvider1.SetError(txbNationalNo, "National Number Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txbNationalNo, "");
            }
        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                errorProvider1.SetError(txbPhone, "National Number Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txbPhone, "");
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txbEmail.Text) && !IsValidEmail(txbEmail.Text))
            {
                    errorProvider1.SetError(txbEmail, "Email Not Correct!");
            }
            else
            {
                errorProvider1.SetError(txbEmail, "");
            }
        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbAddress.Text))
            {
                errorProvider1.SetError(txbAddress, "Address Should have a value!");
            } 
            else
            {
                errorProvider1.SetError(txbAddress, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
