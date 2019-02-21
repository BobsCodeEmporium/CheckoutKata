using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Offer : IOffer
    {
        public int Multiplier { get; set; }
        public int Price { get; set; }

        public string Sku { get; set; }
    }
}
