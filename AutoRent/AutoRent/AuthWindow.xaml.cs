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
using System.Windows.Shapes;

namespace AutoRent
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        AdminWindow adminWindow = new AdminWindow();

        public AuthWindow()
        {
            InitializeComponent();
        }

        public void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            if (Auth.ValidateCredentials(LoginField.Text, PasswordField.Password))
            {
                int role;

                if (Auth.Authorization(LoginField.Text, PasswordField.Password, out role) && role == 1)
                {
                    this.Visibility = Visibility.Hidden;
                    adminWindow.Show();
                    MessageBox.Show("Добро пожаловать!");
                }
                else if (Auth.Authorization(LoginField.Text, PasswordField.Password, out role) && role == 2)
                {
                    this.Visibility = Visibility.Hidden;
                    MessageBox.Show("Пользователь");
                }

                else
                {
                    MessageBox.Show("Введены неверные данные.");
                }
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
    }
}
