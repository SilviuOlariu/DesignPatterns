namespace StrategyPattern
{
    public class ShippingCostCalculatorService
    {
        public ICalculatorShipping _calculator;
        public ShippingCostCalculatorService(ICalculatorShipping calculator)
        {

            _calculator = calculator;
        }

        public double CalculateShippingCost(Order order)
        {
            return _calculator.CalculateShipping(order);
        }

    }
}
