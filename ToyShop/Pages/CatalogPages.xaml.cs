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
using ToyShop.Models;
using static ToyShop.ClassHelper.FrameData;

namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPages.xaml
    /// </summary>
    public partial class CatalogPages : Page
    {
        public CatalogPages()
        {
            InitializeComponent();
             
            LvProduct.ItemsSource = DBClass.Context.Product.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {
            
            var boundData = (Product)((Button)sender).DataContext;

            UserCache.productsCart.Add(boundData);

            MessageBox.Show("Товар добавлен в корзину!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
