using DesignPatterns.Composite.CompositeSpecification.Base;

namespace DesignPatterns.Composite.CompositeSpecification
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly ProductSize _size;

        public SizeSpecification(ProductSize size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }
}