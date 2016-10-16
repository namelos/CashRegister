using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegister.Model.Discount
{
    public class NoDiscount : IDiscount
    {
        public decimal Discount(decimal price, int quantity) => 
            price*quantity;
    }
}
