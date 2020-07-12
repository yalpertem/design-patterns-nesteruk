using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DynamicDecoratorComposition
{
    public abstract class Shape
    {
        public virtual string AsString() => string.Empty;
    }
}
