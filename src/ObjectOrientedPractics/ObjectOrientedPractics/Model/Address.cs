﻿using System;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион покупателя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт) покупателя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения покупателя.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс покупателя.
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).</param>
        /// <param name="country">Страна/регион покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="city">Город (населенный пункт) покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="street">Улица покупателя.
        /// Должно содержать до 100 символов (включительно).</param>
        /// <param name="building">Номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        /// <param name="apartment">Номер квартиры/помещения покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        public Address(int index, string country, string city,
                       string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Возвращает и задаёт почтовый индекс покупателя.
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                AssertValueInRange(value, 100000, 999999, nameof(Index));
                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион покупателя.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                AssertStringOnLength(value, 50, nameof(Country));
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт город (населенный пункт) покупателя.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                AssertStringOnLength(value, 50, nameof(City));
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу покупателя.
        /// Должно содержать до 100 символов (включительно).
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                AssertStringOnLength(value, 100, nameof(Street));
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                AssertStringOnLength(value, 10, nameof(Building));
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                AssertStringOnLength(value, 10, nameof(Apartment));
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
