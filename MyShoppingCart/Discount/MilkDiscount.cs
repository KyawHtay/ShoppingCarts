using MyShoppingCart.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Discount
{
    public class MilkDiscount : IDiscount
    {
        private const decimal DISCOUNT_PERCENTAGE = 0;
        private const int MIN_NUMBER_FOR_DISCOUNT = 3;
        public void ProcessForDiscounts(IShoppingCart shoppingBasket)
        {
            int total = shoppingBasket.ItemsInBasket.Where(i => i.Product is Milk).Select(i => i.Quantity).Sum();

            int freeMilksToGive = total / MIN_NUMBER_FOR_DISCOUNT;
            int freeMilksGiven = 0;

            foreach (IShoppingCartItem item in shoppingBasket.ItemsInBasket)
            {
                if (item.Product is Milk && total >= MIN_NUMBER_FOR_DISCOUNT && freeMilksGiven < freeMilksToGive)
                {
                    int freeMilksToGiveIn = item.Quantity / MIN_NUMBER_FOR_DISCOUNT;

                    // This handles special case when milks are added one by one in separate items
                    if (freeMilksToGiveIn == 0)
                        freeMilksToGiveIn = 1;

                    // Update the price of shopping basket item
                    item.UpdatePrice(DISCOUNT_PERCENTAGE, freeMilksToGiveIn);

                   freeMilksGiven += freeMilksToGiveIn;
                }
            }
        }
    }
}
