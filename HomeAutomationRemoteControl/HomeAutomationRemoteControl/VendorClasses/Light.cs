using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.VendorClasses
{
    public class Light
    {
        string Location;

        public Light(string location)
        {
            Location = location;
        }

        public void On()
        {
            Console.WriteLine("Lights on.");
        }

        public void Off()
        {
            Console.WriteLine("Lights off.");
        }
    }
}
