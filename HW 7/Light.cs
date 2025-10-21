using System;

namespace HW7_BehavioralPatterns
{
    public class Light
    {
        public string Location { get; set; }
        public Light(string location) { Location = location; }
        public void TurnOn() { Console.WriteLine($"{Location} light is ON"); }
        public void TurnOff() { Console.WriteLine($"{Location} light is OFF"); }
    }
}