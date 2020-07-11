using DesignPatterns.Composite.CompositeSpecification.Base;

namespace DesignPatterns.Composite.CompositeSpecification
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