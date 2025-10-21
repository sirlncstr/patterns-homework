using System;

namespace HW7_BehavioralPatterns
{
    public class Thermostat
    {
        private int _temp = 20;
        public void IncreaseTemp() { _temp++; Console.WriteLine($"Temperature is now {_temp}C"); }
        public void DecreaseTemp() { _temp--; Console.WriteLine($"Temperature is now {_temp}C"); }
    }
}