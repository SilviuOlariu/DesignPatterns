namespace StrategyPattern
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch(order.ShippingOptions)
            {
                case ShippingOptions.Cargus:
                        return CalculateCargusCost(order);  
                    
                case ShippingOptions.FunCurier:
                    return CalculateDHLCost(order);

                case ShippingOptions.DHL:
                    return CalculateDHLCost(order);
                default:
                    throw new UnknownOrderShippingExpection();
                     
            }
        }


        public double CalculateCargusCost(Order order)
        {
            //return sample value;
            return 10;
        }
        public double CalculateFunCurierCost(Order order)
        {
            //return sample value;
            return 20;
        }
        public double CalculateDHLCost(Order order)
        {
            //return sample value;
            return 30;
        }
    }
}
