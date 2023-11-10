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
    /// Логика взаимодействия для MenuPages.xaml
    /// </summary>
    public partial class MenuPages : Page
    {
        public MenuPages()
        {
            InitializeComponent();
        }

        private void BtnCatalog_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new CatalogPages());
        }

        private void BtnHistoryOfOrders_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new HistoryOfOrdersPages());
        }

        private void BtnShoppingBasket_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new ShoppingBasketPages());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameData.frame.Navigate(new ProfilePages());
        }
    }
}
