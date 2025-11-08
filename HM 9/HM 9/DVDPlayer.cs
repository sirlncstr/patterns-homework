using System;

namespace DesignPatterns
{
    public class DVDPlayer
    {
        public void Vkluchit() => Console.WriteLine("DVD-проигрыватель включен");
        public void Vykluchit() => Console.WriteLine("DVD-проигрыватель выключен");
        public void Vosproizvesti(string film) => Console.WriteLine($"Воспроизведение фильма: {film}");
        public void Pauza() => Console.WriteLine("DVD на паузе");
        public void Ostanovit() => Console.WriteLine("DVD остановлен");
    }
}