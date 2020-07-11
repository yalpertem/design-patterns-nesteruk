using DesignPatterns.Prototype.CopyThroughSerialization;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Prototype.CopyThroughSerialization
{
    [TestFixture]
    public class ExtensionMethodsTests
    {
        [Test]
        public void DeepCopy_CopyPerson_DoesNotChangeFirstPersonsName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopy();
            otherPerson.Names[0] = "Jane";

            Assert.That(person.Names[0], Is.EqualTo("John"));
        }

        [Test]
        public void DeepCopy_CopyPerson_DoesNotChangeFirstPersonsAddressStreetName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopy();
            otherPerson.Address.StreetName = "Washington Street";

            Assert.That(person.Address.StreetName, Is.EqualTo("London Street"));
        }

        [Test]
        public void DeepCopyXml_CopyPerson_DoesNotChangeFirstPersonsName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopyXml();
            otherPerson.Names[0] = "Jane";

            Assert.That(person.Names[0], Is.EqualTo("John"));
        }

        [Test]
        public void DeepCopyXml_CopyPerson_DoesNotChangeFirstPersonsAddressStreetName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopyXml();
            otherPerson.Address.StreetName = "Washington Street";

            Assert.That(person.Address.StreetName, Is.EqualTo("London Street"));
        }

        [Test]
        public void DeepCopyJson_CopyPerson_DoesNotChangeFirstPersonsName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopyJson();
            otherPerson.Names[0] = "Jane";

            Assert.That(person.Names[0], Is.EqualTo("John"));
        }

        [Test]
        public void DeepCopyJson_CopyPerson_DoesNotChangeFirstPersonsAddressStreetName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopyJson();
            otherPerson.Address.StreetName = "Washington Street";

            Assert.That(person.Address.StreetName, Is.EqualTo("London Street"));
        }
    }
}