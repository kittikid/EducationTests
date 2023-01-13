using EducationTests.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Shapes;

namespace EducationTests.Windows
{
    /// <summary>
    /// Логика взаимодействия для DataTestWindow.xaml
    /// </summary>
    public partial class DataTestWindow : Window
    {
        public DataTestWindow(string testName)
        {
            InitializeComponent();
            Database = new Base.EducationTestsEntities();
            _testName = testName;
            TestNameTextBlock.Text = _testName;
            _testId = Database.name_test.SingleOrDefault(t => t.name == _testName).id;
        }
        private int DlgMode;
        private Base.EducationTestsEntities Database;
        private string _testName;
        private string _questionName;
        private string _answerName;
        private int _questionId;
        private Base.answer_table _answer;
        private int _testId;

        private void AddQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            _questionName = TextQuestion.Text;
            if (_questionName == "") 
            {
                MessageBox.Show("Введите вопрос.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            QuestionNameTextBlock.Text = _questionName;

            var QuestionTest = new Base.question_table();
            QuestionTest.id_name_test = _testId;
            QuestionTest.question = _questionName;
            Database.question_table.Add(QuestionTest);
            Database.SaveChanges();
            _questionId = Database.question_table.SingleOrDefault(t => t.question == _questionName).id;
            AddQuestionButton.IsEnabled = false;
        }
        
        private void AddAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (_questionName == null) 
            {
                MessageBox.Show("Введите вопрос.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            _answerName = TextAnswer.Text;
            if (_answerName == "")
            {
                MessageBox.Show("Введите ответ.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            AnswerList.Items.Add(_answerName);
            Base.answer_table answer = new Base.answer_table();
            answer.name_answers = _answerName;
            answer.id_question = _questionId;
            //answer.id_question = Database.question_table.SingleOrDefault(t => t.question == _questionName).id;
            //CorrectCheck.IsChecked = true ? answer.correct_answer = true : answer.correct_answer = false;
            answer.correct_answer = true ? CorrectCheck.IsChecked == true : false;
            CorrectCheck.IsChecked = false;
            TextAnswer.Clear();
            Database.answer_table.Add(answer);
            _answer = answer;
        }

        private void AddCommitButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TextQuestion.Text))
                errors.AppendLine("Укажите имя вопроса.");
            if (string.IsNullOrEmpty(AnswerList.Items.ToString()))
                errors.AppendLine("Укажите ответы.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                AddCommitButton.IsEnabled = false;
                Database.SaveChanges();
                //TestDlgLoad(false, "");
                //UpdateGrid(SelectedTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionNameTextBlock.Text == "")
            {
                MessageBox.Show("Введите вопрос.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }

            if (AnswerList.Items.Count < 3) 
            {
                MessageBox.Show("Малое количество ответов.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }

            TextQuestion.Clear();
            TextAnswer.Clear();
            AnswerList.Items.Clear();
            QuestionNameTextBlock.Text = "";
            AddQuestionButton.IsEnabled = true;
            AddCommitButton.IsEnabled = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Base.question_table RemoveQuestion = Database.question_table.SingleOrDefault(t => t.id == _questionId);
            if (_answer != null)
                Database.answer_table.Remove(_answer);
            if (RemoveQuestion != null)
                Database.question_table.Remove(RemoveQuestion);
            Database.SaveChanges();
            Close();
        }
    }
}
