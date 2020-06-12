using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DHLShipping : ICalculatorShipping
    {
        public double CalculateShipping(Order order)
        {
            return 30;
        }
    }
}
