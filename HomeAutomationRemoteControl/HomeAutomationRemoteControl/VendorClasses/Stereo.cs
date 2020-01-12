using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.VendorClasses
{
    public class Stereo
    {
        string Location;
        int _volume = 5;

        public Stereo(string location)
        {
            Location = location;
        }

        public void On()
        {
            Console.WriteLine("Music is now playing.");
        }

        public void Off()
        {
            Console.WriteLine("Stereo Off.");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine("Stereo volume set to " + _volume + ".");
        }
    }
}
