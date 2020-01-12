using System;

namespace HomeAutomationRemoteControl.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command was assigned to this button");
        }

        public void Undo()
        {
            Console.WriteLine("No Command was assigned to this button");
        }
    }
}
