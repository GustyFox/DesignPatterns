using System;

namespace HomeAutomationRemoteControl.VendorClasses
{
    public class CeilingFan
    {
        string Location;
        public enum speeds
        {
            High = 3,
            Medium = 2,
            Low = 1,
            Off = 0
        }
        public int _speed;

        public CeilingFan(string location)
        {
            Location = location;
            _speed = (int)speeds.Off;
        }

        #region fan-speeds

        public void SetHighSpeed()
        {
            _speed = (int)speeds.High;
        }

        public void SetMediumSpeed()
        {
            _speed = (int)speeds.Medium;
        }

        public void SetLowSpeed()
        {
            _speed = (int)speeds.Low;
        }

        public void SetOff()
        {
            _speed = (int)speeds.Off;
        }
        #endregion

        public void On()
        {
            switch (_speed)
            {
                case (int)speeds.Off:
                    SetLowSpeed();                    
                    break;
                case (int)speeds.Low:
                    SetMediumSpeed();
                    break;
                case (int)speeds.Medium:
                    SetHighSpeed();
                    break;
                case (int)speeds.High:
                    SetLowSpeed();
                    break;
                default:
                   SetLowSpeed();
                    break;
            }

            DisplaySpeed();
        }

        public void DisplaySpeed()
        {
            Console.WriteLine("Ceiling Fan speed set to " + Enum.GetName(typeof(speeds), _speed) + ".");
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void Off()
        {
            Console.WriteLine("Turn off the Ceiling Fan.");
            _speed = (int)speeds.Off;
        }
    }
}
