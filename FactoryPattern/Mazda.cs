using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Mazda : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Mazda is up and running");
        }

        public void TurnOn()
        {
            Console.WriteLine("Mazda has stopped");
        }
    }
}
