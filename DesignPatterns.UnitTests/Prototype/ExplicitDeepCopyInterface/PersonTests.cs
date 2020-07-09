using DesignPatterns.Prototype.ExplicitDeepCopyInterface;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Prototype.ExplicitDeepCopyInterface
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
            var otherPerson = person.DeepCopy();
            otherPerson.Names[0] = "Jane";

            Assert.That(person.Names[0], Is.EqualTo("John"));
        }

        [Test]
        public void Constructor_CopyPerson_DoesNotChangeFirstPersonsAddressStreetName()
        {
            var person = new Person(
                new string[] { "John", "Fowles" },
                new Address("London Street", "123"));
            var otherPerson = person.DeepCopy();
            otherPerson.Address.StreetName = "Washington Street";

            Assert.That(person.Address.StreetName, Is.EqualTo("London Street"));
        }
    }
}
