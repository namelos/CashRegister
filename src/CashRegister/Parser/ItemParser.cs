using System.Linq;

namespace CashRegister.Parser
{
    public class ItemParser
    {
        public ItemParser(string inputString)
        {
            var pair = inputString.Split('-').ToList();
            Code = pair[0];
            Quantity = pair.Count == 1 ? 1 : int.Parse(pair[1]);
        }
        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public string Code { get; set; }
        public int Quantity { get; set; }
    }
}