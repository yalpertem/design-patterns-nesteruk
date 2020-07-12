using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public class Bird : IBird
    {
        public string Fly()
        {
            return $"Flying with weight {Weight}";
        }
        public int Weight { get; set; }
    }
}
