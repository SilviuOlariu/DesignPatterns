using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FactoryPattern
{
   public static class VehicleFactory
    {
        public static IAuto Build(string carName)
        {
            switch(carName)
            {
                case "bmw":
                    return new BMW();
                case "dacia":
                    return new Dacia();
                case "mazda":
                    return new Mazda();
                default:
                    return new NullCar();
            }  
        }

    }
}
