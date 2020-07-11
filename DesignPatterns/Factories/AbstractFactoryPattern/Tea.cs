using System;

namespace DesignPatterns.Factories.AbstractFactoryPattern
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Tea is nice.");
        }
    }
}