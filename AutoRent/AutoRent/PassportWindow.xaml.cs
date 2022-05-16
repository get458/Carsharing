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
    /// Логика взаимодействия для PassportWindow.xaml
    /// </summary>
    public partial class PassportWindow : Window
    {
        public PassportWindow()
        {
            InitializeComponent();
        }

        public void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (Passport.ValidateCredentials(SeriesBox.Text, NumberBox.Text, IssuePlaceBox.Text, IssueDateBox.Text))
            {
                DateTime dt = Convert.ToDateTime(IssueDateBox.Text);

                Passport.AddPasport(SeriesBox.Text, NumberBox.Text, IssuePlaceBox.Text, dt);
                this.Visibility = Visibility.Hidden;
                MessageBox.Show("Паспорт был добавлен");
            }
            else
            {
                MessageBox.Show("Заполните паспортные данные");
            }
        }

        public void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
