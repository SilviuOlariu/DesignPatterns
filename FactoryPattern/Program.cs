using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what car you want to use: ");
            var input = Console.ReadLine();
            var car = GetCar(input);
            car.TurnOn();
            car.TurnOff();
            
        }


        public static IAuto GetCar(string carName)
        {
            switch(carName)
            {
                case "bmw":
                    return new BMW();
                case "audi":
                    return new Dacia();
                case "mazda":
                    return new Mazda();
                default:
                    return new NullCar();
                    
            }
        }
    }
}
