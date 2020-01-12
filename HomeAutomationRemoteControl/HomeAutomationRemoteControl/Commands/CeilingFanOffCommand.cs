using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        CeilingFan _ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
            => _ceilingFan = ceilingFan;

        public void Execute()
        {
            prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case 0:
                    _ceilingFan.SetOff();
                    break;
                case 1:
                    _ceilingFan.SetLowSpeed();
                    break;
                case 2:
                    _ceilingFan.SetMediumSpeed();
                    break;
                case 3:
                    _ceilingFan.SetHighSpeed();
                    break;
                default:
                    _ceilingFan.On();
                    break;
            }

            _ceilingFan.DisplaySpeed();
        }
    }
}
