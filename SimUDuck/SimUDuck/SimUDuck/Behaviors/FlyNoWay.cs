using System;

namespace SimUDuck.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No, no. I can't fly!");
        }
    }
}
