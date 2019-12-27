using SimUDuck.Behaviors;
using SimUDuck.FlyBehavior;
using System;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
            => (_quackBehavior, _flyBehavior) = (new Quack(), new FlyWithWings());

        public override void Display()
        {
            Console.WriteLine("I look like a Mallard Duck");
        }
    }
}
