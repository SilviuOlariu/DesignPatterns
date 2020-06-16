using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
  public abstract  class Pizza
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double CalculateCost();
        

    }
}
