using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
