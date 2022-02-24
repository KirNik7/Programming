using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string[] NamesFiles = { EducationForm.Distance.GetType().Name, Color.Black.GetType().Name, Genre.Action.GetType().Name, Manufactures.Apple.GetType().Name, Season.Autumn.GetType().Name, Weekday.Friday.GetType().Name };
            EnumsListBox.Items.AddRange(NamesFiles);
            EnumsListBox.SelectedIndex = 0;
        }

        public void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] NamesFiles = { EducationForm.Distance.GetType().Name, Color.Black.GetType().Name, Genre.Action.GetType().Name, Manufactures.Apple.GetType().Name, Season.Autumn.GetType().Name, Weekday.Friday.GetType().Name };
            switch ((string)EnumsListBox.SelectedItem)
            {
                case "EducationForm":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(EducationForm.Fulltime);
                        ValuesListBox.Items.Add(EducationForm.Pasttime);
                        ValuesListBox.Items.Add(EducationForm.Evening);
                        ValuesListBox.Items.Add(EducationForm.Distance);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Color":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Color.Black);
                        ValuesListBox.Items.Add(Color.White);
                        ValuesListBox.Items.Add(Color.Red);
                        ValuesListBox.Items.Add(Color.Yellow);
                        ValuesListBox.Items.Add(Color.Green);
                        ValuesListBox.Items.Add(Color.Blue);
                        ValuesListBox.Items.Add(Color.Orange);
                        ValuesListBox.Items.Add(Color.Violet);
                        ValuesListBox.Items.Add(Color.Pink);
                        ValuesListBox.Items.Add(Color.Gray);
                        ValuesListBox.Items.Add(Color.Brown);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Genre":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Genre.Comedy);
                        ValuesListBox.Items.Add(Genre.Drama);
                        ValuesListBox.Items.Add(Genre.Thriller);
                        ValuesListBox.Items.Add(Genre.Action);
                        ValuesListBox.Items.Add(Genre.Horror);
                        ValuesListBox.Items.Add(Genre.Blockbuster);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Manufactures":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Manufactures.Apple);
                        ValuesListBox.Items.Add(Manufactures.Xiaomi);
                        ValuesListBox.Items.Add(Manufactures.Huawei);
                        ValuesListBox.Items.Add(Manufactures.Samsung);
                        ValuesListBox.Items.Add(Manufactures.Honor);
                        ValuesListBox.Items.Add(Manufactures.Lenovo);
                        ValuesListBox.Items.Add(Manufactures.LG);
                        ValuesListBox.Items.Add(Manufactures.Nokia);
                        ValuesListBox.Items.Add(Manufactures.Sony);
                        ValuesListBox.Items.Add(Manufactures.Motorola);
                        ValuesListBox.Items.Add(Manufactures.Asus);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Season":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Season.Winter);
                        ValuesListBox.Items.Add(Season.Spring);
                        ValuesListBox.Items.Add(Season.Summer);
                        ValuesListBox.Items.Add(Season.Autumn);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Weekday":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Weekday.Monday);
                        ValuesListBox.Items.Add(Weekday.Tuesday);
                        ValuesListBox.Items.Add(Weekday.Wednesday);
                        ValuesListBox.Items.Add(Weekday.Thursday);
                        ValuesListBox.Items.Add(Weekday.Friday);
                        ValuesListBox.Items.Add(Weekday.Saturday);
                        ValuesListBox.Items.Add(Weekday.Sunday);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = ValuesListBox.SelectedItem.ToString();
            a.GetValues();
        }
    }
}
