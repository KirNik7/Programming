using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Color = Programming.Model.Color;

namespace Programming.View
{
    public partial class MainForm : Form
    {
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

        public void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var enumIndex = EnumsListBox.SelectedIndex;
            var itemName = (Enums)enumIndex;

            switch (itemName)
            {
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.Color:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Color)));
                    break;
                case Enums.Season:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            Weekday value;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out value))
            {
                ItsWeekdayLabel.Text = $"Это день недели ({WeekdayParsingTextBox.Text} = {(int)value})";
            }
            else
            {
                ItsWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
