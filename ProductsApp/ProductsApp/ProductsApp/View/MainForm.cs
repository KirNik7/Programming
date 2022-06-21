using ProductsApp.Model;
using ProductsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductsApp.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллеция товаров.
        /// </summary>
        private List<Product> _products;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Product _currentProduct;

        /// <summary>
        /// Текст поискового запроса.
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                ProductCategoryComboBox.Items.Add(item);
            }

            _products = Serializer.Deserialize();

            if (_products.Count == 0)
            {
                ProductGroupBox.Enabled = false;
                SearchTextBox.Enabled = false;
            }

            UpdateListBox(-1);
        }

        /// <summary>
        /// Обновляет данные в списке ProductsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Product> products;

            ProductsListBox.Items.Clear();

            if (_searchText != "" && _searchText != null)
            {
                products = SearchProducts();
            }
            else
            {
                products = _products;
            }

            foreach (var product in products)
            {
                if (product.Name != null)
                {
                    ProductsListBox.Items.Add(product.Name);
                }
                else
                {
                    ProductsListBox.Items.Add($"Product {product.Id}");
                }
            }

            if (-1 <= index && index < ProductsListBox.Items.Count)
            {
                ProductsListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Огранизует поиск полей у объектов, 
        /// удовлетворяющих введенному в строку поиска значению.
        /// </summary>
        /// <returns>Возвращает список объектов, удовлетворяющих условию поиска.</returns>
        private List<Product> SearchProducts()
        {
            var result = from product in _products
                         where product.Name.Contains(_searchText) ||
                         product.Manufacturer.Contains(_searchText) ||
                         product.Category.Contains(_searchText) ||
                         product.CountInStock.ToString().Contains(_searchText)
                         select product;
            return result.ToList();
        }

        /// <summary>
        /// Сортировка _products.
        /// </summary>
        private void SortingProducts()
        {
            _products = (from product in _products
                         orderby product.Name
                         select product).ToList();
        }

        /// <summary>
        /// Очищает поля для вывода информации о товаре.
        /// </summary>
        private void ClearInfo()
        {
            ProductsListBox.SelectedIndex = -1;
            ProductNameTextBox.Clear();
            ProductManufacturerTextBox.Clear();
            ProductCategoryComboBox.SelectedIndex = -1;
            ProductInStockTextBox.Clear();
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            var product = new Product();
            _products.Add(product);
            SortingProducts();
            UpdateListBox(_products.IndexOf(product));
            ProductGroupBox.Enabled = true;
            SearchTextBox.Enabled = true;
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1)
            {
                return;
            }

            _products.RemoveAt(ProductsListBox.SelectedIndex);

            if (_products.Count == 0)
            {
                ProductGroupBox.Enabled = false;
                SearchTextBox.Enabled = false;
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                ProductGroupBox.Enabled = true;
                SearchTextBox.Enabled = true;
            }
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1)
            {
                return;
            }

            if (_searchText == "" || _searchText == null)
            {
                _currentProduct = _products[ProductsListBox.SelectedIndex];
            }
            else
            {
                _currentProduct = SearchProducts()[ProductsListBox.SelectedIndex];
            }

            ProductNameTextBox.Text = _currentProduct.Name;
            ProductManufacturerTextBox.Text = _currentProduct.Manufacturer;
            ProductCategoryComboBox.Text = _currentProduct.Category;
            ProductInStockTextBox.Text = _currentProduct.CountInStock.ToString();
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1) return;

            try
            {
                _currentProduct.Name = ProductNameTextBox.Text;
                ProductNameTextBox.BackColor = AppColors.CorrectColor;
                SortingProducts();
                UpdateListBox(_products.IndexOf(_currentProduct));
            }
            catch
            {
                ProductNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ProductManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1) return;

            try
            {
                _currentProduct.Manufacturer = ProductManufacturerTextBox.Text;
                ProductManufacturerTextBox.BackColor = AppColors.CorrectColor;
                SortingProducts();
                UpdateListBox(_products.IndexOf(_currentProduct));
            }
            catch
            {
                ProductManufacturerTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1) return;

            try
            {
                _currentProduct.Category = ProductCategoryComboBox.SelectedItem.ToString();
                ProductCategoryComboBox.BackColor = AppColors.CorrectColor;
                SortingProducts();
                UpdateListBox(_products.IndexOf(_currentProduct));
            }
            catch
            {
                ProductCategoryComboBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ProductInStockTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1) return;

            try
            {
                _currentProduct.CountInStock = int.Parse(ProductInStockTextBox.Text);
                ProductInStockTextBox.BackColor = AppColors.CorrectColor;
                SortingProducts();
                UpdateListBox(_products.IndexOf(_currentProduct));
            }
            catch
            {
                ProductInStockTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _searchText = SearchTextBox.Text;
            ClearInfo();
            UpdateListBox(-1);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_products);
        }

        private void AddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.add_24x24_black;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.add_24x24;
        }

        private void RemovePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.cross_circle_24x24_black;
        }

        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.cross_circle_24x24;
        }
    }
}
