using System;

namespace HW_Patterns_Behavioral
{
    public class Light
    {
        public string Location { get; set; }

        public Light(string location)
        {
            this.Location = location;
        }

        public Light()
        {
        }

        public void On()
        {
            Console.WriteLine($"Свет в '{Location}' включен.");
        }

        public void Off()
        {
            Console.WriteLine($"Свет в '{Location}' выключен.");
        }
    }
}