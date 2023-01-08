namespace TaskForLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Student("John", "Doe", 20, 2, 4.5f));
            people.Add(new Kid("Jane", "Doe", 10, "Teddy Bear"));

            Console.WriteLine("List of people:\n");

            foreach (Person person in people)
            {
                Console.Write(person.FirstName + "; " + person.LastName + "; " + person.Age);
                if (person is Student)
                {
                    Console.WriteLine("; " + ((Student)person).Course + "; " + ((Student)person).AverageMark + " - Student");
                }
                else if (person is Kid)
                {
                    Console.WriteLine("; " + ((Kid)person).FavoriteToy + " - Kid");
                }
            }

            Console.ReadKey();
        }
    }
}