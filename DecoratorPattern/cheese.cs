using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Cheese : PizzaDecoretor
    {
        
        public Cheese(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + "Chesse";
        }
        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.2;
        }


    }
}
