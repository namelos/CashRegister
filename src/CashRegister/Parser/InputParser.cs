using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model;
using CashRegister.Model.ItemModel;

namespace CashRegister.Parser
{
    public class InputParser
    {
        public InputParser(IEnumerable<string> inputs)
        {
            ParsedItems = inputs
                .Select(input => new ItemParser(input))
                .GroupBy(parsedItem => parsedItem.Code)
                .Select(groupedItem =>
                {
                    return groupedItem.Aggregate((item1, item2) =>
                    {
                        item1.AddQuantity(item2.Quantity);
                        return item1;
                    });
                }).ToList();
        }

        public List<ItemDto> ItemDtos => ParsedItems
            .Select(parsedItem => new ItemDto(parsedItem.Code, parsedItem.Quantity))
            .ToList();

        public List<ItemParser> ParsedItems;
    }
}
