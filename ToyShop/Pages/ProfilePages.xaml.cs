using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using ToyShop.ClassHelper;
using static ToyShop.ClassHelper.FrameData;
namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePages.xaml
    /// </summary>
    public partial class ProfilePages : Page
    {
        public ProfilePages()
        {
            InitializeComponent();

            TbLastName.Text = UserCache.currentClient.LastName;
            TbFirsName.Text = UserCache.currentClient.FirstName;
            TbEmail.Text = UserCache.currentClient.Email;
            TbPassword.Text = UserCache.currentClient.Password;
            TbPatronymic.Text = UserCache.currentClient.MiddleName;
            CmbGender.ItemsSource = DBClass.Context.Gender.ToList();
            TbPhoneNumber.Text = "Не задан";
            CmbGender.SelectedIndex = UserCache.currentClient.GenderID - 1;

            DisableTextBoxes();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //DBClass.Context.Client.AddOrUpdate(new Models.Client()
                //{
                //    LastName = TbLastName.Text,
                //    FirstName = TbFirsName.Text,
                //    MiddleName = TbPatronymic.Text,
                //    Email = TbEmail.Text,
                //    Password = TbPassword.Text,
                //    GenderID = CmbGender.SelectedIndex + 1
                //});

                //DBClass.Context.SaveChanges();

                frame.Navigate(new AuthorizationPages());
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось изменить данные( \nПопробуйте ещё раз!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisableTextBoxes()
        {
            TbLastName.IsEnabled = false;
            TbFirsName.IsEnabled = false;
            TbEmail.IsEnabled = false;
            TbPassword.IsEnabled = false;
            TbPatronymic.IsEnabled = false;
            CmbGender.IsEnabled = false;
            DPDateOfBirthday.IsEnabled = false;
        }

        private void EnableTextBoxes()
        {
            TbLastName.IsEnabled = true;
            TbFirsName.IsEnabled = true;
            TbEmail.IsEnabled = true;
            TbPassword.IsEnabled = true;
            TbPatronymic.IsEnabled = true;
            CmbGender.IsEnabled = true;
            DPDateOfBirthday.IsEnabled = true;
        }
    }
}
