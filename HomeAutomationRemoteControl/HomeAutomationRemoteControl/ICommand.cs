using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl
{
    /// <summary>
    /// This Executes a command.
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
