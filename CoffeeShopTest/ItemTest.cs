using CoffeeShop;

namespace CoffeeShopTest
{
    public class ItemTest
    {
        [Fact]
        public void ItemConstructorCreatesValuesCorrectly()
        {
            Item Mocha = new Item("Mocha", 800);
            Assert.Equal("Mocha", Mocha.Name);
            Assert.Equal(800, Mocha.PriceInCents);
        }
    }
}