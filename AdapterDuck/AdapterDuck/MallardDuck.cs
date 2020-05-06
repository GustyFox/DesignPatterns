using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDuck
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quacks");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }

}
