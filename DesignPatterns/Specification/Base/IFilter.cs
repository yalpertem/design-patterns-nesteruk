using System.Collections.Generic;

namespace DesignPatterns.Specification.Base
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}