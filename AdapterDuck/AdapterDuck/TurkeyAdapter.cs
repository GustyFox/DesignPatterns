using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDuck
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            //Turkeys fly for short distances, to make up to it we are flying 5 times
            for (int i = 0; i < 5; i++)
            {
                _turkey.Gobble();
            }
        }
    }
}
