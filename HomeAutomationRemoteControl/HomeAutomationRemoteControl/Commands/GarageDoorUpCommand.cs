using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
