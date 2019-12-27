using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public override abstract string getDescription();

        public Size getSize()
        {
            return beverage.GetSize();
        }
    }
}
