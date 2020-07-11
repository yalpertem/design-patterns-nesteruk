using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Exercise
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }
}
