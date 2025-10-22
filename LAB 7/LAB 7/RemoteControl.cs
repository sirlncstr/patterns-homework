using System;

namespace HW_Patterns_Behavioral
{
    public class RemoteControl
    {
        private ICommand _onCommand;
        private ICommand _offCommand;

        public void SetCommands(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void PressOnButton()
        {
            _onCommand.Execute();
        }

        public void PressOffButton()
        {
            _offCommand.Execute();
        }

        public void PressUndoButton()
        {
            _onCommand.Undo();
        }
    }
}