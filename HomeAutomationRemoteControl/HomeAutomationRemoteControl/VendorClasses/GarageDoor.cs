using System;

namespace HomeAutomationRemoteControl.VendorClasses
{
    public class GarageDoor
    {
        string Location;

        public GarageDoor(string location)
        {
            Location = location;
        }
        public void Up()
        {
            //TODO:Opens the Garage door, on completion says it is open
            Console.WriteLine("Garage door is Open.");
        }
        public void Down()
        {

        }
        public void Stop()
        {

        }
        public void LightOn()
        {

        }
        public void LightOff()
        {

        }
    }
}
