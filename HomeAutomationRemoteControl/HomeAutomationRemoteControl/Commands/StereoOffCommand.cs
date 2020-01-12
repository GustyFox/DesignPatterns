using HomeAutomationRemoteControl.VendorClasses;

namespace HomeAutomationRemoteControl.Commands
{
    public class StereoOffCommand : ICommand
    {
        Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
            => _stereo = stereo;

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
