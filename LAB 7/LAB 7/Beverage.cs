using System;

namespace HW_Patterns_Behavioral
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Кипячение воды...");
        }

        private void PourInCup()
        {
            Console.WriteLine("Наливание в чашку...");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}