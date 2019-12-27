using SimUDuck.Behaviors;
using SimUDuck.Ducks;
using SimUDuck.FlyBehavior;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Duck duck = new MallardDuck();

            duck.PerformQuack();
            duck.PerformFly();
            duck.Display();

            Console.WriteLine("Let's see a Rubber Duck now:");
            Console.ReadLine();

            Duck rubber = new RubberDuck();

            rubber.PerformQuack();
            rubber.setQuackBehavior(new Squeak());
            rubber.PerformQuack();
            rubber.PerformFly();
            rubber.setFlyBehavior(new FlyNoWay());
            rubber.PerformFly();
            rubber.Display();

        }
    }
}
