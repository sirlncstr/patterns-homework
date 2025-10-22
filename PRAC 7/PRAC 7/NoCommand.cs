using System;

namespace HW_Patterns_Advanced
{
    public class NoCommand : ICommand
    {
        public void Execute() => Console.WriteLine("[Пусто] Команда не назначена.");
        public void Undo() { /* Ничего не делаем */ }
    }
}