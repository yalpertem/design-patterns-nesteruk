using DesignPatterns.SpecificationPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.SpecificationPattern
{
    [TestFixture]
    public class BetterFilterTests
    {
        [Test]
        public void Filter_GetBlackProducts_SomeExists()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product("Polo Shirt", ProductColor.Black, ProductSize.L),
                new Product("T-Shirt", ProductColor.Blue, ProductSize.M),
                new Product("T-Shirt", ProductColor.Red, ProductSize.S),
                new Product("Jeans", ProductColor.Blue, ProductSize.XL),
                new Product("Jeans", ProductColor.Black, ProductSize.XL),
            };
            var betterFilter = new BetterFilter();
            var filteredProducts = betterFilter.Filter(products, new ColorSpecification(ProductColor.Black)).ToList();
            Assert.That(filteredProducts.Count, Is.EqualTo(2));
            return;
        }

        [Test]
        public void Filter_GetMediumProducts_ReturnEmptyList()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product("Polo Shirt", ProductColor.Black, ProductSize.L),
                new Product("T-Shirt", ProductColor.Blue, ProductSize.XS),
                new Product("T-Shirt", ProductColor.Red, ProductSize.S),
                new Product("Jeans", ProductColor.Blue, ProductSize.XL),
                new Product("Jeans", ProductColor.Black, ProductSize.XL),
            };
            var betterFilter = new BetterFilter();
            var filteredProducts = betterFilter.Filter(products, new SizeSpecification(ProductSize.M)).ToList();
            Assert.That(filteredProducts.Count, Is.EqualTo(0));
            return;
        }

        [Test]
        public void Filter_GetLargeBlackProducts_ReturnListWithSingleElement()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product("Polo Shirt", ProductColor.Black, ProductSize.L),
                new Product("T-Shirt", ProductColor.Blue, ProductSize.XS),
                new Product("T-Shirt", ProductColor.Red, ProductSize.S),
                new Product("Jeans", ProductColor.Blue, ProductSize.XL),
                new Product("Jeans", ProductColor.Black, ProductSize.XL),
            };
            var betterFilter = new BetterFilter();
            var andSpecification = new AndSpecification<Product>(
                new ColorSpecification(ProductColor.Black),
                new SizeSpecification(ProductSize.L));

            var filteredProducts = betterFilter.Filter(products, andSpecification).ToList();
            Assert.That(filteredProducts.Count, Is.EqualTo(1));
            return;
        }
    }
}
