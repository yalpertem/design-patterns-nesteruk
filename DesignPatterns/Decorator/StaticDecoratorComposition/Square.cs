using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.StaticDecoratorComposition
{
    public class Square : Shape
    {
        private float _side;

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
