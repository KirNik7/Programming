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
                        ValuesListBox.Items.Add(EducationForm.Distance);
                        ValuesListBox.Items.Add(EducationForm.Evening);
                        ValuesListBox.Items.Add(EducationForm.Fulltime);
                        ValuesListBox.Items.Add(EducationForm.Pasttime);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Color":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Color.Black);
                        ValuesListBox.Items.Add(Color.Blue);
                        ValuesListBox.Items.Add(Color.Brown);
                        ValuesListBox.Items.Add(Color.Gray);
                        ValuesListBox.Items.Add(Color.Green);
                        ValuesListBox.Items.Add(Color.Orange);
                        ValuesListBox.Items.Add(Color.Pink);
                        ValuesListBox.Items.Add(Color.Red);
                        ValuesListBox.Items.Add(Color.Violet);
                        ValuesListBox.Items.Add(Color.White);
                        ValuesListBox.Items.Add(Color.Yellow);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
                case "Genre":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.Add(Genre.Action);
                        ValuesListBox.Items.Add(Genre.Blockbuster);
                        ValuesListBox.Items.Add(Genre.Comedy);
                        ValuesListBox.Items.Add(Genre.Drama);
                        ValuesListBox.Items.Add(Genre.Horror);
                        ValuesListBox.Items.Add(Genre.Thriller);
                        ValuesListBox.SelectedIndex = 0;
                        break;
                    }
            }
        }
    }
}
