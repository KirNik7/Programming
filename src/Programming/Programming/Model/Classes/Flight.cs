namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о воздушном рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта. Должно быть положительным числом.
        /// </summary>
        public int FlightTime
        {
            get 
            { 
                return _flightTime; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTime), value);
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место прибытия.</param>
        /// <param name="flightTime">Время полёта. Должно быть положительным числом.</param>
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight() { }
    }
}

