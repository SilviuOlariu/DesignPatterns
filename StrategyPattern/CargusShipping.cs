using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CargusShipping : ICalculatorShipping
    {
        public double CalculateShipping(Order order)
        {
            return 10;
        }
    }
}
