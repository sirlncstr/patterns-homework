using System;
using System.Collections.Generic;

namespace HW7_BehavioralPatterns
{
    public class RemoteControl
    {
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void Submit(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                Console.Write("[UNDO] ");
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("[UNDO] Nothing to undo.");
            }
        }
    }
}