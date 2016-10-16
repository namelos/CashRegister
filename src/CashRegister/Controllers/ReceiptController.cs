using System.Collections.Generic;
using CashRegister.Model;
using CashRegister.Model.ItemModel;
using CashRegister.Parser;
using CashRegister.View;
using Microsoft.AspNetCore.Mvc;

namespace CashRegister.Controllers
{
    [Route("/")]
    public class ReceiptController : Controller
    {
        public ReceiptController(IItemConfigRepository itemConfigs)
        {
            ItemConfigs = itemConfigs;
        }

        [HttpGet]
        public string Index()
        {
            return "POST Array<string> to get receipt";
        }

        [HttpPost]
        public string PrintReceipt(IEnumerable<string> inputs)
        {
            var parsed = new InputParser(inputs);
            var model = new MainModel(parsed.ItemDtos, ItemConfigs.GetItemConfigs());
            var view = new MainView(model);
            return view.Render;
        }

        public IItemConfigRepository ItemConfigs;
    }
}