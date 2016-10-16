using System.Collections.Generic;
using System.Linq;
using CashRegister.Model.ItemModel;

namespace CashRegister.View
{
    public class MainView
    {
        public IEnumerable<CategoryView> CategoryViews { get; }
        public MainModel MainModel { get; }

        public MainView(MainModel mainModel)
        {
            MainModel = mainModel;
            CategoryViews = mainModel.CategorieList
                .Select(category => new CategoryView(category));
        }

        public string Categories => CategoryViews
            .Select(c => c.Show)
            .Aggregate((x, y) => x + y);

        public string Header => "***<没钱赚商店>购物清单***\n";

        public string Splitter => "----------------------\n";

        public string Footer => "**********************\n";

        public string BuyTwoGetOneFreeSummarys => CategoryViews
            .Select(c => c.BuyTwoGetOneFreeSummary)
            .Aggregate((x, y) => x + y);

        public string BuyTwoGetOneFreeSummarysWithSpliter =>
            BuyTwoGetOneFreeSummarys + Splitter;

        public string Total => $"总计:{MainModel.Total}(元)\n";

        public string TotalSaved => MainModel.TotalSaved > 0 ? $"节省:{MainModel.TotalSaved}(元)\n" : string.Empty;

        public string Render => 
            Header + Categories + Splitter +
            BuyTwoGetOneFreeSummarysWithSpliter + 
            Total + TotalSaved + Footer;
    }
}