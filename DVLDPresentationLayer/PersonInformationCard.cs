using DVLDBusinessLayer;
using DVLDPresentationLayer.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class PersonInformationCard : UserControl
    {
        int _PersonID;
        clsPeople _Person;

        public PersonInformationCard()
        {
            InitializeComponent();
        }

        public void LoadData(int PersonID = -1)
        {
            _PersonID = PersonID;
            _LoadData();
        }

        private void _LoadData()
        {
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                OnCloseClick?.Invoke();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            lblName.Text = _Person.FirstName + " " +
                _Person.SecondName + " " +
                _Person.ThirdName + " " +
                _Person.LastName + " ";
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblCountry.Text = _Person.CountryName;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                picBox.Load(_Person.ImagePath);
            }
            else
            {
                picBox.ImageLocation = null;
                
                if (_Person.Gender == 0)
                {
                    picBox.Image = Resources.person_boy;
                    lblGender.Text = "Male";
                }
                else
                {
                    picBox.Image = Resources.person_girl;
                    lblGender.Text = "Female";
                }
            }
        }

        public event Action OnCloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnCloseClick?.Invoke();
        }

        private void linkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonForm form = new PersonForm(_PersonID);
            form.ShowDialog();
            _LoadData();
        }
    }
}
