using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EducationTests.Windows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow(Base.EducationTestsEntities database)
        {
            InitializeComponent();
            Database = database;

        }

        private Base.EducationTestsEntities Database;

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Base.Users User = new Base.Users();
            User.login = LoginTextBox.Text;
            User.password = PasswordPasswordBox.Password != "" ? PasswordPasswordBox.Password : PasswordTextBox.Text;
            User.role = false;
            Database.Users.Add(User);
            Database.SaveChanges();
            Close();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) => Close();

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            String Password = PasswordPasswordBox.Password;
            Visibility Visibility = PasswordPasswordBox.Visibility;
            double Width = PasswordPasswordBox.ActualWidth;
            PasswordButton.Content = Visibility == Visibility.Visible ? "Скрыть" : "Показать";
            PasswordPasswordBox.Password = PasswordTextBox.Text;
            PasswordPasswordBox.Visibility = PasswordTextBox.Visibility;
            PasswordPasswordBox.Width = PasswordTextBox.Width;
            PasswordTextBox.Text = Password;
            PasswordTextBox.Visibility = Visibility;
            PasswordTextBox.Width = Width;

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) 
        {
            try { DragMove(); } catch { }
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.JPEG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.jpeg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                ImageSource image = new BitmapImage(new Uri(openDialog.FileName));
                imageEllipse.ImageSource = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
    }
}
