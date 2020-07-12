using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritanceDefault
{
    public class Dragon : Organism, IBird, ILizard
    {
        public int Age { get; set; }
    }
}
