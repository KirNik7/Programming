using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию представления фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Минимальное значение длительности фильма.
        /// </summary>
        private const int MinDuration = 60;

        /// <summary>
        /// Максимальное значение длительности фильма.
        /// </summary>
        private const int MaxDuration = 210;

        /// <summary>
        /// Минимальное значение года выхода фильма.
        /// </summary>
        private const int MinYear = 1900;

        /// <summary>
        /// Максимальное значение года выхода фильма.
        /// </summary>
        private int MaxYear = DateTime.Now.Year + 1;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int CountElements = 5;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Коллекция фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Коллекция названий фильмов.
        /// </summary>
        private string[] _titlesMovies = { "Leading The Beginning", "Smile At The Champions",
            "Separated By The Town", "Painting The West", "Battle My Future" };

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Коллекция жанров.
        /// </summary>
        private string[] _genres;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            InitMovies();
        }

        /// <summary>
        /// Инициализирует коллекцию фильмов.
        /// </summary>
        private void InitMovies()
        {
            _genres = Enum.GetNames(typeof(Genre));

            _movies = new Movie[CountElements];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _titlesMovies[i],
                    _random.Next(MinDuration, MaxDuration),
                    _random.Next(MinYear, MaxYear),
                    _genres[_random.Next(0, _genres.Length)],
                    Math.Round(_random.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
        }

        /// <summary>
        /// Находит из коллекции фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="movie">Коллекция фильмов.</param>
        /// <returns>Возвращает индекс элемента коллекции, рейтинг которого является максимальным.</returns>
        private int FindMovieWithMaxRating(Movie[] movie)
        {
            int indexMaxRating = 0;
            double maxRating = 0;
            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Rating > maxRating)
                {
                    maxRating = movie[i].Rating;
                    indexMaxRating = i;
                }
            }
            return indexMaxRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexMovie];
            MovieTitleTextBox.Text = _currentMovie.Title;
            MovieDurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MovieTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = MovieTitleTextBox.Text;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MovieGenreTextBox.Text;
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(MovieYearTextBox.Text);
                MovieYearTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                MovieYearTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationMinutes = int.Parse(MovieDurationTextBox.Text);
                MovieDurationTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                MovieDurationTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(MovieRatingTextBox.Text);
                MovieRatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
