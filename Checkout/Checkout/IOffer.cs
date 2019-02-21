using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public interface IOffer
    {
        int Multiplier { get; set; }
        int Price { get; set; }
        string Sku { get; set; }
    }
}
