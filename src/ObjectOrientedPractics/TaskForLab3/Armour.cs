namespace TaskForLab3
{
    public class Armour
    {
        private string _name;

        private ArmourType _type;

        private int _cost;

        public Armour(string name, ArmourType type, int cost)
        {
            _name = name;
            _type = type;
            _cost = cost;
        }
        
        public Armour()
        {
            
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
