using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationTests.Pages
{
    /// <summary>
    /// Логика взаимодействия для EndTestPage.xaml
    /// </summary>
    public partial class EndTestPage : Page
    {
        public EndTestPage(int result, int countQuestion, int id)
        {
            InitializeComponent();
            _testId = id;
            NumResultTextBlock.Text = $"{result} из {countQuestion}";
        }
        private int _testId;
        private void EndTestButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage();
            this.NavigationService.Navigate(page);
        }

        private void RepeatTestButton_Click(object sender, RoutedEventArgs e)
        {
            PassTestPage page = new PassTestPage(_testId);
            this.NavigationService.Navigate(page);
        }
    }
}
