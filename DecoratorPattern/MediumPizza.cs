using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
   public class MediumPizza: Pizza
    {
        public override double CalculateCost()
        {
            return 20;
        }

        public override string GetDescription()
        {
            return Description = "This is a medium pizza";
        }
    }
}
