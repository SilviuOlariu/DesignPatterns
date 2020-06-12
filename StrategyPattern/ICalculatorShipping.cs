using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
 public   interface ICalculatorShipping
    {
        double CalculateShipping(Order order);
    }
}
