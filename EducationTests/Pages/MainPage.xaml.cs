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
        public MainPage()
        {
            InitializeComponent();
            DataContext = this;
            MainGrid.ItemsSource = SourceCore.testsDataBase.name_test.ToList();
            UpdateGrid(null);
            BookDlgLoad(false, "");
            DataContext = this;
        }

        private int DlgMode;
        public Base.name_test SelectedTest;
        public ObservableCollection<Base.name_test> NameTest;

        public void BookDlgLoad(bool b, string DlgModeContent)
        {
            if (b == true)
            {
                TestColumnChange.Width = new GridLength(400);
                MainGrid.IsHitTestVisible = false;
                //BookLabel.Content = DlgModeContent;
                TestAddCommit.Content = DlgModeContent;
                TestAdd.IsEnabled = false;
                TestCopy.IsEnabled = false;
                TestEdit.IsEnabled = false;
                TestDellete.IsEnabled = false;
            }
            else
            {
                TestColumnChange.Width = new GridLength(0);
                MainGrid.IsHitTestVisible = true;
                TestAdd.IsEnabled = true;
                TestCopy.IsEnabled = true;
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

            NameTest = new ObservableCollection<Base.name_test>(SourceCore.testsDataBase.name_test);
            MainGrid.ItemsSource = NameTest;
            MainGrid.SelectedItem = nameTest;
            //BookComboBoxPublishers.ItemsSource = SourceCore.MyBase.Publishers.ToList();
        }


        private void TestAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestAddCommit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestAddRollback_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartTest_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (MainGrid.SelectedIndex != -1)
                {
                    PassTestPage page = new PassTestPage(MainGrid.SelectedIndex + 1);
                    this.NavigationService.Navigate(page);
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
