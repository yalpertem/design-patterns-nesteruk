using DesignPatterns.Specification.Base;

namespace DesignPatterns.Specification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first;

        private ISpecification<T> _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }
}