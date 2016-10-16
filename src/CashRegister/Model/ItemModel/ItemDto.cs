namespace CashRegister.Model.ItemModel
{
    public class ItemDto
    {
        public ItemDto(string code, int quantity)
        {
            Code = code;
            Quantity = quantity;
        }

        public string Code { get; }
        public int Quantity { get; }
    }
}