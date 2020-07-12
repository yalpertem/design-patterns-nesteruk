using DesignPatterns.Proxy.PropertyProxy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.PropertyProxy
{
   [TestFixture]
    public  class PropertyTests
    {
        [Test]
        public void Assignment_SetValueOfTheProperty_SetsTheInnerValue()
        {
            var creature = new Creature();
            creature.Agility = 10;
            Assert.That(creature.Agility, Is.EqualTo(10));
        }
    }
}
