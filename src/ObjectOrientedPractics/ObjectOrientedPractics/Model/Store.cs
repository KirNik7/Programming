using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях и магазинах.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Товар.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Продавец.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        /// <param name="items">Товар.</param>
        /// <param name="customers">Продавец.</param>
        public Store(List<Item> items, List<Customer> customers)
        {
            Items = items;
            Customers = customers;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }

        /// <summary>
        /// Возвращает и задаёт товар.
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
        /// Возвращает и задаёт покупателя.
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
    }
}
