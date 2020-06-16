using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
   public class LargePizza: Pizza
    {

        public override double CalculateCost()
        {
            return 30;
        }

        public override string GetDescription()
        {
            return Description = "This is a Large pizza";
        }
    }
}
