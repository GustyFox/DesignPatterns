using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Coffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
