using DesignPatterns.Builder.FacetedBuilderPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Builder.FacetedBuilderPattern
{
    [TestFixture]
    public class PersonJobBuilderTests
    {
        [Test]
        public void AsA_GiveAPosition_SetsThePosition()
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.AsA("developer");
            Assert.That(person.Position, Is.EqualTo("developer"));
        }

        [Test]
        public void At_GiveACompanyName_SetsTheCompanyName()
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.At("XYZ Company");
            Assert.That(person.CompanyName, Is.EqualTo("XYZ Company"));
        }

        [Test]
        public void AsA_GiveAnAnnualEarning_SetsTheAnnualEarning()
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.Earning(100);
            Assert.That(person.AnnualIncome, Is.EqualTo(100));
        }
    }
}