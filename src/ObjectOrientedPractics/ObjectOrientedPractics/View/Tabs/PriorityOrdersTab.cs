﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        private PriorityOrder _currentPriorityOrder;

        private Random _randomForAddItem;

        public PriorityOrdersTab()
        {
            InitializeComponent();

            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();
            IDSelectedOrderTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedSelectedOrderTextBox.Text = _currentPriorityOrder.Date.ToString();

            foreach (var time in _deliveryTime)
            {
                DeliveryTimeSelectedOrderComboBox.Items.Add(time);
            }
            DeliveryTimeSelectedOrderComboBox.SelectedIndex = 0;
            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatusValues)
            {
                StatusSelectedOrderComboBox.Items.Add(status);
            }
            StatusSelectedOrderComboBox.SelectedIndex = 0;
            SelectedOrderAddressControl.Address = _currentPriorityOrder.Address;

            _randomForAddItem = new Random();
        }

        public List<Item> Items { get; set; }

        private void CreateNewPriorityOrder()
        {
            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();
            SelectedOrderAddressControl.Address = _currentPriorityOrder.Address;
            IDSelectedOrderTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedSelectedOrderTextBox.Text = _currentPriorityOrder.Date.ToString();
            DeliveryTimeSelectedOrderComboBox.SelectedIndex = 0;
            StatusSelectedOrderComboBox.SelectedIndex = 0;
            OrderItemsListBox.Items.Clear();
        }

        private void StatusSelectedOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.OrderStatus = (OrderStatus)StatusSelectedOrderComboBox.SelectedItem;
        }

        private void DeliveryTimeSelectedOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeSelectedOrderComboBox.SelectedItem;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = Items[_randomForAddItem.Next(Items.Count)];
            _currentPriorityOrder.Items.Add(item);
            OrderItemsListBox.Items.Add(item.Name);
            AmountSelectedOrderLabel.Text = _currentPriorityOrder.AmountOrder.ToString("f2");
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemsListBox.SelectedIndex;
            if (index == -1) return;

            _currentPriorityOrder.Items.RemoveAt(index);
            OrderItemsListBox.Items.RemoveAt(index);
            AmountSelectedOrderLabel.Text = _currentPriorityOrder.AmountOrder.ToString("f2");
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            CreateNewPriorityOrder();
            AmountSelectedOrderLabel.Text = _currentPriorityOrder.AmountOrder.ToString("f2");
        }
    }
}
