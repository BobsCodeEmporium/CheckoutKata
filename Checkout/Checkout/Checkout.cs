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
            var total = 0;
            foreach (var product in Basket.Items)
            {
                total += product.Price;
            }

            foreach (var offer in Basket.Offers)
            {
                if (Basket.Items.Count(x => x.Sku == offer.Sku) >= offer.Multiplier)
                {
                    var qualifyingItems = Basket.Items.Count(x => x.Sku == offer.Sku) / offer.Multiplier;
                    total = total - (Products.First(x => x.Sku == offer.Sku).Price * offer.Multiplier);
                    total += offer.Price * qualifyingItems;
                }
            }

            return total;
        }
    }
}
