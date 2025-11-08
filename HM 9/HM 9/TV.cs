using System;

namespace DesignPatterns
{
    public class TV
    {
        public void Vkluchit() => Console.WriteLine("Телевизор включен");
        public void Vykluchit() => Console.WriteLine("Телевизор выключен");
        public void VybratKanal(int kanal) => Console.WriteLine($"Телевизор переключен на канал {kanal}");
        public void UstanovitVhod(string vhod) => Console.WriteLine($"Телевизор переключен на вход {vhod}");
    }
}