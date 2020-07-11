using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.CompositeSpecification.Base
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        protected readonly ISpecification<T>[] _items;
        public CompositeSpecification(params ISpecification<T>[] items)
        {
            _items = items;
        }
        public abstract bool IsSatisfied(T t);
    }
}
