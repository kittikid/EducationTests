using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EducationTests.Pages
{
    /// <summary>
    /// Логика взаимодействия для EndTestPage.xaml
    /// </summary>
    public partial class EndTestPage : Page
    {
        public EndTestPage(int result, int countQuestion, string testName, int userId, string timeAll, int userTestsId)
        {
            InitializeComponent();
            Database = new Base.EducationTestsEntities();
            _testName = testName;
            _testId = Database.name_test.SingleOrDefault(t => t.name == _testName).id;
            _result = result;
            _countQuestion = countQuestion;
            _userId = userId;
            _timeAll = timeAll;
            _userTestsId = userTestsId;
            NumTimeTextBlock.Text = _timeAll;
            NumResultTextBlock.Text = $"{_result} из {_countQuestion}";
        }
        private string _testName;
        private readonly int _testId;
        private readonly int _result;
        private readonly int _countQuestion;
        private readonly int _userId;
        private readonly string _timeAll;
        private readonly int _userTestsId;
        private Base.EducationTestsEntities Database;

        private void EndTestButton_Click(object sender, RoutedEventArgs e)
        {
            Base.user_score user_Score = new Base.user_score { id_user = _userId, id_test = _testId, id_user_test = _userTestsId, status = "Завершено", progress = $"{_result}/{_countQuestion}", date = _timeAll };
            Database.user_score.Add(user_Score);

            Database.SaveChanges();
            
            MainPage page = new MainPage(_testId, _userId, _userTestsId);
            this.NavigationService.Navigate(page);
        }

        private void RepeatTestButton_Click(object sender, RoutedEventArgs e)
        {
            PassTestPage page = new PassTestPage(_testName, _userId);
            this.NavigationService.Navigate(page);
        }
    }
}
