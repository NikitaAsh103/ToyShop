using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Models;

namespace ToyShop.ClassHelper
{
    public static class DBClass
    {
        public static Entities Context { get; } = new Entities();
    }
}
