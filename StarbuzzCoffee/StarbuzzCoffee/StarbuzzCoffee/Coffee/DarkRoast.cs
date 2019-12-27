using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Coffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
