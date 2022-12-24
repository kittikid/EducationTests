using EducationTests.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public EndTestPage(int result, int countQuestion, string testName, int userId)
        {
            InitializeComponent();
            _testName = testName;
            _testId = SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.name == _testName).id;
            _result = result;
            _countQuestion = countQuestion;
            _userId = userId;
            //Database = new Base.EducationTestsEntities();
            NumResultTextBlock.Text = $"{_result} из {_countQuestion}";
        }
        private string _testName;
        private readonly int _testId;
        private readonly int _result;
        private readonly int _countQuestion;
        private readonly int _userId;
        //private Base.EducationTestsEntities Database;

        private void EndTestButton_Click(object sender, RoutedEventArgs e)
        {

            //int id = Database.user_score.SingleOrDefault(t => t.id_user == _userId);
            //MessageBox.Show(id.ToString());

            //if (Database.user_score.SingleOrDefault(t => t.id_user == _userId) == null)
            //{

            //    Base.user_score user_Score = new Base.user_score
            //    {
            //        id_user = _userId,
            //        id_test = _testId,
            //        status = _statusTest ? "Завершенно" : "В процессе",
            //        progress = $"{_result}/{_countQuestion}"
            //    };
            //    SourceCore.testsDataBase.user_score.Add(user_Score);
            //}

            //Base.user_score user_Score = new Base.user_score
            //{
            //    id_user = _userId,
            //    id_test = _testId,
            //    status = _statusTest ? "Завершенно" : "В процессе",
            //    progress = $"{_result}/{_countQuestion}"
            //};
            Base.user_score user_Score = new Base.user_score { id_user = _userId,  id_test = _testId, status = "Завершено", progress = $"{_result}/{_countQuestion}" };
            SourceCore.testsDataBase.user_score.Add(user_Score);

            //if (Database.user_score.SingleOrDefault(t => t.id_user == _userId).id_test != _testId)
            //{
            //    Base.user_score user_Score = new Base.user_score
            //    {
            //        id_user = _userId,
            //        id_test = _testId,
            //        status = _statusTest ? "Завершенно" : "В процессе",
            //        progress = $"{_result}/{_countQuestion}"
            //    };
            //    Database.user_score.Add(user_Score);   
            //}
            SourceCore.testsDataBase.SaveChanges();
            //try
            //{
            //    Database.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}

            MainPage page = new MainPage(_testId, _userId);
            this.NavigationService.Navigate(page);
        }

        private void RepeatTestButton_Click(object sender, RoutedEventArgs e)
        {
            PassTestPage page = new PassTestPage(_testName, _userId);
            this.NavigationService.Navigate(page);
        }
    }
}
