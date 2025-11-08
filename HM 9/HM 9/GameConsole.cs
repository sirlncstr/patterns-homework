using System;

namespace DesignPatterns
{
    public class GameConsole
    {
        public void Vkluchit() => Console.WriteLine("Игровая консоль включена");
        public void Vykluchit() => Console.WriteLine("Игровая консоль выключена");
        public void ZapustitIgru(string igra) => Console.WriteLine($"Запуск игры: {igra}");
    }
}