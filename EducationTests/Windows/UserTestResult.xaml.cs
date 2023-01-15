using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace EducationTests.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserTestResult.xaml
    /// </summary>
    public partial class UserTestResult : Window
    {
        public UserTestResult(int testId, int userId)
        {
            InitializeComponent();
            Database = new Base.EducationTestsEntities();
            _testId = testId;
            _userId = userId;
            TestNameTextBlock.Text = Database.name_test.SingleOrDefault(t => t.id == _testId).name;
            UserResultGrid.ItemsSource = Database.user_tests.ToList();
            UpdateGrid(null);
        }
        private Base.EducationTestsEntities Database;
        private ObservableCollection<Base.user_tests> UserScore;
        private int _testId;
        private int _userId;

        public void UpdateGrid(Base.user_tests userScore)
        {
            if ((userScore == null) && (UserResultGrid.ItemsSource != null))
            {
                userScore = (Base.user_tests)UserResultGrid.SelectedItem;
            }
            UserScore = new ObservableCollection<Base.user_tests>(Database.user_tests.Where(t => t.id_user == _userId && t.id_test == _testId));
            UserResultGrid.ItemsSource = UserScore;
            UserResultGrid.SelectedItem = userScore;
        }
    }
}
