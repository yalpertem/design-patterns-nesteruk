using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.StaticDecoratorComposition
{
    /// <summary>
    /// CRTP cannot be done
    /// public class ColoredShape2<T> : T where T : Shape { }
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ColoredShape<T> : Shape where T : Shape, new()
    {
        private readonly string _color;
        private readonly T _shape = new T();

        public ColoredShape() : this("black")
        {

        }

        public ColoredShape(string color) // no constructor forwarding
        {
            _color = color;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has the color {_color}";
        }
    }



}
