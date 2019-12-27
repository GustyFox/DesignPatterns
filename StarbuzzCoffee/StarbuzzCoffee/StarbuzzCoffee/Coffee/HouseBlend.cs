using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
           return 0.89;
        }
    }
}
