using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTime;

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается время полёта больше 0.");
                }
                _flightTime = value;
            }
        }

        public Flight(string departurePoint, string destinationPoint, int flightTime)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTime = flightTime;
        }

        public Flight() { }
    }
}

