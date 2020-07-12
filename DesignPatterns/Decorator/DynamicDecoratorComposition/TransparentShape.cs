using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public class TransparentShape : Shape
    {
        private readonly Shape _shape;
        private readonly float _transparency;

        public TransparentShape(Shape shape, float transparency)
        {
            _shape = shape;
            _transparency = transparency;
        }

        public override string AsString() => $"{_shape.AsString()} has {_transparency * 100.0f} transparency";
    }
}
