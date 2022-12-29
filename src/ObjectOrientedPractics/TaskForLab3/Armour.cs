namespace TaskForLab3
{
    /// <summary>
    /// Хранит информацию о броне.
    /// </summary>
    public class Armour
    {
        /// <summary>
        /// Название брони.
        /// </summary>
        private string _name;

        /// <summary>
        /// Тип брони.
        /// </summary>
        private ArmourType _type;

        /// <summary>
        /// Цена брони.
        /// </summary>
        private int _cost;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Armour"/>.
        /// </summary>
        /// <param name="name">Название брони.</param>
        /// <param name="type">Тип брони.</param>
        /// <param name="cost">Цена брони.</param>
        public Armour(string name, ArmourType type, int cost)
        {
            _name = name;
            _type = type;
            _cost = cost;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Armour"/>.
        /// </summary>
        public Armour()
        {
            
        }

        /// <summary>
        /// Задаёт и возвращает название брони.
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }

            set 
            { 
                _name = value; 
            }
        }

        /// <summary>
        /// Задаёт и возвращает тип брони.
        /// </summary>
        public ArmourType Type
        {
            get 
            { 
                return _type; 
            }

            set 
            { 
                _type = value; 
            }
        }
        
        /// <summary>
        /// Задаёт и возвращает цену брони.
        /// </summary>
        public int Cost
        {
            get 
            { 
                return _cost; 
            }
            
            set 
            {
                if (!(value >= 0))
                {
                    throw new ArgumentException(
                        $"{nameof(Cost)} must be greater or equal to 0");
                }
                _cost = value; 
            }
        }
    }
}
