using StarbuzzCoffee.Coffee;
using StarbuzzCoffee.Condiments;
using System;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello StarBuzz Coffee!");

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.Cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            Console.WriteLine(bev2.getDescription() + " $" + bev2.Cost());

            Beverage bev3 = new HouseBlend();
            bev3.SetSize(Beverage.Size.venti);
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            Console.WriteLine(bev3.getDescription() + " $" + bev3.Cost());
        }
    }
}
