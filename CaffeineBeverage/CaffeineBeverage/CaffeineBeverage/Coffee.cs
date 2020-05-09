using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeineBeverage
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk.");
        }
    }
}
