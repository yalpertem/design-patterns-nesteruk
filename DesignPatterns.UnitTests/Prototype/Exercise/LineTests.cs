using DesignPatterns.Prototype.Exercise;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Prototype.Exercise
{
    [TestFixture]
    public class LineTests
    {
        [Test]
        public void DeepCopy_CopyPoint_DoesNotChangeStartX()
        {
            var line = new Line()
            {
                Start = new Point(1, 2),
                End = new Point(3, 4)
            };
            var copy = line.DeepCopy();
            copy.Start.X = 5;
            Assert.That(line.Start.X, Is.EqualTo(1));
        }

        [Test]
        public void DeepCopy_CopyPoint_DoesNotChangeEndY()
        {
            var line = new Line()
            {
                Start = new Point(1, 2),
                End = new Point(3, 4)
            };
            var copy = line.DeepCopy();
            copy.End.Y = 5;
            Assert.That(line.End.Y, Is.EqualTo(4));
        }
    }
}