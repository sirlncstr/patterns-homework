using System;

namespace HW7_BehavioralPatterns
{
    public abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        private void BoilWater()
        {
            Console.WriteLine("1. Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("3. Pouring into cup");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}