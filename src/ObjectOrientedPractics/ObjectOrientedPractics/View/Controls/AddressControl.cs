using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public Address Address
        {
            get 
            { 
                return _address; 
            }
            
            set 
            { 
                _address = value;
                UpdateAddressTextBoxes(_address);
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void UpdateAddressTextBoxes(Address address)
        {
            AddressIndexTextBox.Text = address.Index.ToString();
            AddressCountryTextBox.Text = address.Country;
            AddressCityTextBox.Text = address.City;
            AddressStreetTextBox.Text = address.Street;
            AddressBuildingTextBox.Text = address.Building;
            AddressApartmentTextBox.Text = address.Apartment;
        }

        public void AddressClearInfo()
        {
            AddressIndexTextBox.Clear();
            AddressCountryTextBox.Clear();
            AddressCityTextBox.Clear();
            AddressStreetTextBox.Clear();
            AddressBuildingTextBox.Clear();
            AddressApartmentTextBox.Clear();
            AddressIndexTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddressIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(AddressIndexTextBox.Text);
                AddressIndexTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressIndexTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddressCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = AddressCountryTextBox.Text;
                AddressCountryTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressCountryTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddressCityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = AddressCityTextBox.Text;
                AddressCityTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressCityTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddressStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = AddressStreetTextBox.Text;
                AddressStreetTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressStreetTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddressBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = AddressBuildingTextBox.Text;
                AddressBuildingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressBuildingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddressApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = AddressApartmentTextBox.Text;
                AddressApartmentTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                AddressApartmentTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
