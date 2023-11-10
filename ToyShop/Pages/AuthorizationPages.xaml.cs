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
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new RegistrationPages());
        }
    }
}
