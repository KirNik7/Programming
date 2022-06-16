using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Количество фильмов.
        /// </summary>
        private static int _count;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Длительность фильма в минутах.
        /// Должно быть положительным числом.</param>
        /// <param name="year">Год релиза фильма. Должен быть в диапозоне 
        /// от 1900 до текущего года (включительно).</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. 
        /// Должен быть в диапазоне от 0 до 10 (включительно).</param>
        public Movie(string title,
                     int duration,
                     int year,
                     string genre,
                     double rating)
        {
            Title = title;
            DurationMinutes = duration;
            ReleaseYear = year;
            Genre = genre;
            Rating = rating;
            _count++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            _count++;
        }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность фильма в минутах. Должно быть положительным числом.
        /// </summary>
        public int DurationMinutes
        {
            get 
            { 
                return _durationMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes),
                                                value);
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Должен быть в диапозоне 
        /// от 1900 до текущего года (включительно).
        /// </summary>
        public int ReleaseYear
        {
            get 
            { 
                return _releaseYear; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear),
                                             value,
                                             1900,
                                             DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть в диапазоне от 0 до 10 (включительно).
        /// </summary>
        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating),
                                             value,
                                             0d,
                                             10d);
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт строку для отображения фильма в интерфейсе.
        /// </summary>
        /// <returns>Возвращает строку с номером фильма в списке.</returns>
        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}

