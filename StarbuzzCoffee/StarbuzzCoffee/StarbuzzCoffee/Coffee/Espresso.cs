using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Coffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
