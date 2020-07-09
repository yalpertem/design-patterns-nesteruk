using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factories.AbstractFactoryPattern
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
