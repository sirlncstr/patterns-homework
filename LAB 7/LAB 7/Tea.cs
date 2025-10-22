using System;

namespace HW_Patterns_Behavioral
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Заваривание чая...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавление лимона...");
        }
    }
}