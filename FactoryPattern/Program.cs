using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ReadInput();

            var factory = VehicleFactory.Build(input);

            IAuto car = factory;

            car.TurnOn();
            car.TurnOff();

        }

        

        private static string ReadInput()
        {
            Console.Write("what car do you want to use: ");
            var input = Console.ReadLine().ToLower();
            return input;
        }


    }
}
