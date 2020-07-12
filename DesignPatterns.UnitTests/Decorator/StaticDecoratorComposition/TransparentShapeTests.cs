using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Decorator.StaticDecoratorComposition;

namespace DesignPatterns.UnitTests.Decorator.StaticDecoratorComposition
{
    [TestFixture]
    public class TransparentShapeTests
    {
        [Test]
        public void AsString_DecorateWithSquareAndColoredShape_GetTheirInfo()
        {
            TransparentShape<ColoredShape<Square>> blackHalfSquare = 
                new TransparentShape<ColoredShape<Square>>(0.4f);
            var result = blackHalfSquare.AsString();
            var expectedResult = "A square with side 0 has the color black has transparency 40";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
