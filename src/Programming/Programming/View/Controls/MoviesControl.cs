using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using SystemColor = System.Drawing.Color;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        private readonly SystemColor _errorBackColor = SystemColor.LightPink;

        private readonly SystemColor _correctBackColor = SystemColor.White;

        private Random _random = new Random();

        private Movie[] _movies;

        private string[] _titlesMovies = { "Leading The Beginning", "Smile At The Champions",
            "Separated By The Town", "Painting The West", "Battle My Future" };

        private Movie _currentMovie;

        private string[] _genres;

        public MoviesControl()
        {
            InitializeComponent();

            InitMovies();
        }

        private void InitMovies()
        {
            _genres = Enum.GetNames(typeof(Genre));

            _movies = new Movie[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _titlesMovies[i],
                    _random.Next(90, 210),
                    _random.Next(2021, DateTime.Now.Year + 1),
                    _genres[_random.Next(0, _genres.Length)],
                    Math.Round(_random.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
        }

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
                MovieYearTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                MovieYearTextBox.BackColor = _errorBackColor;
            }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationMinutes = int.Parse(MovieDurationTextBox.Text);
                MovieDurationTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                MovieDurationTextBox.BackColor = _errorBackColor;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(MovieRatingTextBox.Text);
                MovieRatingTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                MovieRatingTextBox.BackColor = _errorBackColor;
            }
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
