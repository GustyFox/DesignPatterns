using SimUDuck.Behaviors;
using SimUDuck.FlyBehavior;
using System;

namespace SimUDuck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
            => (_quackBehavior, _flyBehavior) = (new Quack(), new FlyWithWings());

        public override void Display()
        {
            Console.WriteLine("I have a bright red head!");
        }
    }
}
