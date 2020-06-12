using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Order 
    {
        public int OrderId { get; set; }
        public string Item { get; set; }
        public ShippingOptions ShippingOptions { get; set; }

    }
}
