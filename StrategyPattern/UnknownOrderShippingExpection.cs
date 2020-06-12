using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
   public class UnknownOrderShippingExpection :Exception
    {
        public UnknownOrderShippingExpection()
        {

        }
        public UnknownOrderShippingExpection(string message) : base(message) 
        {
            
        }
    }
}
