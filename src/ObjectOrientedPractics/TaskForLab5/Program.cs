namespace TaskForLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            double CarSpeed;

            while (true)
            {

                Console.Write("Введите скорость автомобиля: ");

                if (double.TryParse(Console.ReadLine(), out CarSpeed))
                {
                    vehicles.Add(new Car(CarSpeed));
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверный ввод, повторите.");
                }
            }

            vehicles.Add(new Teleport());

            double CarTime;
            double TeleportTime;
            double Distance;

            while (true)
            {
                Console.Write("Введите дистанцию: ");

                if (double.TryParse(Console.ReadLine(), out Distance))
                {
                    CarTime = vehicles[0].CalculateTime(Distance);
                    TeleportTime = vehicles[1].CalculateTime(Distance);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверный ввод, повторите.");
                }
            }

            Console.WriteLine($"Время автомобиля = {Distance} / {CarSpeed} = {CarTime};\nВремя телепорта = {TeleportTime}.");
            Console.ReadKey();
        }
    }
}