using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegister.Model.Discount
{
    public class DiscountFormula
    {
        public IDiscount Discount;

        public DiscountFormula(ICollection<DiscountType> discountTypes, int quantity)
        {
            if (discountTypes.Contains(DiscountType.BuyTwoGetOneFree) &&
                discountTypes.Contains(DiscountType.NinetyFivePercentDiscount))
            {
                if (quantity > 2) { Discount = new BuyTwoGetOneFree(); }
                else { Discount = new NinetyFivePercent(); }
            } else if (discountTypes.Contains(DiscountType.BuyTwoGetOneFree))
            {
                Discount = new BuyTwoGetOneFree();
            } else if (discountTypes.Contains(DiscountType.NinetyFivePercentDiscount))
            {
                Discount = new NinetyFivePercent();
            } else {
                Discount = new NoDiscount();
            }
        }
    }
}
