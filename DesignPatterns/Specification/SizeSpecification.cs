using DesignPatterns.Specification.Base;

namespace DesignPatterns.Specification
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