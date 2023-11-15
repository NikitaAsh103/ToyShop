using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для HistoryOfOrdersPages.xaml
    /// </summary>
    public partial class HistoryOfOrdersPages : Page
    {
        public HistoryOfOrdersPages()
        {
            InitializeComponent();

            SqlParameter param = new SqlParameter("@ClientID", UserCache.currentClient.ClientID);

            LvProduct.ItemsSource = DBClass.Context.Product
                    .SqlQuery("SELECT p.* FROM Product p JOIN " +
                    "OrderProduct op ON op.ProductID = p.ProductID JOIN " +
                    "[Order] o ON o.OrderID = op.OrderID JOIN " +
                    "ProductCartOrder pco ON pco.OrderID = o.OrderID JOIN " +
                    "ProductCart pc ON pc.ProductCartID = pco.ProductCartID " +
                    "WHERE pc.ClientID = @ClientID", param).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }
    }
}
