using MyShoppingCart.Discount;
using MyShoppingCart.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Discount
{
    public class ButterDiscount : IDiscount
    {
        private const decimal DISCOUNT_PERCENTAGE = 0.5m;
        private const int MIN_NUMBER_FOR_DISCOUNT = 2;
        private const int MAX_NUMBER_OF_DISCOUNTS = 1;
        public void ProcessForDiscounts(IShoppingCart shoppingBasket)
        {
            int total = shoppingBasket.ItemsInBasket.Where(i => i.Product is Butter).Select(i => i.Quantity).Sum();

            int freeBreadsGiven = 0;
            foreach (IShoppingCartItem item in shoppingBasket.ItemsInBasket)
            {
                if (item.Product is Bread &&
                    total >= MIN_NUMBER_FOR_DISCOUNT &&
                    freeBreadsGiven < MAX_NUMBER_OF_DISCOUNTS)
                {
                   
                    item.UpdatePrice(DISCOUNT_PERCENTAGE, MAX_NUMBER_OF_DISCOUNTS - freeBreadsGiven);

                    freeBreadsGiven++;
                }
            }
        }
    }
}
