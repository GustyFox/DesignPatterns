using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Pizzas
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public ChicagoPepperoniPizza()
        {
            Name = "Chicago Pepperoni Pizza";
            Dough = "Thin dough 1";
            Sauce = "Black pepper 1";
            Toppings.Add("Beef Granules 1");
            Toppings.Add("Niblet 1");
        }
    }
}
