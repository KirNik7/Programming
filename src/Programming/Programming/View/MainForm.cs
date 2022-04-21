using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;
using SystemColor = System.Drawing.Color;
using Programming.Model.Classes;
using Programming.Model;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly SystemColor _errorBackColor = SystemColor.LightPink;

        private readonly SystemColor _currentBackColor = SystemColor.White;

        private Random random = new Random();

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private string[] _colors;

        private Movie[] _movies;

        private string[] _titlesMovies = { "Leading The Beginning", "Smile At The Champions", 
            "Separated By The Town", "Painting The West", "Battle My Future" };

        private Movie _currentMovie;

        private string[] _genres;

        public MainForm()
        {
            InitializeComponent();
            foreach (Enums enumValue in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumValue);
            }

            EnumsListBox.SelectedIndex = 0;

            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                SeasonHandleComboBox.Items.Add(value);
            }

            InitRectangles();
            InitMovies();
        }

        private void InitRectangles()
        {
            _colors = Enum.GetNames(typeof(Color));
            
            _rectangles = new Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                Point2D center = new Point2D(random.Next(1, 100), random.Next(1, 100));
                _rectangles[i] = new Rectangle(random.Next(0, 1000),
                                               random.Next(0, 1000),
                                               _colors[random.Next(_colors.Length)],
                                               center);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
        }

        private void InitMovies()
        {
            _genres = Enum.GetNames(typeof(Genre));

            _movies = new Movie[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _titlesMovies[i],
                    random.Next(90, 210),
                    random.Next(2021, DateTime.Now.Year + 1),
                    _genres[random.Next(0, _genres.Length)],
                    Math.Round(random.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
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

        public void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enumIndex = EnumsListBox.SelectedItem;
            var itemName = (Enums)enumIndex;

            switch (itemName)
            {
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Color));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufactures));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexEnum = (int)ValuesListBox.SelectedItem;
            IntValueTextBox.Text = selectedIndexEnum.ToString();
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            var itemName = SeasonHandleComboBox.SelectedItem;

            switch (itemName)
            {
                case Season.Winter:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Summer:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out weekday))
            {
                ItsWeekdayLabel.Text = $"Это день недели " +
                    $"({WeekdayParsingTextBox.Text} = {(int)weekday})";
            }
            else
            {
                ItsWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(RectangleLengthTextBox.Text);
                RectangleLengthTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                RectangleLengthTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
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
                MovieYearTextBox.BackColor = _currentBackColor;
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
                MovieDurationTextBox.BackColor = _currentBackColor;
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
                MovieRatingTextBox.BackColor = _currentBackColor;
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

        private void AddRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = SystemColor.LightGray;
        }

        private void AddRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = RectanglesTabPage.BackColor;
        }

        private void RemoveRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColor.LightGray;
        }

        private void RemoveRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = RectanglesTabPage.BackColor;
        }
    }
}
