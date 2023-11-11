using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Models;

namespace ToyShop.ClassHelper
{
    public static class UserCache
    {
        public static Client currentClient;

        public static List<Product> productsCart = new List<Product>();
    }
}
