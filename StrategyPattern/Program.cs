using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            var order = new Order { OrderId = 1, Item = "Phone", ShippingOptions = ShippingOptions.FunCurier };

            ICalculatorShipping calculatorShipping = new FunCurierShipping();

            var shippingService = new ShippingCostCalculatorService(calculatorShipping);

            var cost = shippingService.CalculateShippingCost(order);

            Console.WriteLine($"The Final cost for your order is: {cost} ");
        }
    }
}
