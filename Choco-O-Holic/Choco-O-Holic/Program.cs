using System;

namespace Choco_O_Holic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Choco-o-Holic!");

            var boiler = ChocolateBoiler.getInstance();

            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            Console.ReadLine();
        }
    }
}
