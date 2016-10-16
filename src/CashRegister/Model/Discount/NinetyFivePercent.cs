namespace CashRegister.Model.Discount
{
    public class NinetyFivePercent : IDiscount
    {
        public decimal Discount(decimal price, int quantity) => 
            0.95m*price*quantity;
    }
}