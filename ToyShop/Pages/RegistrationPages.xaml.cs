﻿using System;
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
using static ToyShop.ClassHelper.FrameData;

namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPages.xaml
    /// </summary>
    public partial class RegistrationPages : Page
    {
        public RegistrationPages()
        {
            InitializeComponent();

            //CmbGender.ItemsSource = ClassHelper.EFclass.Contexts.Gender.ToList();
            //CmbGender.SelectedIndex = 0;
            //CmbGender.DisplayMemberPath = "GenderName";
        }




        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {

            //Валидация тоже поменять в зависимости от базы


            ////Валидация поля Логин
            //if (TbLogin.Text == "Введите Логин")
            //{
            //    MessageBox.Show("Поле Логин должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (string.IsNullOrWhiteSpace(TbLogin.Text))
            //{
            //    MessageBox.Show("Поле Логин должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (TbLogin.Text.Length > 30)
            //{
            //    MessageBox.Show("Доупустимое количество символов в поле логин 30", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            ////Валидация поля Email
            //if (TbEmail.Text == "Введите Email")
            //{
            //    MessageBox.Show("Поле Email должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //else if (string.IsNullOrWhiteSpace(TbEmail.Text))
            //{
            //    MessageBox.Show("Поле Email должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //string[] dataLogin = TbEmail.Text.Split('@'); // делим строку на две части
            //if (dataLogin.Length != 2) // проверяем если у нас две части
            //{
            //    MessageBox.Show("Поле Email заполнено не по формату x@x.x", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //string[] data2Login = dataLogin[1].Split('.'); // делим вторую часть ещё на две части
            //if (data2Login.Length != 2) // проверяем если у нас две части
            //{
            //    MessageBox.Show("Поле Email заполнено не по формату x@x.x", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            ////Валидация поля Фамилия
            //if (TbLastName.Text == "Введите Фамилию")
            //{
            //    MessageBox.Show("Поле Фамилия должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //else if (string.IsNullOrWhiteSpace(TbLastName.Text))
            //{
            //    MessageBox.Show("Поле Фамилия должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //else if (TbLastName.Text.Length < 3 && TbLastName.Text.Length > 50)
            //{
            //    MessageBox.Show("Неправильно заполнено поле Фамилия", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //bool symbol = false;
            //bool number = false;

            //for (int i = 0; i < TbLastName.Text.Length; i++) // перебираем символы
            //{
            //    if (TbLastName.Text[i] >= '0' && TbLastName.Text[i] <= '9') number = true;
            //    if (TbLastName.Text[i] == '-' || TbLastName.Text[i] == '_' ||
            //        TbLastName.Text[i] == '=' || TbLastName.Text[i] == '+' ||
            //        TbLastName.Text[i] == ':' || TbLastName.Text[i] == ';' ||
            //        TbLastName.Text[i] == '!' || TbLastName.Text[i] == '@' ||
            //        TbLastName.Text[i] == '#' || TbLastName.Text[i] == '%' ||
            //        TbLastName.Text[i] == '*') symbol = true;
            //}

            //if (number)
            //{
            //    MessageBox.Show("В поле Фамилия не должны присутствовать цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (symbol)
            //{
            //    MessageBox.Show("В поле Фамилия не должны присутствовать символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            ////Валидация поля Имя
            //if (TbFirsName.Text == "Введите Имя")
            //{
            //    MessageBox.Show("Поле Имя должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //else if (string.IsNullOrWhiteSpace(TbFirsName.Text))
            //{
            //    MessageBox.Show("Поле Имя должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (TbFirsName.Text.Length < 2 && TbFirsName.Text.Length > 50)
            //{
            //    MessageBox.Show("Неправильно заполнено поле Фамилия", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //for (int i = 0; i < TbFirsName.Text.Length; i++) // перебираем символы
            //{
            //    if (TbFirsName.Text[i] >= '0' && TbFirsName.Text[i] <= '9') number = true;
            //    if (TbFirsName.Text[i] == '-' || TbFirsName.Text[i] == '_' ||
            //        TbFirsName.Text[i] == '=' || TbFirsName.Text[i] == '+' ||
            //        TbFirsName.Text[i] == ':' || TbFirsName.Text[i] == ';' ||
            //        TbFirsName.Text[i] == '!' || TbFirsName.Text[i] == '@' ||
            //        TbFirsName.Text[i] == '#' || TbFirsName.Text[i] == '%' ||
            //        TbFirsName.Text[i] == '*') symbol = true;
            //}

            //if (number)
            //{
            //    MessageBox.Show("В поле Имя не должны присутствовать цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (symbol)
            //{
            //    MessageBox.Show("В поле Имя не должны присутствовать символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            ////Валидация поля Отчество
            //if (TbPatronymic.Text == "Введите Отчество")
            //{
            //    MessageBox.Show("Поле Отчество должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (string.IsNullOrWhiteSpace(TbPatronymic.Text))
            //{
            //    MessageBox.Show("Поле Отчество должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (TbPatronymic.Text.Length < 2 && TbPatronymic.Text.Length > 50)
            //{
            //    MessageBox.Show("Неправильно заполнено поле Фамилия", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            //for (int i = 0; i < TbFirsName.Text.Length; i++) // перебираем символы
            //{
            //    if (TbPatronymic.Text[i] >= '0' && TbPatronymic.Text[i] <= '9') number = true;
            //    if (TbPatronymic.Text[i] == '-' || TbPatronymic.Text[i] == '_' ||
            //        TbPatronymic.Text[i] == '=' || TbPatronymic.Text[i] == '+' ||
            //        TbPatronymic.Text[i] == ':' || TbPatronymic.Text[i] == ';' ||
            //        TbPatronymic.Text[i] == '!' || TbPatronymic.Text[i] == '@' ||
            //        TbPatronymic.Text[i] == '#' || TbPatronymic.Text[i] == '%' ||
            //        TbPatronymic.Text[i] == '*') symbol = true;
            //}

            //if (number)
            //{
            //    MessageBox.Show("В поле Отчество не должны присутствовать цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (symbol)
            //{
            //    MessageBox.Show("В поле Отчество  не должны присутствовать символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            ////Валидация поля Номер телефона
            //if (TbPhoneNumber.Text == "Введите Номер")
            //{
            //    MessageBox.Show("Поле Номер должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else if (string.IsNullOrWhiteSpace(TbPhoneNumber.Text))
            //{
            //    MessageBox.Show("Поле Логин должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            ////Валидация поля Пол
            //else if (string.IsNullOrWhiteSpace(CmbGender.Text))
            //{
            //    MessageBox.Show("Поле Пола должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            ////Валидация поля Дата Рождения
            //else if (string.IsNullOrWhiteSpace(DPDateOfBirthday.Text))
            //{
            //    MessageBox.Show("Поле Даты Рождения должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            ////Валидация поля Пароль
            //else if (string.IsNullOrWhiteSpace(PbPassword.Password))
            //{
            //    MessageBox.Show("Поле Пароль должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}




            ////Добавление Пользователя
            //EFclass.Contexts.User.Add(new User()
            //{
            //    Login = TbLogin.Text,
            //    Password = PbPassword.Password,
            //    LastName = TbLastName.Text,
            //    FirstName = TbFirsName.Text,
            //    Patronymic = TbPatronymic.Text,
            //    Email = TbEmail.Text,
            //    PhoneNumber = TbPhoneNumber.Text,
            //    Birthday = DPDateOfBirthday.SelectedDate.Value,
            //    IDGender = (CmbGender.SelectedItem as Gender).IDGender,
            //});

            //EFclass.Contexts.SaveChanges();
            //MessageBox.Show("OK");
        }



        //GotFocus и LostFocus

        private void TbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if(TbLogin.Text == "Введите Логин")
            {
                TbLogin.Text = "";
            }
        }

        private void TbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text == "")
            {
                TbLogin.Text = "Введите Логин";
            }
        }

        private void TbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == "Введите Email")
            {
                TbEmail.Text = "";
            }
           
        }

        private void TbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == "")
            {
                TbEmail.Text = "Введите Email";
            }
        }

        private void TbLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbLastName.Text == "Введите Фамилию")
            {
                TbLastName.Text = "";
            }
        }

        private void TbLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbLastName.Text == "")
            {
                TbLastName.Text = "Введите Фамилию";
            }
        }

        private void TbFirsName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbFirsName.Text == "Введите Имя")
            {
                TbFirsName.Text = "";
            }
        }

        private void TbFirsName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbFirsName.Text == "")
            {
                TbFirsName.Text = "Введите Имя";
            }
        }

        private void TbPatronymic_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPatronymic.Text == "Введите Oтчество")
            {
                TbPatronymic.Text = "";
            }
        }

        private void TbPatronymic_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPatronymic.Text == "")
            {
                TbPatronymic.Text = "Введите Oтчество";
            }
        }

        private void TbPhoneNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPhoneNumber.Text == "Введите Номер")
            {
                TbPhoneNumber.Text = "";
            }
        }

        private void TbPhoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPhoneNumber.Text == "")
            {
                TbPhoneNumber.Text = "Введите Номер";
            }
        }

        private void TbPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Text == "Введите Пароль")
            {
                TbPassword.Text = "";
            }
        }

        private void TbPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Text == "")
            {
                TbPassword.Text = "Введите Номер";
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }

        
    }
}
