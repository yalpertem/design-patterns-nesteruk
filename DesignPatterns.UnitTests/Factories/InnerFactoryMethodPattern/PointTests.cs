using DesignPatterns.Factories.InnerFactoryMethodPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Factories.InnerFactoryMethodPattern
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Factory_CallNewCartesianPoint_SetsX()
        {
            var point = Point.Factory.NewCartesianPoint(1, 2);
            Assert.That(point.X, Is.EqualTo(1));
        }

        [Test]
        public void Factory_CallNewCartesianPoint_SetsY()
        {
            var point = Point.Factory.NewCartesianPoint(1, 2);
            Assert.That(point.Y, Is.EqualTo(2));
        }
    }
}