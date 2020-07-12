using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.StaticDecoratorComposition
{
    public class TransparentShape<T> : Shape where T : Shape, new()
    {
        private readonly float _transparency;
        private readonly T _shape = new T();

        public TransparentShape(float transparency)
        {
            _transparency = transparency;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has transparency {_transparency * 100.0f}";
        }
    }
}
