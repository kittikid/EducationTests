using EducationTests.Base;
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
    /// Логика взаимодействия для PassTestPage.xaml
    /// </summary>
    public partial class PassTestPage : Page
    {
        public PassTestPage(int id)
        {
            InitializeComponent();
            _testId = id + 1;
            _idQuestion = 1;
            _userScore = 0;
            labelTestName.Content += SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.id == _testId).name;
            textBlockQuestion.Text = SourceCore.testsDataBase.question_table.SingleOrDefault(t => t.id_name_test == _testId).question;
            AnswerGrid.ItemsSource = SourceCore.testsDataBase.answer_table.ToList();
        }
        protected int _testId;
        protected int _userScore;
        protected int _idQuestion;
        protected List<string> answerList;

        //private void CreateAnswerList() 
        //{
        //    while (SourceCore.testsDataBase.answer_table.SingleOrDefault(t => t.id_question == _idQuestion).id != -1) 
        //    {
        //        answerList.Add(SourceCore.testsDataBase.answer_table.SingleOrDefault(t => t.id_question == _idQuestion).name_answers);
        //    }
        //}
        private void SelectAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            int id = AnswerGrid.SelectedIndex;
            Base.answer_table value = (Base.answer_table)AnswerGrid.SelectedItem;
            var correctValue = SourceCore.testsDataBase.answer_table.SingleOrDefault(t => t.correct_answer == true).name_answers;
            if (value.name_answers == correctValue)
            {
                //MessageBox.Show("Правильно!", "Всё правильно", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                ++_userScore;
            }
            else
            {
                //MessageBox.Show("Неправильно", "Ну нее", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            SelectAnswerButton.IsEnabled = false;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
