using System.Collections.Generic;

namespace DesignPatterns.Composite.CompositeSpecification.Base
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}