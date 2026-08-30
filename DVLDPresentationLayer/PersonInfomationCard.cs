using DVLDBusinessLayer;
using DVLDPresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class PersonInfomationCard : UserControl
    {
        int _PersonID;
        clsPeople _Person;

        public PersonInfomationCard()
        {
            InitializeComponent();
        }

        public void LoadData(int PersonID)
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
            lblGender.Text = _Person.Gender.ToString();
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblCountry.Text = _Person.CountryName;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToLongDateString();

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                picBox.Load(_Person.ImagePath);
            }
            else
            {
                picBox.ImageLocation = null;
                
                if (lblGender.Text == "Male")
                    picBox.Image = Resources.person_boy;
                else
                    picBox.Image = Resources.person_girl;
            }
        }

        public event Action OnCloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnCloseClick?.Invoke();
        }
    }
}
