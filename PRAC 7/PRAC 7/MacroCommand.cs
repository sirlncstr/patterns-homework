using System;
using System.Collections.Generic;

namespace HW_Patterns_Advanced
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            Console.WriteLine("--- Выполнение макрокоманды ---");
            foreach (var command in _commands)
            {
                command.Execute();
            }
            Console.WriteLine("-----------------------------");
        }

        public void Undo()
        {
            Console.WriteLine("--- Отмена макрокоманды ---");
            for (int i = _commands.Count - 1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
            Console.WriteLine("--------------------------");
        }
    }
}