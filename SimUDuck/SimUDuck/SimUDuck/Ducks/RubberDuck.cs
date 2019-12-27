using SimUDuck.Behaviors;
using SimUDuck.FlyBehavior;
using System;

namespace SimUDuck.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
         => (_quackBehavior, _flyBehavior) = (new MuteQuack(), new FlyWithWings());

        public override void Display()
        {
            Console.WriteLine("I'm made of bright yellow rubber");
        }
    }
}
