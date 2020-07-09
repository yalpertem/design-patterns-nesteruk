using DesignPatterns.Singleton.SingletonInDependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Singleton.SingletonInDependencyInjection
{
    [TestFixture]
    public class SingletonDatabaseTests
    {
        [Test]
        public void Instance_GetTwoInstances_ValidateTheyHaveSameReference()
        {
            var instance1 = SingletonDatabase.Instance;
            var instance2 = SingletonDatabase.Instance;
            Assert.That(instance1, Is.SameAs(instance2));
        }

        [Test]
        public void Instance_GetSomeInstances_ValidateInstanceCountIsOne()
        {
            var instance1 = SingletonDatabase.Instance;
            var instance2 = SingletonDatabase.Instance;
            var instance3 = SingletonDatabase.Instance;
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }
    }
}
