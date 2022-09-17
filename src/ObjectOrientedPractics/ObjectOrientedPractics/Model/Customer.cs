using System.Xml.Linq;
using static ObjectOrientedPractics.Services.IdGenerator;

namespace ObjectOrientedPractics.Model
{
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

        public Customer(string fullname, string address)
        {
            _id = GetNextId();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// Должно содержать от 1 до 200 символов (включительно).
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адресс доставки покупателя.
        /// Должно содержать от 1 до 500 символов (включительно).
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 500, nameof(Address));
                _address = value;
            }
        }
    }
}
