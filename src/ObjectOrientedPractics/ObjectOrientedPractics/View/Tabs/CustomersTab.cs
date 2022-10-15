using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            AddressCustomerControl.AddressClearInfo();
            DisabledCustomersTextBoxes();
        }

        /// <summary>
        /// Обновляет данные в списке CustomersListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Customer> customers = Customers;

            CustomersListBox.Items.Clear();

            foreach (var customer in customers)
            {
                if (customer.FullName != "")
                {
                    CustomersListBox.Items.Add(customer.FullName);
                }
                else
                {
                    CustomersListBox.Items.Add($"Customer {customer.Id}");
                }
            }

            if (-1 <= index && index < CustomersListBox.Items.Count)
            {
                CustomersListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Включает поля для ввода пользователем.
        /// </summary>
        private void EnabledCustomersTextBoxes()
        {
            CustomerFullNameTextBox.Enabled = true;
            AddressCustomerControl.Enabled = true;
        }

        /// <summary>
        /// Отключает поля для ввода пользователем.
        /// </summary>
        private void DisabledCustomersTextBoxes()
        {
            CustomerFullNameTextBox.Enabled = false;
            AddressCustomerControl.Enabled = false;
        }

        /// <summary>
        /// Очищает поля для вывода информации о покупателе.
        /// </summary>
        private void ClearInfo()
        {
            CustomersListBox.SelectedIndex = -1;
            CustomerIDTextBox.Clear();
            CustomerFullNameTextBox.Clear();
            AddressCustomerControl.AddressClearInfo();
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            Customers.Add(customer);
            UpdateListBox(Customers.IndexOf(customer));
            EnabledCustomersTextBoxes();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                DisabledCustomersTextBoxes();
                return;
            }

            Customers.RemoveAt(CustomersListBox.SelectedIndex);

            if (Customers.Count == 0)
            {
                DisabledCustomersTextBoxes();
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                EnabledCustomersTextBoxes();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            EnabledCustomersTextBoxes();
            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            CustomerFullNameTextBox.Text = _currentCustomer.FullName;
            AddressCustomerControl.Address = _currentCustomer.Address;
        }

        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.FullName = CustomerFullNameTextBox.Text;
                CustomerFullNameTextBox.BackColor = AppColors.CorrectColor;
                UpdateListBox(Customers.IndexOf(_currentCustomer));
            }
            catch
            {
                CustomerFullNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
