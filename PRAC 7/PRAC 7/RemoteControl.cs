using System;
using System.Collections.Generic;

namespace HW_Patterns_Advanced
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private Stack<ICommand> _undoHistory;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            _undoHistory = new Stack<ICommand>();

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOnButton(int slot)
        {
            _onCommands[slot].Execute();
            _undoHistory.Push(_onCommands[slot]);
        }

        public void PressOffButton(int slot)
        {
            _offCommands[slot].Execute();
            _undoHistory.Push(_offCommands[slot]);
        }

        public void PressUndoButton()
        {
            if (_undoHistory.Count > 0)
            {
                ICommand lastCommand = _undoHistory.Pop();
                Console.Write("[ОТМЕНА] ");
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("[ОТМЕНА] Нечего отменять.");
            }
        }
    }
}