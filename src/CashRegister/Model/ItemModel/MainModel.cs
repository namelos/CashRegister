using System.Collections.Generic;
using System.Linq;

namespace CashRegister.Model.ItemModel
{
    public class MainModel
    {
        public IEnumerable<Category> CategorieList;

        public MainModel(IEnumerable<ItemDto> items, Dictionary<string, ItemConfig> configs)
        {
            CategorieList = items.Select(item =>
            {
                var config = configs[item.Code];
                return new Category(item, config);
            });
        }

        public decimal Total => CategorieList
            .Select(c => c.Subtotal)
            .Aggregate((x, y) => x + y);

        public decimal TotalSaved => CategorieList
            .Select(c => c.Saved)
            .Aggregate((x, y) => x + y);
    }
}