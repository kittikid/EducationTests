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
            labelTestName.Content += SourceCore.testsDataBase.name_test.SingleOrDefault(t => t.id == _testId).name;
            textBlockQuestion.Text = SourceCore.testsDataBase.question_table.SingleOrDefault(t => t.id_name_test == _testId).question;
            AnswerGrid.ItemsSource = SourceCore.testsDataBase.answer_table.ToList();
        }
        protected int _testId;

    }
}
