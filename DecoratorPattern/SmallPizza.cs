using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SmallPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 10;
        }

        public override string GetDescription()
        {
            return   Description = "This is a small pizza";
        }
    }
}
