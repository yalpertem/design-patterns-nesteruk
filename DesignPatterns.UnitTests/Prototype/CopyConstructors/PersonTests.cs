using DesignPatterns.Prototype.CopyConstructors;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Prototype.CopyConstructors
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Constructor_CopyPerson_DoesNotChangeFirstPersonsName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = new Person(person);
            otherPerson.Names[0] = "Jane";

            Assert.That(person.Names[0], Is.EqualTo("John"));
        }

        [Test]
        public void Constructor_CopyPerson_DoesNotChangeFirstPersonsAddressStreetName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = new Person(person);
            otherPerson.Address.StreetName = "Washington Street";

            Assert.That(person.Address.StreetName, Is.EqualTo("London Street"));
        }
    }
}