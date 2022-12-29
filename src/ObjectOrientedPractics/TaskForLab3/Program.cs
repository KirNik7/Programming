using System;

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
                    warrior.HP = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
            }

            Console.Write("Enter damage: ");
            while (true)
            {
                try
                {
                    warrior.Damage = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
            }

            warrior.Equipment = new List<Armour>();
            Console.WriteLine("Enter equipment: ");
            while (true)
            {
                try
                {
                    warrior.Equipment.Add(new Armour());
                    warrior.Equipment[0].Type = ArmourType.helmet;
                    Console.Write("Enter name of helmet: ");
                    warrior.Equipment[0].Name = Console.ReadLine();
                    Console.Write("Enter cost of helmet: ");
                    warrior.Equipment[0].Cost = Convert.ToInt32(Console.ReadLine());
                    
                    warrior.Equipment.Add(new Armour());
                    warrior.Equipment[1].Type = ArmourType.gloves;
                    Console.Write("Enter name of gloves: ");
                    warrior.Equipment[1].Name = Console.ReadLine();
                    Console.Write("Enter cost of gloves: ");
                    warrior.Equipment[1].Cost = Convert.ToInt32(Console.ReadLine());
                    
                    warrior.Equipment.Add(new Armour());
                    warrior.Equipment[2].Type = ArmourType.bodyArmour;
                    Console.Write("Enter name of body armour: ");
                    warrior.Equipment[2].Name = Console.ReadLine();
                    Console.Write("Enter cost of body armour: ");
                    warrior.Equipment[2].Cost = Convert.ToInt32(Console.ReadLine());
                    
                    warrior.Equipment.Add(new Armour());
                    warrior.Equipment[3].Type = ArmourType.legArmour;
                    Console.Write("Enter name of leg armour: ");
                    warrior.Equipment[3].Name = Console.ReadLine();
                    Console.Write("Enter cost of leg armour: ");
                    warrior.Equipment[3].Cost = Convert.ToInt32(Console.ReadLine());
                    
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
            }

            warrior.ShowInfo(warrior);

            Console.ReadLine();
        }
    }
}