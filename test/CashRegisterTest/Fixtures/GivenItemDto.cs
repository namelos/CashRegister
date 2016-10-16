using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model.ItemModel;

namespace CashRegisterTest.Fixtures
{
    public class GivenItemDto
    {
        public static ItemDto ItemDto = new ItemDto("ITEM0001", 5);

        public static List<ItemDto> ItemDtos => new List<ItemDto>
        {
            new ItemDto("ITEM00001", 5),
            new ItemDto("ITEM00003", 2),
            new ItemDto("ITEM00005", 3)
        };
    }
}
