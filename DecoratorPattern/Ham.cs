using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Ham : PizzaDecoretor
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + "Ham";
        }
        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.5;
        }
    }
}
