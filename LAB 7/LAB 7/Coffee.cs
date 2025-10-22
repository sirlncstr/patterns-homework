using System;

namespace HW_Patterns_Behavioral
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Заваривание кофе...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавление сахара и молока...");
        }
    }
}