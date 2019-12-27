using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I flap my wings to fly");
        }
    }
}
