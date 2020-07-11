using DesignPatterns.Bridge.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Bridge.Exercise
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ToString_PassARasterRenderer_UsesPassedRenderer()
        {
            var triangle = new Triangle(new RasterRenderer());
            Assert.That(triangle.ToString(),
                Is.EqualTo("Drawing Triangle as pixels"));
        }

        [Test]
        public void ToString_PassAVectorRenderer_UsesPassedRenderer()
        {
            var triangle = new Triangle(new VectorRenderer());
            Assert.That(triangle.ToString(),
                Is.EqualTo("Drawing Triangle as lines"));
        }
    }
}
