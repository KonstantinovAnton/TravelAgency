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
    /// Логика взаимодействия для PageAuthorization.xaml
    /// </summary>
    public partial class PageAuthorization : Page
    {
        public PageAuthorization()
        {
            InitializeComponent();
        }

        private void btnAuthorizate_Click(object sender, RoutedEventArgs e)
        {


            var userObjr = Base.EM.User.FirstOrDefault(x => x.login == "admin");

            int hashPass = passBox.Password.ToString().GetHashCode();

            try
            {
                var userObj = Base.EM.User.FirstOrDefault(x => x.login == textBoxLogin.Text && x.password == hashPass);

                if(userObj == null)
                {
                    MessageBox.Show("Таких нет!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch(userObj.id_role)
                    {
                        case 1:
                            MessageBox.Show("Админ");
                            break;

                        case 2:
                            MessageBox.Show("Пользователь");
                            break;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
