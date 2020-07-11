using DesignPatterns.Composite.GeometricShapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Composite.GeometricShapes
{
    [TestFixture]
    public class GraphicObjectTests
    {
        [Test]
        public void ToString_CreateCompositeObjects_ValidateDepth()
        {
            var objects = new GraphicObject();
            objects.Children.Add(new Circle() { Color = "Blue" });
            objects.Children.Add(new Square() { Color = "Red" });

            var group = new GraphicObject();
            group.Children.Add(new Circle() { Color = "Black" });
            group.Children.Add(new Square() { Color = "Black" });

            objects.AddChild(group);
            var result = objects.ToString();

            var expectedOutput = @"Group
*Blue Circle
*Red Square
*Group
**Black Circle
**Black Square
";

            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
