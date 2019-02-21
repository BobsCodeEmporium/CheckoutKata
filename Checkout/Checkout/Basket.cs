using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Basket
    {
        public Basket()
        {
            Items = new List<Product>();
            Offers = new List<IOffer>
            {
                new Offer {Sku = "A", Multiplier = 3, Price = 130},
                new Offer {Sku = "B", Multiplier = 2, Price = 45}
            };
        }

        public List<Product> Items { get; set; }

        public List<IOffer> Offers { get; set; }
    }
}
