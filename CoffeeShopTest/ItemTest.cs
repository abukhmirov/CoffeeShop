

namespace CoffeeShop
{
    public class ItemTest
    {
        [Fact]
        public void ItemConstructorCreatesValuesCorrectly()
        {
            Item Mocha = new Item("Mocha", 400);
            Assert.Equal("Mocha", Mocha.Name);
            Assert.Equal(400, Mocha.PriceInCents);
        }
        [Fact]
        public void ItemPriceInDollarsPriceGetsConvertedToDollars() 
        {
            Item Mocha = new Item("Mocha", 400);
            Assert.Equal(4.00, Mocha.PriceInDollars());
        }
    }
}