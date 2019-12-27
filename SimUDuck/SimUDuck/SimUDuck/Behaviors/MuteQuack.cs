using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine(" ");
        }
    }
}
