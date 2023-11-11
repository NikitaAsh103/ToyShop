using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using ToyShop.ClassHelper;

namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPages.xaml
    /// </summary>
    public partial class AuthorizationPages : Page
    {
        public AuthorizationPages()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new MenuPages());

            var clientAuth = DBClass.Context.Client.ToList()
               .Where(i => i.Email == TbLogin.Text && i.Password == TbPassword.Text).FirstOrDefault();

            if (clientAuth != null)
            {
                // сохранияем данные входа
                UserCache.currentClient = clientAuth;

                FrameData.frame.Navigate(new MenuPages());

            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        //Регистрация
        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new RegistrationPages());
        }

        //GotFocus и LostFocus
        private void TbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text == " Логин")
            {
                TbLogin.Text = "";
            }
        }

        private void TbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text == "")
            {
                TbLogin.Text = " Логин";
            }
        }

        private void TbPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Text == " Пароль")
            {
                TbPassword.Text = "";
            }
        }

        private void TbPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Text == "")
            {
                TbPassword.Text = " Пароль";
            }
        }
    }
}
