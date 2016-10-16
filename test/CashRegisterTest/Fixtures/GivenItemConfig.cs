using System.Collections.Generic;
using CashRegister.Model;
using CashRegister.Model.Discount;

namespace CashRegisterTest.Fixtures
{
    public class GivenItemConfig
    {
        public static ItemConfig Config => new ItemConfig(
            "羽毛球", 1, "个", 
            new List<DiscountType>
            {
                DiscountType.BuyTwoGetOneFree
            });

        public static ItemConfig ConfigWithNinetyFiveDiscount => new ItemConfig(
            "羽毛球", 1, "个", 
            new List<DiscountType>
            {
                DiscountType.NinetyFivePercentDiscount
            });

        public static Dictionary<string, ItemConfig> ConfigList => new Dictionary<string, ItemConfig>
        {
            { "ITEM00001", new ItemConfig("羽毛球", 1m, "个", new List<DiscountType> { DiscountType.BuyTwoGetOneFree }) },
            { "ITEM00003", new ItemConfig("苹果", 5.5m, "斤", new List<DiscountType>()) },
            { "ITEM00005", new ItemConfig("羽毛球", 3m, "瓶", new List<DiscountType> { DiscountType.BuyTwoGetOneFree }) }
        };
    }
}