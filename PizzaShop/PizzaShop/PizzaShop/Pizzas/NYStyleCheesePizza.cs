using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "Ny Style Cheese Pizza";
            dough = "This crust dough";
            sauce = "Marinara sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
