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




            //Если понадобится код входа там поменять в зависимости от базы


            //var userAuth = Contexts.User.ToList()
            //   .Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();

            //// проверка на работника
            //if (userAuth != null)
            //{
            //    // сохранияем данные входа
            //    ClassHelper.UserDataClass.User = userAuth;

            //    var emplAuth = Contexts.Employee.Where(i => i.IDUser == userAuth.IDUser).FirstOrDefault();
            //    if (emplAuth != null)
            //    {


            //        // сохраняем данные входа для Сотрудника

            //        ClassHelper.UserDataClass.Employee = emplAuth;

            //        // проверка роли 

            //        switch (emplAuth.IDPosition)
            //        {
            //            case 1:
            //                // переход на страницу директора
            //                DirectorWindows directorWindow = new DirectorWindows();
            //                directorWindow.Show();

            //                break;

            //            case 2:
            //                // переход на страницу администратора
            //                break;
            //            case 3:
            //                // переход на страницу продавца
            //                ProductListWindow productWindow = new ProductListWindow();
            //                productWindow.Show();
            //                break;
            //            default:
            //                break;
            //        }

            //    }
            //    else
            //    {
            //        // Client

            //        // сохраняем клиента
            //        //ClassHelper.UserDataClass.Client = userAuth;


            //        ProductListWindow productListWindow = new ProductListWindow();
            //        productListWindow.Show();


            //    }


            //}
            //else
            //{
            //    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

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
            if (TbPassword.Text ==" Пароль")
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
