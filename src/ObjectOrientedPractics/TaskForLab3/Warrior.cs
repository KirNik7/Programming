namespace TaskForLab3
{
    /// <summary>
    /// Хранит информацию о воине.
    /// </summary>
    public class Warrior
    {
        /// <summary>
        /// Имя воина.
        /// </summary>
        private string _name;

        /// <summary>
        /// Количество здоровья воина.
        /// </summary>
        private int _HP;

        /// <summary>
        /// Урон воина.
        /// </summary>
        private int _damage;

        /// <summary>
        /// Экипировка воина.
        /// </summary>
        private List<Armour> _equipment;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Warrior"/>.
        /// </summary>
        /// <param name="name">Имя воина.</param>
        /// <param name="HP">Количество здоровья воина.</param>
        /// <param name="damage">Урон воина.</param>
        /// <param name="equipment">Экипировка воина.</param>
        public Warrior(string name, int HP, int damage, List<Armour> equipment)
        {
            _name = name;
            _HP = HP;
            _damage = damage;
            _equipment = equipment;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Warrior"/>.
        /// </summary>
        public Warrior()
        {
            
        }
        
        /// <summary>
        /// Метод для вывода информации о воине.
        /// </summary>
        /// <param name="warrior">Воин.</param>
        public void ShowInfo(Warrior warrior)
        {
            Console.WriteLine("Name: " + warrior.Name);
            Console.WriteLine("HP: " + warrior.HP);
            Console.WriteLine("Damage: " + warrior.Damage);
            Console.Write("Equipment (cost):");
            foreach (var item in warrior.Equipment)
            {
                Console.Write($" {item.Name} ({item.Cost});");
            }
            Console.WriteLine();

            int cost = 0;
            foreach (var item in warrior.Equipment)
            {
                cost += item.Cost;
            }

            Console.WriteLine("Total cost of equipment: " + cost);
            Console.WriteLine();
        }

        /// <summary>
        /// Задаёт и возвращает имя воина.
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
        /// Задаёт и возвращает количество здоровья воина.
        /// </summary>
        public int HP
        {
            get 
            { 
                return _HP; 
            }
            
            set 
            {
                if (!(value > 0))
                {
                    throw new ArgumentException(
                        $"{nameof(HP)} must be greater than 0");
                }
                _HP = value; 
            }
        }

        /// <summary>
        /// Задаёт и возвращает урон воина.
        /// </summary>
        public int Damage
        {
            get 
            { 
                return _damage; 
            }
            
            set 
            {
                if (!(value > 0))
                {
                    throw new ArgumentException(
                        $"{nameof(Damage)} must be greater than 0");
                }
                _damage = value; 
            }
        }

        /// <summary>
        /// Задаёт и возвращает экипировку воина.
        /// </summary>
        public List<Armour> Equipment
        {
            get 
            { 
                return _equipment; 
            }
            
            set 
            { 
                _equipment = value; 
            }
        }
    }
}
