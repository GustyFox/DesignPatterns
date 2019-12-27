using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();
        public void Prepare()
        {
            Console.WriteLine("Peparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding " + sauce + " sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var topping in toppings)
            {
                Console.WriteLine("Adding " + topping);
            }

        }

        public void Bake()
        {
            Console.WriteLine("Bake for 20 mins at 350oC");
        }
        public void Box()
        {
            Console.WriteLine("Box pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut pizza");
        }

        public string GetName()
        {
            return name;
        }
    }
}
