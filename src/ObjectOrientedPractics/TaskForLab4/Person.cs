namespace TaskForLab4
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person(string firstName,
                      string lastName,
                      int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            
            set 
            { 
                _firstName = value; 
            }
        }

        public string LastName
        {
            get 
            { 
                return _lastName; 
            }
            
            set 
            { 
                _lastName = value; 
            }
        }

        public int Age
        {
            get 
            { 
                return _age; 
            }
            
            set 
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater or equal to 0");
                }
            }
        }
     }
}
