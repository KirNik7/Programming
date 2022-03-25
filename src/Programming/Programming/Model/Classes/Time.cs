using System;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get 
            { 
                return _hours;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Ожидается часы больше 0 и меньше или равно 23.");
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get
            { 
                return _minutes;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Ожидается минуты больше 0 и меньше или равно 60.");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get 
            {
                return _seconds;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Ожидается секунды больше 0 и меньше или равно 60.");
                }
                _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }
    }
}

