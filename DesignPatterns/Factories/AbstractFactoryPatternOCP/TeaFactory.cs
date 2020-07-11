using System;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"{amount} of tea is prepared");
            return new Tea();
        }
    }
}