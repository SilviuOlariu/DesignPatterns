using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class PizzaDecoretor : Pizza
    {
        protected Pizza _pizza;
        public PizzaDecoretor(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override double CalculateCost()
        {

           return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
         }
    }
}
