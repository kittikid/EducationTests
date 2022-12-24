using EducationTests.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для PassTestPage.xaml
    /// </summary>
    public partial class PassTestPage : Page
    {
        public PassTestPage(string testName, int userId)
        {
            InitializeComponent();
            _testName = testName;
            _testId = SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.name == _testName).id;
            _idQuestion = 1;
            //_idQuestion = SourceCore.testsDataBase.question_table.First(t => t.id_name_test == _testId).id;
            _userScore = 0;
            questionList = SourceCore.testsDataBase.question_table.Where(t => t.id_name_test == _testId).ToList();
            TestNameLabel.Content += SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.id == _testId).name;
            _userId = userId;
           // _deltaQ = _idQuestion;
            CreateQuestion();
        }
        private string _testName;
        protected int _testId;
        protected int _userScore;
        protected int _idQuestion;
        protected List<Base.question_table> questionList;
        private readonly int _userId;
       // private int _deltaQ;
       // private int _indexQ;

        private void CreateQuestion() 
        {
            //_indexQ = _idQuestion + 1 - _deltaQ;
            QuestionNameTextBlock.Text = questionList[_idQuestion - 1].question;
            int id = SourceCore.testsDataBase.question_table.FirstOrDefault(q => q.id_name_test == _testId).id;
            AnswerGrid.ItemsSource = SourceCore.testsDataBase.answer_table.Where(t => t.id_question == id + _idQuestion - 1).ToList();
            //SourceCore.testsDataBase.question_table.First(q => q.id_name_test == _testId).id
            NumQuestionTextBLock.Text = $"{_idQuestion}/{questionList.Count}";
        }
        private void SelectAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAnswerButton.IsEnabled = false;
            Base.answer_table value = (Base.answer_table)AnswerGrid.SelectedItem;
            int id = SourceCore.testsDataBase.question_table.FirstOrDefault(q => q.id_name_test == _testId).id;
            var correctValue = SourceCore.testsDataBase.answer_table.SingleOrDefault(t => t.correct_answer == true && t.id_question == id + _idQuestion - 1).name_answers;
            if (value.name_answers == correctValue) ++_userScore;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAnswerButton.IsEnabled = true;
            ++_idQuestion;
            //_indexQ = _idQuestion + 1 - _deltaQ;
            if (questionList.Count < _idQuestion)
            {
                EndTestPage page = new EndTestPage(_userScore, questionList.Count, _testName, _userId);
                this.NavigationService.Navigate(page);
            }
            else CreateQuestion();
            //AnswerGrid.ItemsSource = SqlConnection($"select count(id_name_test) from EducationTests.question_table where id_name_test = {_testId}");
            //var qt = SourceCore.testsDataBase.question_table.Where(t=>t.id_name_test == 1).ToList();
        }
    }
}
