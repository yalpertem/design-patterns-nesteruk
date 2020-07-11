using System;

namespace DesignPatterns.Factories.AbstractFactoryPattern
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is nice.");
        }
    }
}