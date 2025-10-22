using System;

namespace HW7_BehavioralPatterns
{
    public class HotChocolate : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("2. Mixing chocolate powder with hot water");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("4. Adding marshmallows");
        }
    }
}