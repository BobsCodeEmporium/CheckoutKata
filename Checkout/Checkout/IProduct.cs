using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public interface IProduct
    {
        string Sku { get; set; }

        int Price { get; set; }

        IOffer Offer { get; set; }
    }
}
