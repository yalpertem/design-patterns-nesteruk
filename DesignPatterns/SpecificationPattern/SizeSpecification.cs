using DesignPatterns.SpecificationPattern.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SpecificationPattern
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
