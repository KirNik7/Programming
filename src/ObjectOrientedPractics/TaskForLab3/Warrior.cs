namespace TaskForLab3
{
    public class Warrior
    {
        private string _name;

        private int _HP;

        private int _damage;

        private List<Armour> _equipment;

        public Warrior(string name, int HP, int damage, List<Armour> equipment)
        {
            _name = name;
            _HP = HP;
            _damage = damage;
            _equipment = equipment;
        }
        
        public Warrior()
        {
            
        }
        
        public void ShowInfo(Warrior warrior)
        {
            Console.WriteLine("Name: " + warrior._name);
            Console.WriteLine("HP: " + warrior._HP);
            Console.WriteLine("Damage: " + warrior._damage);
            Console.Write("Equipment: ");
            for (int i = 0; i < warrior._equipment.Count; i++)
            {
                Console.Write(warrior._equipment[i].Name + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("Cost: " + GetCost(Equipment));
        }

        private int GetCost(List<Armour> equipment)
        {
            int cost = 0;
            foreach (var item in equipment)
            {
                cost += item.Cost;
            }
            return cost;
        }

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
