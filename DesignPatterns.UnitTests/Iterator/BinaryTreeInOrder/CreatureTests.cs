using DesignPatterns.Iterator.ArrayBackedProperties;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Iterator.BinaryTreeInOrder
{
    [TestFixture]
    public class CreatureTests
    {
        [Test]
        public void AverageStat_SetArrayBackedProperties_ValidateResult()
        {
            var creature = new Creature()
            {
                Agility = 5,
                Intelligence = 10,
                Strength = 3
            };
            Assert.That(creature.AveregeStat, Is.EqualTo(6));
        }
    }
}
