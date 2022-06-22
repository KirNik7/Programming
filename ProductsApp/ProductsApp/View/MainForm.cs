using ProductsApp.Model;
using ProductsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        /// Создаёт экзампляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            ProductGroupBox.Enabled = false;

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                ProductCategoryComboBox.Items.Add(item);
            }

            _products = Serializer.Deserialize();

            if (_products.Count == 0)
            {
                ProductGroupBox.Enabled = false;
            }

            UpdateListBox(-1);
        }

        /// <summary>
        /// Обновляет данные в списке ProductsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Product> products = _products;

            ProductsListBox.Items.Clear();

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
        /// Сортировка _products.
        /// </summary>
        private void SortingProducts()
        {
            _products = (from product in _products
                         orderby product.Name
                         select product).ToList();
            UpdateListBox(-1);
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
            ProductCountInStockTextBox.Clear();
        }

        /// <summary>
        /// Конвертирует строку Base64 в изображение Image.
        /// </summary>
        /// <param name="base64">Строка в Base64.</param>
        /// <returns>Объект класса <see cref="Image"/>.</returns>
        private Image ConvertFromBase64StringToImage(string base64String)
        {
            if (base64String == null) return null;

            var byteArrayImage = Convert.FromBase64String(base64String);
            return Image.FromStream(new MemoryStream(byteArrayImage));
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            var product = new Product();
            _products.Add(product);
            SortingProducts();
            UpdateListBox(_products.IndexOf(product));
            ProductGroupBox.Enabled = true;
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
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                ProductGroupBox.Enabled = true;
            }
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex == -1)
            {
                return;
            }

            ProductGroupBox.Enabled = true;
            _currentProduct = _products[ProductsListBox.SelectedIndex];
            ProductNameTextBox.Text = _currentProduct.Name;
            ProductManufacturerTextBox.Text = _currentProduct.Manufacturer;
            ProductCategoryComboBox.Text = _currentProduct.Category;
            ProductCountInStockTextBox.Text = _currentProduct.CountInStock.ToString();
            ProductImagePictureBox.Image = ConvertFromBase64StringToImage(
                                           _currentProduct.ImageInBase64);
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
                _currentProduct.CountInStock = int.Parse(ProductCountInStockTextBox.Text);
                ProductCountInStockTextBox.BackColor = AppColors.CorrectColor;
                SortingProducts();
                UpdateListBox(_products.IndexOf(_currentProduct));
            }
            catch
            {
                ProductCountInStockTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddProductImagePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите изображение для товара";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG Image files (*.png)|*.png|JPEG Image " +
                    "files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentProduct.ImageInBase64 = Convert.ToBase64String(
                                                    File.ReadAllBytes(
                                                    openFileDialog.FileName));
                }
            }
            ProductImagePictureBox.Image = ConvertFromBase64StringToImage(
                                           _currentProduct.ImageInBase64);
        }

        private void RemoveProductImagePictureBox_Click(object sender, EventArgs e)
        {
            const string message =
        "Вы действительно хотите удалить изображение этого товара?";
            const string caption = "Удаление изображение товара";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
            
            if (result == DialogResult.No)
            {
                return;
            }

            _currentProduct.ImageInBase64 = null;
            ProductImagePictureBox.Image = ConvertFromBase64StringToImage(
                                           _currentProduct.ImageInBase64);
        }

        private void AddProductImagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddProductImagePictureBox.Image = Properties.Resources.add_image_32x32_black;
        }

        private void AddProductImagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddProductImagePictureBox.Image = Properties.Resources.add_image_32x32;
        }

        private void RemoveProductImagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveProductImagePictureBox.Image = Properties.Resources.remove_image_32x32_black;
        }

        private void RemoveProductImagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveProductImagePictureBox.Image = Properties.Resources.remove_image_32x32;
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_products);
        }
    }
}
