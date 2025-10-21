using System;

namespace HW7_BehavioralPatterns
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("2. Steeping the tea bag");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("4. Adding lemon");
        }
    }
}