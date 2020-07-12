using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public interface ILizard
    {
        string Crawl();
        int Weight { get; set; }
    }
}
