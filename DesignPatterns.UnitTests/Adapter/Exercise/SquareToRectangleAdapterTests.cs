using DesignPatterns.Adapter.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Adapter.Exercise
{
    [TestFixture]
    public class SquareToRectangleAdapterTests
    {
        [Test]
        public void Width_CreateAdapterObjects_SetsWidth()
        {
            var square = new Square() { Side = 5 };
            var adapter = new SquareToRectangleAdapter(square);
            Assert.That(adapter.Width, Is.EqualTo(5));
        }

        [Test]
        public void Height_CreateAdapterObjects_SetsHeight()
        {
            var square = new Square() { Side = 5 };
            var adapter = new SquareToRectangleAdapter(square);
            Assert.That(adapter.Height, Is.EqualTo(5));
        }
    }
}
