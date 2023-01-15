using EducationTests.Base;
using EducationTests.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EducationTests.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        public UserProfilePage(int userId, int testId)
        {
            InitializeComponent();
            Database = new Base.EducationTestsEntities();
            _userId = userId;
            _testId = testId;
            UserProfileGrid.ItemsSource = Database.user_score.ToList();
            UpdateGrid(null);
            UserNameTextBlock.Text = Database.Users.SingleOrDefault(t => t.id == _userId).login;
        }

        private readonly int _userId;
        private readonly int _testId;
        private ObservableCollection<Base.user_score> UserScore;
        private Base.EducationTestsEntities Database;

        public void UpdateGrid(Base.user_score userScore)
        {
            if ((userScore == null) && (UserProfileGrid.ItemsSource != null))
            {
                userScore = (Base.user_score)UserProfileGrid.SelectedItem;
            }

            UserScore = new ObservableCollection<Base.user_score>(Database.user_score.Where(t => t.id_user == _userId));
            UserProfileGrid.ItemsSource = UserScore;
            UserProfileGrid.SelectedItem = userScore;
        }

        private void ReturnMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage(0, _userId, _testId);
            this.NavigationService.Navigate(page);
        }

        private void ExitAccountButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            Window.GetWindow(this).Close();
            window.Show();
        }

        private void DeleteRecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                try
                {
                    Base.user_score DeletingScore = (Base.user_score)UserProfileGrid.SelectedItem;
                    ObservableCollection<Base.user_tests> DeletingUserTests = new ObservableCollection<user_tests>(Database.user_tests.Where(t => t.id_user == _userId && t.id_test == _testId));
                    if (UserProfileGrid.SelectedIndex < UserProfileGrid.Items.Count - 1)
                    {
                        UserProfileGrid.SelectedIndex++;
                    }
                    else
                    {
                        if (UserProfileGrid.SelectedIndex > 0)
                        {
                            UserProfileGrid.SelectedIndex--;
                        }
                    }
                    Base.user_score SelectingTest = (Base.user_score)UserProfileGrid.SelectedItem;
                    Database.user_score.Remove(DeletingScore);
                    Database.SaveChanges();
                    for (int i = 0; i < DeletingUserTests.Count; ++i)
                    { 
                        Database.user_tests.Remove(DeletingUserTests[i]);
                    }
                    Database.SaveChanges();
                    UpdateGrid(SelectingTest);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить запись, так как " +
                        "она используется в других справочниках базы " +
                        "данных.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
            }
        }

        private void ShowResultButton_Click(object sender, RoutedEventArgs e)
        {
            Base.user_score value = null;
            try { value = (Base.user_score)UserProfileGrid.SelectedItem; } catch { }

            if (value == null)
            {
                MessageBox.Show("Выберите тест", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }

            UserTestResult window = new UserTestResult(value.id_test, _userId);
            window.Show();
        }
    }
}
