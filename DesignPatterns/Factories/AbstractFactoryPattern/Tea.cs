using System;
using System.Collections.Generic;
using System.Text;

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
