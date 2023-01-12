﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Создаёт экзампляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет данные в списке <see cref="ItemsListBox"/>.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateItemsListBox(int index)
        {
            var items = Items;

            ItemsListBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.Name != "")
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                else
                {
                    ItemsListBox.Items.Add($"Item {item.Id}");
                }
            }

            if (-1 <= index && index < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Обновляет данные в выпадающем списке <see cref="CartListBox"/>.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateCartListBox(int index)
        {
            CartListBox.Items.Clear();

            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            var items = _currentCustomer.Cart.Items;

            if (items == null) return;

            foreach (var item in items)
            {
                if (item.Name != "")
                {
                    CartListBox.Items.Add(item.Name);
                }
                else
                {
                    CartListBox.Items.Add($"Item {item.Id}");
                }
            }

            if (-1 <= index && index < CustomersComboBox.Items.Count)
            {
                CustomersComboBox.SelectedIndex = index;
            }

            UpdateAmountLabel();
        }

        /// <summary>
        /// Обновляет данные в Label <see cref="AmountLabel"/>.
        /// </summary>
        private void UpdateAmountLabel()
        {
            if (_currentCustomer == null)
            {
                AmountLabel.Text = "0,00";
                DiscountAmountDigitLabel.Text = "0,00";
                TotalDigitLabel.Text = "0,00";
            }
            else AmountLabel.Text = _currentCustomer.Cart.Amount.ToString("f2");
        }

        /// <summary>
        /// Обновляет данные в выпадающем списке <see cref="CustomersComboBox"/>.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateComboBox(int index)
        {
            var customers = Customers;

            CustomersComboBox.Items.Clear();

            foreach (var customer in customers)
            {
                if (customer.FullName != "")
                {
                    CustomersComboBox.Items.Add(customer.FullName);
                }
                else
                {
                    CustomersComboBox.Items.Add($"Customer {customer.Id}");
                }
            }

            if (-1 <= index && index < CustomersComboBox.Items.Count)
            {
                CustomersComboBox.SelectedIndex = index;
            }
        }
        
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Обновляет информацию на вкладке <see cref="CartsTab"/>.
        /// </summary>
        public void RefreshData()
        {
            _currentCustomer = null;
            UpdateItemsListBox(-1);
            UpdateComboBox(-1);
            UpdateCartListBox(-1);
            UpdateAmountLabel();
            UpdateDiscountDigit();
            UpdateDiscountCheckedListBox();
        }

        private void UpdateDiscountDigit()
        {
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i) && _currentCustomer != null)
                {
                    discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            DiscountAmountDigitLabel.Text = discountAmount.ToString("f2");
            if (_currentCustomer == null) return;
            if (_currentCustomer.Cart.Amount == 0)
            {
                TotalDigitLabel.Text = _currentCustomer.Cart.Amount.ToString("f2");
                return;
            }
            TotalDigitLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString("f2");
        }

        private void UpdateDiscountCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();
            if (_currentCustomer == null) return;
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountCheckedListBox.Items.Add(discount.Info, true);
            }
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountCheckedListBox();
            UpdateDiscountDigit();

            if (CustomersComboBox.SelectedIndex == -1) return;
            
            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountDigit();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Remove(_currentCustomer.Cart.Items[CartListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountDigit();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountDigit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            Order order;
            if (_currentCustomer.IsPriority)
            {
                order = new PriorityOrder(IdGenerator.GetNextId(), OrderStatus.New, _currentCustomer.Address, _currentCustomer.Cart.Items, DateTime.Today, "", _currentCustomer.Cart);
            }
            else
            {
                order = new Order(IdGenerator.GetNextId(), OrderStatus.New, DateTime.Now, _currentCustomer.Address, _currentCustomer.Cart);
            }
            
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            order.DiscountAmount = discountAmount;
            
            _currentCustomer.Orders.Add(order);

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    _currentCustomer.Discounts[i].Apply(_currentCustomer.Cart.Items);
                }
                _currentCustomer.Discounts[i].Update(_currentCustomer.Cart.Items);
            }
            UpdateDiscountCheckedListBox();
            
            _currentCustomer.Cart = new Cart();
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountDigit();
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountDigit();
        }
    }
}
