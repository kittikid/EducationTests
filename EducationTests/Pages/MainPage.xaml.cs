using EducationTests.Base;
using EducationTests.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage(int testId, int userId, int userTestsId)
        {
            Database = new Base.EducationTestsEntities();
            InitializeComponent();
            DataContext = this;
            MainGrid.ItemsSource = Database.name_test.ToList();
            UpdateGrid(null);
            TestDlgLoad(false, "");
            DataContext = this;
            _testId = testId;
            _userId = userId;
            _userTestsId = userTestsId;
        }

        private int DlgMode;
        private Base.name_test SelectedTest;
        private ObservableCollection<Base.name_test> NameTest;
        private readonly int _testId;
        private readonly int _userId;
        private readonly int _userTestsId;
        private Base.EducationTestsEntities Database;

        public void TestDlgLoad(bool b, string DlgModeContent)
        {
            if (b == true)
            {
                TestColumnChange.Width = new GridLength(250);
                MainGrid.IsHitTestVisible = false;
                //BookLabel.Content = DlgModeContent;
                TestAddCommit.Content = DlgModeContent;
                TestAdd.IsEnabled = false;
                //TestCopy.IsEnabled = false;
                TestEdit.IsEnabled = false;
                TestDellete.IsEnabled = false;
            }
            else
            {
                TestColumnChange.Width = new GridLength(0);
                MainGrid.IsHitTestVisible = true;
                TestAdd.IsEnabled = true;
                //TestCopy.IsEnabled = true;
                TestEdit.IsEnabled = true;
                TestDellete.IsEnabled = true;
                DlgMode = -1;
            }
        }

        public void UpdateGrid(Base.name_test nameTest)
        {
            if ((nameTest == null) && (MainGrid.ItemsSource != null))
            {
                nameTest = (Base.name_test)MainGrid.SelectedItem;
            }

            NameTest = new ObservableCollection<Base.name_test>(Database.name_test);
            MainGrid.ItemsSource = NameTest;
            MainGrid.SelectedItem = nameTest;
        }


        private void TestAdd_Click(object sender, RoutedEventArgs e)
        {
            TestDlgLoad(true, "Добавить тест");
            DataContext = null;
            DlgMode = 0;
        }

        private void TestEdit_Click(object sender, RoutedEventArgs e)
        {
            if (MainGrid.SelectedItem != null)
            {
                TestDlgLoad(true, "Изменить тест");
                SelectedTest = (Base.name_test)MainGrid.SelectedItem;
                //SelectedQuestion = (Base.question_table)MainGrid.SelectedItem;
                TestTextName.Text = SelectedTest.name;
                //SelectedBook = (Base.Books)BookDataGrid.SelectedItem;
                //BookTextName.Text = SelectedBook.Name;
                //BookTextAuthors.Text = SelectedBook.Authors;
                //BookComboBoxPublishers.Text = SelectedBook.Publishers.PublisherName;
                //BookTextPublishYear.Text = SelectedBook.PublishYear.ToString();
            }
            else
            {
                MessageBox.Show("Не выбрано ниодной строки!", "Сообщение", MessageBoxButton.OK);
            }
        }

    

        private void TestDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                try
                {
                    Base.name_test DeletingBook = (Base.name_test)MainGrid.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (MainGrid.SelectedIndex < MainGrid.Items.Count - 1)
                    {
                        MainGrid.SelectedIndex++;
                    }
                    else
                    {
                        if (MainGrid.SelectedIndex > 0)
                        {
                            MainGrid.SelectedIndex--;
                        }
                    }
                    Base.name_test SelectingTest = (Base.name_test)MainGrid.SelectedItem;
                    Database.name_test.Remove(DeletingBook);
                    Database.SaveChanges();
                    UpdateGrid(SelectingTest);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить запись, так как " +
                        "она используется в других справочниках базы " +
                        "данных.","Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
            }
        }

        private void TestAddCommit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TestTextName.Text))
                errors.AppendLine("Укажите имя теста");
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
                var NewTest = new Base.name_test();
                NewTest.name = TestTextName.Text;
                //NewBook.Authors = BookTextAuthors.Text;
                //NewBook.Publishers = (Base.Publishers)BookComboBoxPublishers.SelectedItem;
                //NewBook.PublishYear = (short?)int.Parse(BookTextPublishYear.Text);
                Database.name_test.Add(NewTest);
                SelectedTest = NewTest;
            }
            else
            {
                var EditTest = new Base.name_test();
                EditTest = Database.name_test.First(t => t.name == SelectedTest.name);
                EditTest.name = TestTextName.Text;
                //EditBook.Authors = BookTextAuthors.Text;
                //EditBook.Publishers = (Base.Publishers)BookComboBoxPublishers.SelectedItem;
                //EditBook.PublishYear = (short?)int.Parse(BookTextPublishYear.Text);
            }

            try
            {
                Database.SaveChanges();
                TestDlgLoad(false, "");
                UpdateGrid(SelectedTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void TestAddRollback_Click(object sender, RoutedEventArgs e)
        {
            TestDlgLoad(false, "");
            UpdateGrid(SelectedTest);
        }

        private void StartTest_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (MainGrid.SelectedIndex != -1)
                {
                    Base.name_test value = (Base.name_test)MainGrid.SelectedItem;
                    int valueName = Database.name_test.SingleOrDefault(t => t.name == value.name).id;
                    int valueTest = 0;
                    try
                    { valueTest = Database.user_tests.First(t => t.id_test == valueName).id; }
                    catch { }
                    if (valueTest > 0) 
                    {
                        MessageBox.Show("Данный тест уже пройден", "Инфо", MessageBoxButton.OK, MessageBoxImage.Question);
                        return;
                    }
                    PassTestPage page = new PassTestPage(value.name, _userId);
                    this.NavigationService.Navigate(page);
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UserProfileEllipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                UserProfilePage page = new UserProfilePage(_userId, _testId);
                this.NavigationService.Navigate(page);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TestQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            Base.name_test value = null;
            try { value = (Base.name_test)MainGrid.SelectedItem; } catch { }

            if (value == null) 
            {
                MessageBox.Show("Выберите тест", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            
            DataTestWindow window = new DataTestWindow(value.name);
            window.Show();
        }
    }
}
