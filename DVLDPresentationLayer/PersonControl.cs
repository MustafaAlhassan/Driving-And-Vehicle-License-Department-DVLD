using DVLDBusinessLayer;
using DVLDPresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPeople _Person;

        public PersonControl()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public PersonControl(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            _FillCountriesInComoboBox();
            cmbCountry.SelectedIndex = 82;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPeople();
                return;
            }

            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No People with ID = " + _Person);
                OnCloseClick?.Invoke();
                return;
            }

            lblMode.Text = "Edit Person";
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.ImagePath != "")
            {
                picBox.Load(_Person.ImagePath);
            }

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            //llRemoveImage.Visible = (_Person.ImagePath != "");

            cmbCountry.SelectedIndex = cmbCountry.FindString(clsPeople.Find(_Person.NationalityCountryID).CountryName);
        }

        public event Action OnCloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnCloseClick?.Invoke();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_boy;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_girl;
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void PersonControl_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            rbMale.Checked = true;
            _LoadData();
        }

        private void txbFirst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txbSecond_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, "Second Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txtSecondName, "");
            }
        }

        private void txbLast_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "National Number Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "National Number Should have a value!");
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                    errorProvider1.SetError(txtEmail, "Email Not Correct!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Address Should have a value!");
            } 
            else
            {
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CountryID = clsCountries.Find(cmbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Gender = rbMale.Checked ? (byte)0 : (byte)1;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.NationalityCountryID = CountryID;

            if (picBox.ImageLocation != null)
                _Person.ImagePath = picBox.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lblMode.Text = "Edit Person";
            lblPersonID.Text = _Person.PersonID.ToString();
        }

        //private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        //    openFileDialog1.FilterIndex = 1;
        //    openFileDialog1.RestoreDirectory = true;

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        // Process the selected file
        //        string selectedFilePath = openFileDialog1.FileName;
        //        //MessageBox.Show("Selected Image is:" + selectedFilePath);

        //        pictureBox1.Load(selectedFilePath);
        //        // ...
        //    }
        //}

        //private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //    pictureBox1.ImageLocation = null;
        //    llRemoveImage.Visible = false;
        //}
    }
}
