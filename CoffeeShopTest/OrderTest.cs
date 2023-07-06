using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop
{

    public class OrderTest
    {
        [Fact]
        public void OrderConstructorCreatesValuesCorrectly()
        {
            Order order1 = new Order();
            Assert.Equal(new List<Item>(), order1.ItemsInOrder);
        }

        [Fact]
        public void OrderAddItemItemGetsAdded()
        {
            Order order1 = new Order();
            Item item = new Item("item", 400);
            Item item2 = new Item("item2", 400);

            order1.AddItem(item);
            order1.AddItem(item2);

            Assert.Equal(item, order1.ItemsInOrder[0]);
            Assert.Equal(item2, order1.ItemsInOrder[1]);

        }

        [Fact]
       
        public void OrderTotalTotalPrcieGetsShownCorrectly()
        {
            Order order1 = new Order();
            Item item = new Item("item", 400);
            Item item2 = new Item("item2", 400);

            order1.AddItem(item);
            order1.AddItem(item2);

            Assert.Equal(8.00, order1.Total());
        }

    }
}
