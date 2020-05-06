using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDuck
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Gobble()
        {
            Console.WriteLine("I'm flying...a little bit");
        }
    }
}
