using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeineBeverage
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }
    }
}
