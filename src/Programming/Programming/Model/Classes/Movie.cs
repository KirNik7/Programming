using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private static int _count;
        private int _durationMinutes;

        private int _releaseYear;

        private double _rating;

        public string Title { get; set; }

        public int DurationMinutes
        {
            get 
            { 
                return _durationMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get 
            { 
                return _releaseYear; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0d, 10d);
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

        public Movie() 
        { 
            _count++; 
        }

        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}

