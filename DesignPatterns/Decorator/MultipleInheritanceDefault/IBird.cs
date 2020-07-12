using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritanceDefault
{
    public interface IBird : ICreature
    {
        string Fly()
        {
            if (Age >= 10)
            {
                return "I am flying";
            }
            return null;
        }
    }
}
