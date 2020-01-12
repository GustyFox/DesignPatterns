using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class LightOffCommand : ICommand
    {
        Light _light;

        public LightOffCommand(Light light)
            => _light = light;

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
