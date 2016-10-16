using System.Collections.Generic;

namespace CashRegister.Model
{
    public interface IItemConfigRepository
    {
        Dictionary<string, ItemConfig> GetItemConfigs();
    }
}