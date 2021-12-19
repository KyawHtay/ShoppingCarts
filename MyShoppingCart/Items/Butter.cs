using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Items
{
    public class Butter : Products
    {
        public Butter(string name = "Butter", decimal price = 0.80m)
           : base(name, price)
        {
        }
    }
}
