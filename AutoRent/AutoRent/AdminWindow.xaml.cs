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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        AutoRent_User selectedUser = new AutoRent_User();

        public AdminWindow()
        {
            InitializeComponent();
            var users = GetInf.GetUsersInformation();
            usersDataBinding.ItemsSource = users;
        }

        private void NewCarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DeleteCarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void EditCarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetContractInformationButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
