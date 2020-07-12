using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{

    // dynamic
    public class ColoredShape : Shape
    {
        private readonly Shape _shape;
        private readonly string _color;

        public ColoredShape(Shape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public override string AsString() => $"{_shape.AsString()} has the color {_color}";
    }


}
