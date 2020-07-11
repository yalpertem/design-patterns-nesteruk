using System;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"{amount} of coffee is prepared");
            return new Coffee();
        }
    }
}