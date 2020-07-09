using DesignPatterns.Factories.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Factories.Exercise
{
    [TestFixture]
    public class PersonFactoryTests
    {
        [Test]
        public void CreatePerson_CreateSome_SetsRightId()
        {
            var personFactory = new PersonFactory();
            personFactory.CreatePerson("John");
            personFactory.CreatePerson("Jane");
            var person = personFactory.CreatePerson("Doe");
            Assert.That(person.Id, Is.EqualTo(2));
        }

        [Test]
        public void CreatePerson_CreateSome_SetsRightName()
        {
            var personFactory = new PersonFactory();
            personFactory.CreatePerson("John");
            personFactory.CreatePerson("Jane");
            var person = personFactory.CreatePerson("Doe");
            Assert.That(person.Name, Is.EqualTo("Doe"));
        }
    }
}
