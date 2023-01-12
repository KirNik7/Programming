using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private List<Item> _items;

        private PointsDiscount _discount;

        private double _amount = 0;

        public DiscountsTab()
        {
            InitializeComponent();
        }

        public List<Item> Items
        {
            get => _items;
            set
            {
                _discount = new PointsDiscount();
                _items = value;

                if (_items != null)
                {
                    foreach (Item item in _items)
                    {
                        _amount += item.Cost;
                    }
                }

                SetAmount();
            }
        }

        private void SetAmount()
        {

            ProductsAmountDigitLabel.Text = _amount.ToString("f2");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DiscountAmountDigitLabel.Text = _discount.Calculate(_items).ToString("f2");
            InfoLabel.Text = $"Info: {_discount.Info}";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _amount -= _discount.Calculate(_items);
            _discount.Apply(_items);
            ProductsAmountDigitLabel.Text = _amount.ToString("f2");
            InfoLabel.Text = $"Info: {_discount.Info}";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _discount.Update(_items);
            InfoLabel.Text = $"Info: {_discount.Info}";
        }
    }
}
