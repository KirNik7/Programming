using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using SystemColor = System.Drawing.Color;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по изменению цвета фона главного окна.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            
            var seasonValues = Enum.GetValues(typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            }
            SeasonNamesComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = SystemColor.Transparent;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = SystemColor.Transparent;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = AppColors.Spring;
                    break;
                case Season.Autumn:
                    this.BackColor = AppColors.Autumn;
                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColor.Transparent;
        }
    }
}
