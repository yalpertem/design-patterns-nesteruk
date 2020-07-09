using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.ExplicitDeepCopyInterface
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
