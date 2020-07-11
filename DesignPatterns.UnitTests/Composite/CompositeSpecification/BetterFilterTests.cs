using DesignPatterns.Composite.CompositeSpecification;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Composite.CompositeSpecification
{
    [TestFixture]
    public class BetterFilterTests
    {
        [Test]
        public void Filter_ByColorsWithOr_ReturnsCorrectCount()
        {
            var products = new List<Product>()
            {
                new Product("P1", ProductColor.Black, ProductSize.L),
                new Product("P2", ProductColor.Blue, ProductSize.M),
                new Product("P3", ProductColor.Green, ProductSize.M),
                new Product("P4", ProductColor.Blue, ProductSize.S),
                new Product("P5", ProductColor.Black, ProductSize.XL),
            };
            var betterFilter = new BetterFilter();
            var filteredProducts = betterFilter.Filter(products,
                new OrSpecification<Product>(
                    new ColorSpecification(ProductColor.Black),
                    new ColorSpecification(ProductColor.Blue)));

            Assert.That(filteredProducts.Count, Is.EqualTo(4));
        }
    }
}
