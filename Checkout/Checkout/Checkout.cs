using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Checkout
{
    public class Checkout : ICheckout
    {
        public Checkout()
        {
            Basket = new Basket();
            Products = new List<Product>
            {
                new Product {Sku = "A", Price = 50},
                new Product {Sku = "B", Price = 30},
                new Product {Sku = "C", Price = 20},
                new Product {Sku = "D", Price = 15},
            };
        }

        public Basket Basket { get; set; }

        public List<Product> Products { get; set; }

        public void Scan(string item)
        {
            Basket.Items.Add(Products.First(x => x.Sku == item));
        }

        public int GetTotalPrice()
        {
            //TODO Take offers into account

            var total = 0;
            foreach (var product in Basket.Items)
            {
                total += product.Price;
            }

            return total;
        }
    }
}
