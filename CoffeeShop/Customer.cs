﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            List<Order> orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public void ItemsOrdered(Order order) 
        {
            Console.WriteLine(order.ItemsInOrder.Select(e => e.Name).Distinct());
        }
        public double TotalSpent(Order order)
        {
            double total = 0;
            foreach (var item in order.ItemsInOrder) 
            {
                total = item.PriceInDollars() + total;
            }
            return total;
        }
    }
}
