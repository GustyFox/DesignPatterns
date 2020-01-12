﻿using HomeAutomationRemoteControl.Commands;
using System;
using System.Text;

namespace HomeAutomationRemoteControl
{
    public class RemoteControlWithUndo
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;
        ICommand _undoCommand;

        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            {
                for (int i = 0; i < 7; i++)
                {
                    _onCommands[i] = noCommand;
                    _offCommands[i] = noCommand;

                }
                _undoCommand = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            _undoCommand.Undo();
        }

        public String toString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n----------Remote Control----------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + _onCommands[i].GetType().Name +
                    " " + _offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
