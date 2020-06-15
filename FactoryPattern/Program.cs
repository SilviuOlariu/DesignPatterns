using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ReadInput();

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(input);

            car.TurnOn();
            car.TurnOff();

        }

        

        private static string ReadInput()
        {
            Console.Write("what car do you want to use: ");
            var input = Console.ReadLine();
            return input;
        }


    }
}
