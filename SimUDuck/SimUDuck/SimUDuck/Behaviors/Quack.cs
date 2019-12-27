using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
