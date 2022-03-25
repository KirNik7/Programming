using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private static int _count;
        private string _title;
        private int _durationMinutes;
        private int _releaseYear;
        private double _rating;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается продолжительность фильма больше 0.");
                }
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Ожидается год выпуска больше 1900 и меньше или равно 2022.");
                }
                _releaseYear = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0.0 || value > 10.0)
                {
                    throw new ArgumentException("Ожидается рейтинг больше 0 и меньше или равно 10.");
                }
                _rating = value;
            }
        }

        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            DurationMinutes = duration;
            ReleaseYear = year;
            Genre = genre;
            Rating = rating;
            _count++;
        }

        public Movie() { _count++; }

        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}

