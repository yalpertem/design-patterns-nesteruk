using DesignPatterns.Singleton.AmbientContext;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Singleton.AmbientContext
{
    [TestFixture]
    public class BuildingContextTests
    {
        [Test]
        public void BuildingContext_UsedInAUsingStatement_SetsTheHeightOfTheWall()
        {
            var house = new Building();
            using (new BuildingContext(200))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 1000)));
            }
            Assert.That(house.Walls[0].Height, Is.EqualTo(200));
        }

        [Test]
        public void BuildingContext_UsedInANestedUsingStatement_SetsTheHeightOfTheWall()
        {
            var house = new Building();
            using (new BuildingContext(200))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 1000)));
                using (new BuildingContext(500))
                {
                    house.Walls.Add(new Wall(new Point(1000, 0), new Point(1000, 1000)));
                }
            }
            Assert.That(house.Walls[1].Height, Is.EqualTo(500));
        }

        [Test]
        public void BuildingContext_UsedAfterANestedUsingStatement_SetsTheHeightOfTheWall()
        {
            var house = new Building();
            using (new BuildingContext(200))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 1000)));
                using (new BuildingContext(500))
                {
                    house.Walls.Add(new Wall(new Point(1000, 0), new Point(1000, 1000)));
                }
                house.Walls.Add(new Wall(new Point(1000, 1000), new Point(1000, 2000)));
            }
            Assert.That(house.Walls[2].Height, Is.EqualTo(200));
        }
    }
}