using DesignPatterns.Composite.CompositeSpecification.Base;
using System.Linq;

namespace DesignPatterns.Composite.CompositeSpecification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        public OrSpecification(params ISpecification<T>[] items) : base(items)
        {
        }

        public override bool IsSatisfied(T t)
        {
            return _items.Any(x => x.IsSatisfied(t));
        }
    }
}