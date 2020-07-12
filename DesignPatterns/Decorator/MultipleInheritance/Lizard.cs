using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public class Lizard : ILizard
    {
        public string Crawl()
        {
            return $"Crawling with weight {Weight}";
        }
        public int Weight { get; set; }
    }
}
