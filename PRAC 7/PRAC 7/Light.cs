using System;

namespace HW_Patterns_Advanced
{
    public class Light
    {
        public string Location { get; private set; }
        public Light(string location) { Location = location; }
        public void On() => Console.WriteLine($"Свет в '{Location}' включен.");
        public void Off() => Console.WriteLine($"Свет в '{Location}' выключен.");
    }
}