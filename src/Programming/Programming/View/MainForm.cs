using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;
using SystemColor = System.Drawing.Color;
using Programming.Model.Classes;
using System.Collections.Generic;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly SystemColor _errorBackColor = SystemColor.LightPink;

        private readonly SystemColor _correctBackColor = SystemColor.White;

        private Random _random = new Random();

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

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
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
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
            if (indexRectangle != -1)
            {
                _currentRectangle = _rectangles[indexRectangle];
                RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
                XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
                RectangleHeightTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                RectangleHeightTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
        }

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                XRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                YRectangleTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                YRectangleTextBox.BackColor = _errorBackColor;
            }
        }
    }
}
