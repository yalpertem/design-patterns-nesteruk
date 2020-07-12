using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public interface IBird
    {
        string Fly();
        int Weight { get; set; }
    }
}
