using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra thick crust dough";
            sauce = "Plum Tomato sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut pizza into square slices");
        }
    }
}
