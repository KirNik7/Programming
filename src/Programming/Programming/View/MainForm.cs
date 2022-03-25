using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Random rand = new Random();
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private string[] _colors;
        private Movie[] _movies;
        private string[] _titlesMovies = { "Leading The Beginning", "Smile At The Champions", "Separated By The Town", "Painting The West", "Battle My Future" };
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

            _colors = Enum.GetNames(typeof(Color));
            _genres = Enum.GetNames(typeof(Genre));
            _rectangles = new Rectangle[5];
            _movies = new Movie[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(rand.Next(0, 1000), rand.Next(0, 1000),
                                               _colors[rand.Next(_colors.Length)]);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(_titlesMovies[i], rand.Next(90, 210), rand.Next(2021, DateTime.Now.Year + 1),
                                       _genres[rand.Next(0, _genres.Length)], Math.Round(rand.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
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
                ItsWeekdayLabel.Text = $"Это день недели ({WeekdayParsingTextBox.Text} = {(int)weekday})";
            }
            else
            {
                ItsWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
