using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Items
{
    public class Milk : Products
    {
        public Milk(string name = "Milk", decimal price = 1.15m)
            : base(name, price)
        {
        }
    }
}
