using System;

namespace HW7_BehavioralPatterns
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("2. Dripping coffee through filter");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("4. Adding sugar and milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.Write("Would you like milk and sugar? (y/n): ");
            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
                Console.Write("Please enter 'y' or 'n': ");
            }
        }
    }
}