using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle() : this(0)
        {

        }

        public Circle(float radius)
        {
            _radius = radius;
        }

        public void Resize(float factor)
        {
            _radius *= factor;
        }

        public override string AsString() => $"A circle of radius {_radius}";
    }
}
