using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Condiments
{
    public class Whip : Beverage
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            double cost = _beverage.Cost();

            if (_beverage.GetSize() == Size.tall)
            {
                cost += 0.10;
            }
            else if (_beverage.GetSize() == Size.grande)
            {
                cost += 0.15;
            }
            else if (_beverage.GetSize() == Size.venti)
            {
                cost += 0.20;
            }

            return cost;
        }

        public override string getDescription()
        {
            return _beverage.getDescription() + ", whip";
        }
    }
}
