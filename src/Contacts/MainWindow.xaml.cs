using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _mainVM = new MainVM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainVM;
        }
    }
}
