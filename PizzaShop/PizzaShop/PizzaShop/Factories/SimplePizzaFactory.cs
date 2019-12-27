using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if(type == "Cheese")
            {
                pizza = new CheesePizza();
            }

            return pizza;
        } 
    }
}
