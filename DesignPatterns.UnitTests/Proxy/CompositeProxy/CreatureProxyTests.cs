using DesignPatterns.Proxy.CompositeProxy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.CompositeProxy
{
    [TestFixture]
    public class CreatureProxyTests
    {
        [Test]
        public void Age_IncreaseAge_SetsCorrectValue()
        {
            var creatures = new Creatures(100);
            foreach (Creatures.CreatureProxy c in creatures)
            {
                c.Age++;
            }
            foreach (Creatures.CreatureProxy c in creatures)
            {
                Assert.That(c.Age, Is.EqualTo(1));
            }
        }
    }
}
