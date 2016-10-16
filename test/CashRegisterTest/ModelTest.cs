using System.Collections.Generic;
using CashRegister.Model.ItemModel;
using CashRegisterTest.Fixtures;

namespace CashRegisterTest
{
    public class ModelTest
    {
        public ModelTest()
        {
            Model = new Model(
                GivenItemDto.ItemDtos, 
                GivenItemConfig.ConfigList);
        }

        public Model Model { get; }
    }
}