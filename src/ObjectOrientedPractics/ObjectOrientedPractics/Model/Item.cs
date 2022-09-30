using static ObjectOrientedPractics.Services.IdGenerator;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.
        /// Должно содержать до 200 символов (включительно).</param>
        /// <param name="info">Описание товара.
        /// Должно содержать до 1000 символов (включительно).</param>
        /// <param name="cost">Стоимость товара.
        /// Должно быть в диапазоне от 0 до 100000 (включительно).</param>
        public Item(string name, string info, double cost)
        {
            _id = GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = GetNextId();
            Name = "Item";
            Info = "Info";
            Cost = 0;
        }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// Должно содержать до 200 символов (включительно).
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара.
        /// Должно содержать до 1000 символов (включительно).
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                AssertStringOnLength(value, 200, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Вовзращает и задаёт стоимость товара.
        /// Должно быть в диапазоне от 0 до 100000 (включительно).
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает ID товара.
        /// </summary>
        public int Id { get { return _id; } }
    }
}
