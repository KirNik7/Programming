using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Только для чтения.
        /// </summary>
        private bool _readOnly;

        /// <summary>
        /// Создаёт и экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт значение, указывающее, может ли 
        /// пользователь изменять данные в элементе управления.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;

                if (value)
                {
                    AddressIndexTextBox.ReadOnly = true;
                    AddressCountryTextBox.ReadOnly = true;
                    AddressCityTextBox.ReadOnly = true;
                    AddressStreetTextBox.ReadOnly = true;
                    AddressBuildingTextBox.ReadOnly = true;
                    AddressApartmentTextBox.ReadOnly = true;
                }
            }
        }

        /// <summary>
        /// Обновляет информацию об адресе.
        /// </summary>
        /// <param name="address">Адрес.</param>
        public void UpdateAddressTextBoxes(Address address)
        {
            AddressIndexTextBox.Text = address.Index.ToString();
            AddressCountryTextBox.Text = address.Country;
            AddressCityTextBox.Text = address.City;
            AddressStreetTextBox.Text = address.Street;
            AddressBuildingTextBox.Text = address.Building;
            AddressApartmentTextBox.Text = address.Apartment;
        }

        /// <summary>
        /// Очищает информацию об адресе в элементах управления.
        /// </summary>
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
                AddressControlToolTip.Show("The index is a six-digit integer.", 
                    AddressIndexTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressIndexTextBox);
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
                AddressControlToolTip.Show("The name of the country must " +
                    "contain no more than 50 characters.",
                    AddressCountryTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressCountryTextBox);
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
                AddressControlToolTip.Show("The name of the city must " +
                    "contain no more than 50 characters.",
                    AddressCityTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressCityTextBox);
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
                AddressControlToolTip.Show("The street name must contain " +
                    "no more than 100 characters.",
                    AddressCityTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressCityTextBox);
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
                AddressControlToolTip.Show("The building number must contain " +
                    "no more than 10 characters.",
                    AddressBuildingTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressBuildingTextBox);
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
                AddressControlToolTip.Show("The apartment number must contain " +
                    "no more than 10 characters.",
                    AddressApartmentTextBox);
                return;
            }

            AddressControlToolTip.Hide(AddressApartmentTextBox);
        }
    }
}
