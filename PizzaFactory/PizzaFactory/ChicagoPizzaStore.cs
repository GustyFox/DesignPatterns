using PizzaFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new ChicagoCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoPepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoClamPizza();
                    break;
            }

            return pizza;
        }
    }
}
