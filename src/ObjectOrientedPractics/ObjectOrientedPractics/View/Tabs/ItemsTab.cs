using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                ItemCategoryComboBox.Items.Add(item);
            }

            DisabledItemsTextBoxes();
        }

        /// <summary>
        /// Обновляет данные в списке ItemsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Item> items = Items;

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
        /// Включает поля для ввода пользователем.
        /// </summary>
        private void EnabledItemsTextBoxes()
        {
            ItemCostTextBox.Enabled = true;
            ItemNameTextBox.Enabled = true;
            ItemInfoTextBox.Enabled = true;
            ItemCategoryComboBox.Enabled = true;
        }

        /// <summary>
        /// Отключает поля для ввода пользователем.
        /// </summary>
        private void DisabledItemsTextBoxes()
        {
            ItemCostTextBox.Enabled = false;
            ItemNameTextBox.Enabled = false;
            ItemInfoTextBox.Enabled = false;
            ItemCategoryComboBox.Enabled = false;
        }

        /// <summary>
        /// Очищает поля для вывода информации о товаре.
        /// </summary>
        private void ClearInfo()
        {
            ItemsListBox.SelectedIndex = -1;
            ItemIDTextBox.Clear();
            ItemCostTextBox.Clear();
            ItemNameTextBox.Clear();
            ItemInfoTextBox.Clear();
            ItemCategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаоров.
        /// </summary>
        public List<Item> Items { get; set; }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var item = new Item();
            Items.Add(item);
            UpdateListBox(Items.IndexOf(item));
            EnabledItemsTextBoxes();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            Items.RemoveAt(ItemsListBox.SelectedIndex);

            if (Items.Count == 0)
            {
                DisabledItemsTextBoxes();
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                EnabledItemsTextBoxes();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            EnabledItemsTextBoxes();
            _currentItem = Items[ItemsListBox.SelectedIndex];
            ItemIDTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;
            ItemCategoryComboBox.Text = _currentItem.Category.ToString();
            if (_currentItem.Category == "")
            {
                ItemCategoryComboBox.SelectedItem = null;
            }
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Cost = double.Parse(ItemCostTextBox.Text);
                ItemCostTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                ItemCostTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Name = ItemNameTextBox.Text;
                ItemNameTextBox.BackColor = AppColors.CorrectColor;
                UpdateListBox(Items.IndexOf(_currentItem));
            }
            catch
            {
                ItemNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Info = ItemInfoTextBox.Text;
                ItemInfoTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                ItemInfoTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                if (ItemCategoryComboBox.SelectedItem == null) return;
                _currentItem.Category = ItemCategoryComboBox.SelectedItem.ToString();
                ItemCategoryComboBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                ItemCategoryComboBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
