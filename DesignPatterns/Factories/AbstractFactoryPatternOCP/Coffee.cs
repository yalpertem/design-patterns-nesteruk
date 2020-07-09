using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is nice.");
        }
    }
}
