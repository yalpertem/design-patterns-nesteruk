using DesignPatterns.Singleton.Monostate;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Singleton.Monostate
{
    [TestFixture]
    public class CeoTests
    {
        [Test]
        public void Constructor_CreateMultipleCeos_ValidateTheyShareSameName()
        {
            var ceo = new Ceo()
            {
                Name = "Jane Doe",
                Age = 25
            };

            var ceo2 = new Ceo();

            Assert.That(ceo2.Name, Is.EqualTo("Jane Doe"));
        }

        [Test]
        public void Constructor_CreateMultipleCeos_ValidateTheyShareSameAge()
        {
            var ceo = new Ceo()
            {
                Name = "Jane Doe",
                Age = 25
            };

            var ceo2 = new Ceo();

            Assert.That(ceo2.Age, Is.EqualTo(25));
        }
    }
}
