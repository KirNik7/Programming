using System.Drawing;

namespace ProductsApp.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Название производителя.
        /// </summary>
        private string _manufacturer;

        /// <summary>
        /// Количество оставшегося на складе товара.
        /// </summary>
        private int _countInStock;

        /// <summary>
        /// Общее количество товаров.
        /// </summary>
        private static int _allProductsCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Product"/>.
        /// </summary>
        public Product()
        {
            Name = "Product";
            Manufacturer = "Manufacturer";
            Category = "Other";
            CountInStock = 0;
            _allProductsCount++;
            _id = _allProductsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name">Название товара. 
        /// Должно содержать от 1 до 100 символов (включительно).</param>
        /// <param name="manufacturer">Название производителя. 
        /// Должно содержать от 1 до 100 символов (включительно).</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="countInStock">Количество оставшегося на складе товара.</param>
        public Product(string name, string manufacturer, string category, int countInStock)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            CountInStock = countInStock;
            _allProductsCount++;
            _id = _allProductsCount;
        }

        /// <summary>
        /// Возвращает и задаёт название товара. 
        /// Должно содержать от 1 до 100 символов (включительно).
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 100, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название производителя. 
        /// Должно содержать от 1 до 100 символов (включительно).
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 100, nameof(Manufacturer));
                _manufacturer = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество оставшегося на складе товара.
        /// </summary>
        public int CountInStock
        {
            get
            {
                return _countInStock;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(CountInStock), value);
                _countInStock = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public string Category { get; set; }

        public string ImageInBase64 { get; set; }
    }
}
