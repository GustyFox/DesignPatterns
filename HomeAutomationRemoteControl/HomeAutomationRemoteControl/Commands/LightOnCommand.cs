using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl
{
    public class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On(); ;
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
