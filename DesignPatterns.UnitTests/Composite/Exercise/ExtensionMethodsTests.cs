using DesignPatterns.Composite.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Composite.Exercise
{
   [TestFixture]
    public class ExtensionMethodsTests
    {
        [Test]
        public void Sum_AddMultipleValues_ReturnsSum()
        {
            var singleValue = new SingleValue() { Value = 4 };
            var manyValues = new ManyValues { 1, 2 };
            var container = new List<IValueContainer>() { singleValue, manyValues };
            var sum = container.Sum();
            Assert.That(sum, Is.EqualTo(7));
        }
    }
}
