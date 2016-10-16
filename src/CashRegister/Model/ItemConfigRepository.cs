using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model.Discount;
using CashRegister.Model.ItemModel;

namespace CashRegister.Model
{
    public class ItemConfigRepository : IItemConfigRepository
    {
        public Dictionary<string, ItemConfig> ItemConfigs { get; }

        public ItemConfigRepository()
        {
            ItemConfigs = new Dictionary<string, ItemConfig>
            {
                { "ITEM00001", new ItemConfig("羽毛球", 1m, "个", new List<DiscountType> { DiscountType.BuyTwoGetOneFree }) },
                { "ITEM00003", new ItemConfig("苹果", 5.5m, "斤", new List<DiscountType>()) },
                { "ITEM00005", new ItemConfig("羽毛球", 3m, "瓶", new List<DiscountType> { DiscountType.BuyTwoGetOneFree }) }
            };
        }

        public Dictionary<string, ItemConfig> GetItemConfigs() => ItemConfigs;
    }
}
