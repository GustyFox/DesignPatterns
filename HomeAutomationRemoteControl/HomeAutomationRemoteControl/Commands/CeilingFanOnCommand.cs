using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        CeilingFan _ceilingFan;
        int prevSpeed;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
            => _ceilingFan = ceilingFan;

        public void Execute()
        {
            _ceilingFan.GetSpeed();
            _ceilingFan.On();
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
                    _ceilingFan.Off();
                    break;
            }

            _ceilingFan.DisplaySpeed();
        }
    }
}
