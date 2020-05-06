using System;

namespace AdapterDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck mallard = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            //Let's make our turkey look like a duck:
            IDuck adaptedDuck = new TurkeyAdapter(turkey);

            Console.WriteLine("Here goes the duck");
            mallard.Quack();
            mallard.Fly();

            Console.WriteLine("Here goes the turkey");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("Here goes the turkey in duck disguise");
            adaptedDuck.Quack();
            adaptedDuck.Fly();

            Console.ReadLine();
        }
    }
}
