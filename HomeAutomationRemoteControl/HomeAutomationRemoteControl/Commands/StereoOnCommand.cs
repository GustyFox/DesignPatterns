using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class StereoOnCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
            => _stereo = stereo;

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
