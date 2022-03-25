using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTime;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTime
        {
            get 
            { 
                return _flightTime; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается время полёта больше 0.");
                }
                _flightTime = value;
            }
        }

        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }

        public Flight() { }
    }
}

