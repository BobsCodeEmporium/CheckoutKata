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
        }

        public List<Product> Items { get; set; }
    }
}
