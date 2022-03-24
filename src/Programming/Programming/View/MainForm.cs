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

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles = new Model.Classes.Rectangle[5];
        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();

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

            for (int i = 0; i<5; i++)
            {
                _rectangles[i].Length = i+1;
                _rectangles[i].Width = i+1;
                _rectangles[i].Color = "Здесь должен быть разный цвет :)";
                RectanglesListBox.Items.Add(_rectangles[i]);
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
