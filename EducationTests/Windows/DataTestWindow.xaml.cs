using EducationTests.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            _testName = testName;
            TestNameTextBlock.Text = _testName;
            _testId = SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.name == _testName).id;
        }
        private int DlgMode;
        private Base.answer_table SelectedTest;
        private string _testName;
        private string _questionName;
        private string _answerName;
        private string _correctAnswer;
        private List<Base.answer_table> _answerList;
        private question_table _questionTest;
        private ObservableCollection<Base.answer_table> AnswerTest;
        private int _testId;

        private void AddQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            _questionName = TextQuestion.Text;
            QuestionNameTextBlock.Text = _questionName;
            try
            {
                if (SourceCore.testsDataBase.question_table.SingleOrDefault(t => t.question == _questionName) == null)
                {
                    var QuestionTest = new Base.question_table();
                    QuestionTest.id_name_test = _testId;
                    QuestionTest.question = _questionName;
                    SourceCore.testsDataBase.question_table.Add(QuestionTest);
                    SourceCore.testsDataBase.SaveChanges();
                    AddQuestionButton.IsEnabled = false;
                }

                if (SourceCore.testsDataBase.question_table.SingleOrDefault(t => t.question == _questionName).id_name_test != _testId)
                {
                    var QuestionTest = new Base.question_table();
                    QuestionTest.id_name_test = _testId;
                    QuestionTest.question = _questionName;
                    SourceCore.testsDataBase.question_table.Add(QuestionTest);
                    SourceCore.testsDataBase.SaveChanges();
                    AddQuestionButton.IsEnabled = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        //есди коррект то выписывать в отдельную переменную има/индекс и потом проверять при добавлении в базу и менять занчение на true ну типа флага
        private void AddAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            _answerName = TextAnswer.Text;
            AnswerList.Items.Add(_answerName);
            Base.answer_table answer = new Base.answer_table();
            answer.name_answers = _answerName;
            answer.id_question = SourceCore.testsDataBase.question_table.SingleOrDefault(t => t.question == _questionName).id;
            if (CorrectCheck.IsChecked == true) 
            {
                answer.correct_answer = true;
                CorrectCheck.IsChecked = false;
            }
            SourceCore.testsDataBase.answer_table.Add(answer);
        }

        //public void UpdateGrid(Base.answer_table answerTest)
        //{
        //    if ((answerTest == null) && (AnswerList.ItemsSource != null))
        //    {
        //        answerTest = (Base.answer_table)AnswerList.SelectedItem;
        //    }

        //    AnswerTest = new ObservableCollection<Base.answer_table>(SourceCore.testsDataBase.answer_table);
        //    AnswerList.ItemsSource = AnswerTest;
        //    AnswerList.SelectedItem = answerTest;
        //}

        private void AddCommitButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TextQuestion.Text))
                errors.AppendLine("Укажите имя вопроса");
            //if (string.IsNullOrEmpty(BookTextAuthors.Text))
            //    errors.AppendLine("Укажите название книги");
            //if (((Base.Publishers)BookComboBoxPublishers.SelectedItem == null) || (BookComboBoxPublishers.Text == " ..."))
            //    errors.AppendLine("Укажите издательство");
            //if (string.IsNullOrEmpty(BookTextPublishYear.Text))
            //    errors.AppendLine("Укажите название книги");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            if (DlgMode == 0)
            { 
                
                
                //NewBook.Authors = BookTextAuthors.Text;
                //NewBook.Publishers = (Base.Publishers)BookComboBoxPublishers.SelectedItem;
                //NewBook.PublishYear = (short?)int.Parse(BookTextPublishYear.Text);
                //for (int i = 0; i < _answerList.Count; ++i) 
                //{
                //    SourceCore.testsDataBase.answer_table.Add(_answerList[i]);
                //}
               // SelectedTest = AnswerTest;
            }
            else
            {
                var EditTest = new Base.answer_table();
                //EditTest = SourceCore.testsDataBase.name_test.First(p => p.IdBook == SelectedTest.IdBook);
                //EditBook.Name = BookTextName.Text;
                //EditBook.Authors = BookTextAuthors.Text;
                //EditBook.Publishers = (Base.Publishers)BookComboBoxPublishers.SelectedItem;
                //EditBook.PublishYear = (short?)int.Parse(BookTextPublishYear.Text);
            }

            try
            {
                AddCommitButton.IsEnabled = false;
                SourceCore.testsDataBase.SaveChanges();
                //TestDlgLoad(false, "");
                //UpdateGrid(SelectedTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
