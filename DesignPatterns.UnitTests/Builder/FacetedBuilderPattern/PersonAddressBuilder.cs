using DesignPatterns.Builder.FacetedBuilderPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Builder.FacetedBuilderPattern
{
    [TestFixture]
    public class PersonAddressBuilder
    {
        [Test]
        public void At_GiveAStreetAddress_SetsStreetAddress()
        {
            var pb = new PersonBuilder();
            Person person = pb.Lives.At("XYZ Street");
            Assert.That(person.StreetAddress, Is.EqualTo("XYZ Street"));
        }

        [Test]
        public void In_GiveACity_SetsTheCity()
        {
            var pb = new PersonBuilder();
            Person person = pb.Lives.In("Istanbul");
            Assert.That(person.City, Is.EqualTo("Istanbul"));
        }

        [Test]
        public void WithPostcode_GiveAPostcode_SetsThePostcode()
        {
            var pb = new PersonBuilder();
            Person person = pb.Lives.WithPostcode("34311");
            Assert.That(person.PostCode, Is.EqualTo("34311"));
        }
    }
}