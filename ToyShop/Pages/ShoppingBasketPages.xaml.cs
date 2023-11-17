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
using static ToyShop.ClassHelper.Disc;

namespace ToyShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShoppingBasketPages.xaml
    /// </summary>
    public partial class ShoppingBasketPages : Page
    {
        public decimal sum = 0;
        public ShoppingBasketPages()
        {
            InitializeComponent();

            foreach (var item in UserCache.productsCart)
            {
                sum += ProductClass.Discount(item);

            }
            tb_TotalPrice.Text = sum.ToString();

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

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int orderID;

            var order = new Models.Order() { ClientID = UserCache.currentClient.ClientID, EmployeeID = random.Next(1, 50) };
            DBClass.Context.Order.Add(order);
            DBClass.Context.SaveChanges();
            orderID = order.OrderID;

            foreach (var item in UserCache.productsCart)
            {
                DBClass.Context.OrderProduct.Add(new Models.OrderProduct()
                {
                    OrderID = orderID,
                    ProductID = item.ProductID,
                    Quantity = 1
                });
            }

            DBClass.Context.SaveChanges();

            UserCache.productsCart.Clear();

            MessageBox.Show("Покупка совершена!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
