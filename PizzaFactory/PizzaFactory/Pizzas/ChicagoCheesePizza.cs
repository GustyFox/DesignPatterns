using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Pizzas
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Cheese Pizza";
            Dough = "Think Dough 1";
            Sauce = "Salad 1";
            Toppings.Add("Grated Reggiano Cheese 1");
        }
    }
}
