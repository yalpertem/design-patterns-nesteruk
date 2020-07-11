using System;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Tea is nice.");
        }
    }
}