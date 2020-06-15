using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NullCar : IAuto
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
