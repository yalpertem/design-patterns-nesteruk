using DesignPatterns.Builder.FunctionalBuilderPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.FunctionalBuilderPattern
{
    [TestFixture]
    public class PersonBuilderTests
    {
        [Test]
        public void Called_GiveAName_SetsTheName()
        {
            var person = new PersonBuilder()
                .Called("Yigitalp")
                .Build();

            Assert.That(person.Name, Is.EqualTo("Yigitalp"));
        }

        [Test]
        public void WorksAs_GiveAPosition_SetsThePosition()
        {
            var person = new PersonBuilder()
                .WorksAs("Developer")
                .Build();

            Assert.That(person.Position, Is.EqualTo("Developer"));
        }
    }
}