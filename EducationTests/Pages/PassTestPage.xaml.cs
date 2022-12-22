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
        public PassTestPage(int id)
        {
            InitializeComponent();
            _testId = id;
            _idQuestion = 1;
            _userScore = 0;
            questionList = SourceCore.testsDataBase.question_table.Where(t => t.id_name_test == _testId).ToList();
            TestNameLabel.Content += SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.id == _testId).name;
            
            CreateQuestion();
        }
        protected int _testId;
        protected int _userScore;
        protected int _idQuestion;
        protected List<Base.question_table> questionList;

        private void CreateQuestion() 
        {
            QuestionNameTextBlock.Text = questionList[_idQuestion-1].question;
            AnswerGrid.ItemsSource = SourceCore.testsDataBase.answer_table.Where(t => t.id_question == _idQuestion).ToList();
            NumQuestionTextBLock.Text = $"{_idQuestion}/{questionList.Count}";
        }
        private void SelectAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAnswerButton.IsEnabled = false;
            int id = AnswerGrid.SelectedIndex;
            Base.answer_table value = (Base.answer_table)AnswerGrid.SelectedItem;
            var correctValue = SourceCore.testsDataBase.answer_table.SingleOrDefault(t => t.correct_answer == true && t.id_question == _idQuestion).name_answers;
            if (value.name_answers == correctValue) ++_userScore;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAnswerButton.IsEnabled = true;
            ++_idQuestion;
            if (questionList.Count < _idQuestion)
            {
                EndTestPage page = new EndTestPage(_userScore, questionList.Count, _testId);
                this.NavigationService.Navigate(page);
            }
            else CreateQuestion();
            //AnswerGrid.ItemsSource = SqlConnection($"select count(id_name_test) from EducationTests.question_table where id_name_test = {_testId}");
            //var qt = SourceCore.testsDataBase.question_table.Where(t=>t.id_name_test == 1).ToList();
        }
    }
}
