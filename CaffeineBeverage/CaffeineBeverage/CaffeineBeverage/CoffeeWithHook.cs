using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeineBeverage
{
    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk.");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee? y/n");
            string answer = Console.ReadLine();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
