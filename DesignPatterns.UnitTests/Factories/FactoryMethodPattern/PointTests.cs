using DesignPatterns.Factories.FactoryMethodPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Factories.FactoryMethodPattern
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void NewCartesianPoint_CallWithValues_SetsX()
        {
            var point = Point.NewCartesianPoint(1, 2);
            Assert.That(point.X, Is.EqualTo(1));
        }

        [Test]
        public void NewCartesianPoint_CallWithValues_SetsY()
        {
            var point = Point.NewCartesianPoint(1, 2);
            Assert.That(point.Y, Is.EqualTo(2));
        }
    }
}