using DesignPatterns.Proxy.ProtectionProxy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.ProtectionProxy
{
    [TestFixture]
    public class CarProxyTests
    {
        [Test]
        public void Drive_AgeLessThan18_DoesNotDrive()
        {
            var driver = new Driver(14);
            ICar carProxy = new CarProxy(driver);
            var drive = carProxy.Drive();
            Assert.That(drive, Is.EqualTo("too young"));
        }

        [Test]
        public void Drive_AgeGreaterThan18_DoesNotDrive()
        {
            var driver = new Driver(30);
            ICar carProxy = new CarProxy(driver);
            var drive = carProxy.Drive();
            Assert.That(drive, Is.EqualTo("driving"));
        }
    }
}
