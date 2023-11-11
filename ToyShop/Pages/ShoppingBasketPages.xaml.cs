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
using static ToyShop.ClassHelper.FrameData;

namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShoppingBasketPages.xaml
    /// </summary>
    public partial class ShoppingBasketPages : Page
    {
        public ShoppingBasketPages()
        {
            InitializeComponent();
            LvProduct.ItemsSource = UserCache.productsCart;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var boundData = (Models.Product)((Button)sender).DataContext;

            UserCache.productsCart.Remove(boundData);

            LvProduct.ItemsSource = UserCache.productsCart;
        }
    }
}
