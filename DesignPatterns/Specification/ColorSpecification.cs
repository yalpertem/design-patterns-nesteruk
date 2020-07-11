using DesignPatterns.Specification.Base;

namespace DesignPatterns.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly ProductColor _color;

        public ColorSpecification(ProductColor color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}