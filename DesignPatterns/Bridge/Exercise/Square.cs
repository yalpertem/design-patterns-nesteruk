using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Exercise
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }
}
