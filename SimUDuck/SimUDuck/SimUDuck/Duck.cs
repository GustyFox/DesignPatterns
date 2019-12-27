using SimUDuck.Interfaces;
using System;

namespace SimUDuck
{
    public abstract class Duck
    {
        public IQuackBehavior _quackBehavior;
        public IFlyBehavior _flyBehavior;

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void PerformQuack()
        {
            _quackBehavior.QuackSound();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float");
        }

        public abstract void Display();
    }
}
