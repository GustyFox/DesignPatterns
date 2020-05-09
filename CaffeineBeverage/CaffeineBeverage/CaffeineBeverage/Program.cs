using System;

namespace CaffeineBeverage
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("Making Tea:");
            teaHook.PrepareRecipe();

            Console.WriteLine("Making Coffee:");
            coffeeHook.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
