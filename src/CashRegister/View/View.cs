using System.Collections.Generic;
using System.Linq;
using CashRegister.Model.ItemModel;

namespace CashRegister.View
{
    public class View
    {
        public IEnumerable<CategoryView> CategoryViews { get; }
        public Model.ItemModel.Model Model { get; }

        public View(Model.ItemModel.Model model)
        {
            Model = model;
            CategoryViews = model.CategorieList
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

        public string Total => $"总计:{Model.Total}(元)\n";

        public string TotalSaved => Model.TotalSaved > 0 ? $"节省:{Model.TotalSaved}(元)\n" : string.Empty;

        public string Render => 
            Header + Categories + Splitter +
            BuyTwoGetOneFreeSummarysWithSpliter + 
            Total + TotalSaved + Footer;
    }
}