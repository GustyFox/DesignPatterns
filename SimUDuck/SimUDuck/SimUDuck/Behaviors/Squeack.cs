using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Squeeak!");
        }
    }
}
