using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Models;

namespace ToyShop.ClassHelper
{
    internal class Disc
    {
        public class ProductClass
        {

          

            public static ObservableCollection<ProductClass> CartProduct { get; set; } = new ObservableCollection<ProductClass>();

            public static decimal Discount(Product product)
            {
                if (product.Price >= 20000)
                {
                    product.Price = product.Price - (product.Price * 0.16m);
                }
                else if (product.Price >= 10000)
                {
                    product.Price = product.Price - (product.Price * 0.08m);
                }
                else if (product.Price >= 1000)
                {
                    product.Price = product.Price - (product.Price * 0.01m);
                }

                return product.Price;
            }

            public static decimal Promo(decimal sum)
            {
                if (sum >= 20000)
                {
                    sum = sum - (sum * 0.10m);
                }
                else if (sum >= 10000)
                {
                    sum = sum - (sum * 0.05m);
                }
                else if (sum >= 1000)
                {
                    sum = sum - (sum * 0.01m);
                }

                return sum;
            }
        }
    }
}
