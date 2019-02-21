using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Product : IProduct
    {
        public string Sku { get; set; }
        public int Price { get; set; }
    }
}
