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
    /// Логика взаимодействия для ProfilePages.xaml
    /// </summary>
    public partial class ProfilePages : Page
    {
        public ProfilePages()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }
    }
}
