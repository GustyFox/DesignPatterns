using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeineBeverage
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon.");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? y/n");
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
