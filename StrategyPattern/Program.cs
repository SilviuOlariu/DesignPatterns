using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { OrderId = 1, Item = "Phone", ShippingOptions = ShippingOptions.FunCurier };
            var shippingService = new ShippingCostCalculatorService();
         var cost =   shippingService.CalculateShippingCost(order);
            Console.WriteLine($"The Final cost for your order is: {cost} ");
        }
    }
}
