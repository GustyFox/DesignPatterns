using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public enum Size { tall, grande, venti};
        Size _size = Size.tall;

        public virtual string getDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            _size = size;
        }

        public Size GetSize()
        {
            return _size;
        }

        public abstract double Cost();
    }
}
