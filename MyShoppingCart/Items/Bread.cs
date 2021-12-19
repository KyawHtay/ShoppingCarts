using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Items
{
    public class Bread : Products
    {
        public Bread(string name = "Bread", decimal price = 1.00m)
            : base(name, price)
        {
        }
    }
}
