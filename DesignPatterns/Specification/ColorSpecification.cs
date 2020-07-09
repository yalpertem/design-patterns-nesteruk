using DesignPatterns.Specification.Base;
using System;
using System.Collections.Generic;
using System.Text;

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
