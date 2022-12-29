namespace TaskForLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            
            Console.Write("Enter warrior name: ");
            warrior.Name = Console.ReadLine();

            Console.Write("Enter HP: ");
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int number;

                    if (int.TryParse(input, out number))
                    {
                        warrior.HP = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, need only numbers. Try again.");
                    }
                    
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need > 0. Try again.");
                }
            }

            Console.Write("Enter damage: ");
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int number;

                    if (int.TryParse(input, out number))
                    {
                        warrior.Damage = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, need only numbers. Try again.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need > 0. Try again.");
                }
            }

            warrior.Equipment = new List<Armour>();
            Console.WriteLine("Enter equipment: ");
            warrior.Equipment.Add(new Armour());
            warrior.Equipment[0].Type = ArmourType.helmet;
            Console.Write("Enter name of helmet: ");
            warrior.Equipment[0].Name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter cost of helmet: ");
                    TryParseCostValue(Console.ReadLine(), warrior, 0);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need >= 0. Try again.");
                }
            }

            warrior.Equipment.Add(new Armour());
            warrior.Equipment[1].Type = ArmourType.gloves;
            Console.Write("Enter name of gloves: ");
            warrior.Equipment[1].Name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter cost of gloves: ");
                    TryParseCostValue(Console.ReadLine(), warrior, 1);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need >= 0. Try again.");
                }
            }

            warrior.Equipment.Add(new Armour());
            warrior.Equipment[2].Type = ArmourType.bodyArmour;
            Console.Write("Enter name of body armour: ");
            warrior.Equipment[2].Name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter cost of body armour: ");
                    TryParseCostValue(Console.ReadLine(), warrior, 2);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need >= 0. Try again.");
                }
            }

            warrior.Equipment.Add(new Armour());
            warrior.Equipment[3].Type = ArmourType.legArmour;
            Console.Write("Enter name of leg armour: ");
            warrior.Equipment[3].Name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Enter cost of leg armour: ");
                    TryParseCostValue(Console.ReadLine(), warrior, 3);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input, need >= 0. Try again.");
                }
            }

            void TryParseCostValue(string input, Warrior warrior, int partArmour)
            {
                string value = input;
                while (true)
                {
                    int number;
                    if (int.TryParse(value, out number))
                    {
                        warrior.Equipment[partArmour].Cost = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, need only numbers. Try again.");
                        Console.Write("Enter cost: ");
                        value = Console.ReadLine();
                    }
                }
            }

            warrior.ShowInfo(warrior);

            Console.ReadLine();
        }
    }
}