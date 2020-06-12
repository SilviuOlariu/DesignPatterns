using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FunCurierShipping : ICalculatorShipping
    {
        public double CalculateShipping(Order order)
        {
            return 20;
        }
    }
}
