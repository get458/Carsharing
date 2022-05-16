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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        PassportWindow passportWindow = new PassportWindow();
        Passport passport = new Passport();

        public RegWindow()
        {
            InitializeComponent();
        }

        public void PassportButton_Click(object sender, RoutedEventArgs e)
        {
            passportWindow.Show();
        }

        public void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (Reg.ValidateCredentials(SurnameBox.Text, NameBox.Text, LastnameBox.Text, LoginBox.Text, PasswordBox.Password, PhonenumberBox.Text, DriverlicenseBox.Text))
            {
                if (Passport.ValidateCredentials(passportWindow.SeriesBox.Text, passportWindow.NumberBox.Text, passportWindow.IssuePlaceBox.Text, passportWindow.IssueDateBox.Text))
                {
                    int passportID = Passport.GetPassportID(passportWindow.SeriesBox.Text, passportWindow.NumberBox.Text);
                    Reg.Registration(SurnameBox.Text, NameBox.Text, LastnameBox.Text, LoginBox.Text, PasswordBox.Password, PhonenumberBox.Text, DriverlicenseBox.Text, passportID);
                    MessageBox.Show("Регистрация успешна");
                }
                else
                {
                    MessageBox.Show("Заполните паспортные данные!");
                }
            }
            else 
            {
                MessageBox.Show("Заполните все данные!");
            }
        }

        public void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
