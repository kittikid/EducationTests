using EducationTests.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace EducationTests.Pages
{
    /// <summary>
    /// Логика взаимодействия для PassTestPage.xaml
    /// </summary>
    public partial class PassTestPage : Page
    {
        public PassTestPage(string testName, int userId)
        {
            InitializeComponent();
            Database = new Base.EducationTestsEntities();
            _testName = testName;
            _testId = Database.name_test.SingleOrDefault(t => t.name == _testName).id;
            _idQuestion = 1;
            _userScore = 0;
            questionList = Database.question_table.Where(t => t.id_name_test == _testId).ToList();
            TestNameLabel.Content += Database.name_test.SingleOrDefault(t => t.id == _testId).name;
            _userId = userId;
            CreateQuestion();
            DispatcherTimerSample();
        }
        private string _testName;
        protected int _testId;
        protected int _userScore;
        protected int _idQuestion;
        protected List<Base.question_table> questionList;
        private readonly int _userId;
        DispatcherTimer timer;
        private int _second;
        private int _minute;
        private string _timeAll;
        private Base.EducationTestsEntities Database;

        public void DispatcherTimerSample()
        {
            _second = 0;
            _minute = 0;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_second > 58)
            {
                ++_minute;
                _second = 0;
            }
            else ++_second;

            if (_second > 9)
            {
                if (_minute > 9) _timeAll = $"{_minute}:{_second}";
                else _timeAll = $"0{_minute}:{_second}";
            }
            else 
            {
                if (_minute > 9) _timeAll = $"{_minute}:0{_second}";
                else _timeAll = $"0{_minute}:0{_second}";
                
            }
            TimerLabel.Content = _timeAll;
        }

        private void CreateQuestion() 
        {
            QuestionNameTextBlock.Text = questionList[_idQuestion - 1].question;
            int id = questionList[_idQuestion - 1].id;
            AnswerGrid.ItemsSource = Database.answer_table.Where(t => t.id_question == id).ToList();
            NumQuestionTextBLock.Text = $"{_idQuestion}/{questionList.Count}";
        }
        private int _selectValue;
        private void SelectAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            int id = questionList[_idQuestion - 1].id;
            Base.answer_table value = (Base.answer_table)AnswerGrid.SelectedItem;
            var correctValue = Database.answer_table.SingleOrDefault(t => t.correct_answer == true && t.id_question == id).name_answers;
            if (value != null) 
            {
                if (value.name_answers == correctValue) ++_userScore;
                _selectValue = Database.answer_table.First(t => t.name_answers == value.name_answers).id;
            }
            else MessageBox.Show("Выберите вариант", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);

            if (value != null) SelectAnswerButton.IsEnabled = false;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectAnswerButton.IsEnabled == true) 
            {
                MessageBox.Show("Выберите вариант", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            SelectAnswerButton.IsEnabled = true;
            //Base.user_tests user_Tests = 
            int id = questionList[_idQuestion - 1].id;
            ++_idQuestion;
            Base.user_tests user_Tests = new Base.user_tests { id_user = _userId, id_test = _testId, id_question = id, id_answer = _selectValue};
            Database.user_tests.Add(user_Tests);
            if (questionList.Count < _idQuestion)
            {
                timer.Stop();
                Database.SaveChanges();
                EndTestPage page = new EndTestPage(_userScore, questionList.Count, _testName, _userId, _timeAll, user_Tests.id);
                this.NavigationService.Navigate(page);
            }
            else CreateQuestion();
        }

        private void ExitTestButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage(0, _userId, 0);
            this.NavigationService.Navigate(page);
        }
    }
}
