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

namespace TravelAgency
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, RoutedEventArgs e) // Добавления пользователя в БД
        {

            try
            {
                User user = new User()
                {
                    surname = textBoxSurname.Text,
                    name = textBoxName.Text,
                    patronymic = textBoxPatronymic.Text,
                    login = textBoxLogin.Text,
                    password = passBox.ToString().GetHashCode(),
                    birthday = datePickBirthday.SelectedDate.Value,
                    id_role = 2,
                    id_gender = 1
                };

                Base.EM.User.Add(user);
                Base.EM.SaveChanges();

                MessageBox.Show("Пользователь успешно зарегистрирован", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {

            }
            
        }
    }
}
