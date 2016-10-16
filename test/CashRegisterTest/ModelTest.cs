using System.Collections.Generic;
using CashRegister.Model.ItemModel;
using CashRegisterTest.Fixtures;

namespace CashRegisterTest
{
    public class ModelTest
    {
        public ModelTest()
        {
            MainModel = new MainModel(
                GivenItemDto.ItemDtos, 
                GivenItemConfig.ConfigList);
        }

        public MainModel MainModel { get; }
    }
}