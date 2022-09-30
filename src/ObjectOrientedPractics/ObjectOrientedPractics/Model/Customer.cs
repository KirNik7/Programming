﻿using static ObjectOrientedPractics.Services.IdGenerator;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.
        /// Должно содержать до 200 символов (включительно).</param>
        /// <param name="address">Адрес доставки покупателя.
        /// Должно содержать до 500 символов (включительно).</param>
        public Customer(string fullname, string address)
        {
            _id = GetNextId();
            FullName = fullname;
            Address = address;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = GetNextId();
            FullName = "Full Name";
            Address = "Address";
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// Должно содержать до 200 символов (включительно).
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки покупателя.
        /// Должно содержать до 500 символов (включительно).
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get { return _id; } }
    }
}
