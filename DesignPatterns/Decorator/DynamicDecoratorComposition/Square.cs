using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class Square : Shape
    {
        private readonly float _side;

        public Square() : this(0)
        {

        }

        public Square(float side)
        {
            _side = side;
        }

        public override string AsString() => $"A square with side {_side}";
    }
}
