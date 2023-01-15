using System.Windows;
using System.Windows.Input;

namespace EducationTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(int _userId)
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.MainPage(0, _userId, 0));
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
    }
}
