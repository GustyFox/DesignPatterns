using System;
using System.Collections.Generic;
using System.Text;

namespace Choco_O_Holic
{
    public class ChocolateBoiler
    {
        private static bool empty;
        private static bool boiled;

        private static readonly Object _lock = new object();
        public static ChocolateBoiler _instance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new ChocolateBoiler();
                    }
                }
            }

            return _instance;
        }

        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Fill the boiler with a milk/chocolate mixture");
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
            {
                Console.WriteLine("Drain the boiled chocolate milk");
                empty = true;
            }
        }

        public void Boil()
        {
            if (!empty && !boiled)
            {
                Console.WriteLine("Boiling the milk/chocolate mixture");
                boiled = true;
            }
        }
    }
}
