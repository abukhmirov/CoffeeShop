using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public int id;

        public List<Item> ItemsInOrder;

        public Order()
        {
            ItemsInOrder = new List<Item>();
        }

        public void AddItem(Item item)
        {
            ItemsInOrder.Add(item);
        }
        //public void RemoveItem(int id) { }
        //public string Items()
        //{
        //    return string.Join(", ", ItemsInOrder);
        //}
        public double Total()
        {
            
            double TotalPrice = 0;

            foreach (Item item in ItemsInOrder)
            {
               TotalPrice = TotalPrice + item.PriceInDollars();

            }
            return TotalPrice;
        }
    }


}
