using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

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
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        private void UpdateAddressTextBoxes()
        {
            AddressIndexTextBox.Text = _address.Index.ToString();
            AddressCountryTextBox.Text = _address.Country;
            AddressCityTextBox.Text = _address.City;
            AddressStreetTextBox.Text = _address.Street;
            AddressBuildingTextBox.Text = _address.Building;
            AddressApartmentTextBox.Text = _address.Apartment;
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
