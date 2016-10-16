using CashRegister.Model.ItemModel;
using Xunit;

namespace CashRegisterTest
{
    public class CategoryTest
    {
        public CategoryTest()
        {
            Category = new Category(
                Fixtures.GivenItemDto.ItemDto,
                Fixtures.GivenItemConfig.Config); 
        }

        [Fact]
        public void ShouldCalculateSaved() =>
            Assert.Equal(1, Category.Saved);

        [Fact]
        public void ShouldCalculateSubtotal() =>
            Assert.Equal(4, Category.Subtotal);

        [Fact]
        public void ShouldCalculateSubtotalWithoutDiscount() =>
            Assert.Equal(5, Category.SubtotalWithOutDiscount);

        public Category Category { get; }
    }
}