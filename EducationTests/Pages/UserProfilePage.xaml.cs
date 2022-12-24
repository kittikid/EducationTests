using EducationTests.Base;
using EducationTests.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        public UserProfilePage(int userId)
        {
            InitializeComponent();
            //_testId = testId;
            _userId = userId;
            UserProfileGrid.ItemsSource = SourceCore.testsDataBase.user_score.ToList();
            UpdateGrid(null);
            UserNameTextBlock.Text = SourceCore.testsDataBase.Users.SingleOrDefault(t => t.id == _userId).login;
            //UserProfileGrid.DataContext = SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.id == _testId).name;
        }
        //private readonly int _testId;
        private readonly int _userId;
        private ObservableCollection<Base.user_score> UserScore;

        public void UpdateGrid(Base.user_score userScore)
        {
            if ((userScore == null) && (UserProfileGrid.ItemsSource != null))
            {
                userScore = (Base.user_score)UserProfileGrid.SelectedItem;
            }

            UserScore = new ObservableCollection<Base.user_score>(SourceCore.testsDataBase.user_score.Where(t => t.id_user == _userId));
            UserProfileGrid.ItemsSource = UserScore;
            UserProfileGrid.SelectedItem = userScore;
        }

        private void ReturnMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage(0, _userId);
            this.NavigationService.Navigate(page);
        }

        private void ExitAccountButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            Window.GetWindow(this).Close();
            window.Show();
        }
    }
}
