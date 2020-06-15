using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
   public class BMW:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMW is on and running");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW has stopped");
        }
    }
}
