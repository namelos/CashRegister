using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model.Discount;

namespace CashRegister.Model
{
    public class ItemConfig
    {
        public ItemConfig(string name, decimal price, string unit, List<DiscountType> discounts)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Discounts = discounts;
        }

        public string Name { get; }
        public decimal Price { get; }
        public string Unit { get; }
        public List<DiscountType> Discounts { get; }
    }
}
