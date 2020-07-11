using DesignPatterns.Composite.CompositeSpecification.Base;
using System.Linq;

namespace DesignPatterns.Composite.CompositeSpecification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params ISpecification<T>[] items) : base(items)
        {
        }

        public override bool IsSatisfied(T t)
        {
            return _items.All(x => x.IsSatisfied(t));
        }
    }
}