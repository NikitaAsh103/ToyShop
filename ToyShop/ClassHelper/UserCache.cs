using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Models;

namespace ToyShop.ClassHelper
{
    public static class UserCache
    {
        public static Client currentClient = new Client();

        public static ObservableCollection<Product> productsCart = new ObservableCollection<Product>();
    }
}
