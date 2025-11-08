using System;

namespace DesignPatterns
{
    public class AudioSystem
    {
        public void Vkluchit() => Console.WriteLine("Аудиосистема включена");
        public void Vykluchit() => Console.WriteLine("Аудиосистема выключена");
        public void UstanovitGromkost(int uroven) => Console.WriteLine($"Громкость установлена на {uroven}");
    }
}