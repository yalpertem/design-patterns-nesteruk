using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Decorator.DynamicDecoratorComposition;

namespace DesignPatterns.UnitTests.Decorator.DynamicDecoratorComposition
{
    [TestFixture]
    public class TransparentShapeTests
    {
        [Test]
        public void AsString_DecorateWithSquareAndColoredShape_GetTheirInfo()
        {
            var square = new Square(1.23f);
            var redSquare = new ColoredShape(square, "red");
            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            var result = redHalfTransparentSquare.AsString();
            var expectedResult = "A square with side 1.23 has the color red has 50 transparency";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
