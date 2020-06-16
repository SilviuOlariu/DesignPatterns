using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new LargePizza();
            pizza = new Cheese(pizza);
            pizza = new Ham(pizza);


           Console.WriteLine($"{pizza.GetDescription()} that have a cost of {pizza.CalculateCost()}");

        }
    }
}
