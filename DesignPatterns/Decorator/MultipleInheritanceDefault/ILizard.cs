using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritanceDefault
{
    public interface ILizard : ICreature
    {
        string Crawl()
        {
            if (Age < 10)
            {
                return "I am crawling.";
            }
            return null;
        }
    }
}
