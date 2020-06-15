using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Dacia : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Dacia is on and running");
        }
         

        public void TurnOn()
        {
            Console.WriteLine("Dacia has stopped");
        }
    }
}
