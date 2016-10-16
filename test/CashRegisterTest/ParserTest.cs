using System.Linq;
using CashRegister.Parser;
using CashRegisterTest.Fixtures;
using Xunit;

namespace CashRegisterTest
{
    public class ParserTest
    {
        public class ItemParserTest
        {
            [Fact]
            public void ShouldParsePluralItemInput()
            {
                var parsed = new ItemParser(GivenItemInput.PluralItemInput);
                Assert.Equal(parsed.Code, "ITEM00003");
                Assert.Equal(parsed.Quantity, 2);
            }

            [Fact]
            public void ShouldParseSingularItemInput()
            {
                var parsed = new ItemParser(GivenItemInput.SingularItemInput);
                Assert.Equal(parsed.Code, "ITEM00001");
                Assert.Equal(parsed.Quantity, 1);
            }
        }

        [Fact]
        public void ShouldGroupInputsToItems()
        {
            var parsedItems = new InputParser(GivenItemInput.InputList).ParsedItems;
            var item00001 = parsedItems.Find(x => x.Code == "ITEM00001");
            Assert.Equal(item00001.Quantity, 5);
            var item00003 = parsedItems.Find(x => x.Code == "ITEM00003");
            Assert.Equal(item00003.Quantity, 2);
            var item00005 = parsedItems.Find(x => x.Code == "ITEM00005");
            Assert.Equal(item00005.Quantity, 3);
        }
    }
}