using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegister.Model.Discount
{
    public class BuyTwoGetOneFree : IDiscount
    {
        public decimal Discount(decimal price, int quantity) => 
            quantity - Math.Floor((decimal) quantity/3)*price;
    }
}
