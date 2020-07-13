using DesignPatterns.Proxy.ArrayBackedCompositeProxy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.ArrayBackedCompositeProxy
{
   [TestFixture]
    public class MasonrySettingsTests
    {
        [Test]
        public void All_SetAllFlagsToFalse_CheckIfFloorsIsSetCorrect()
        {
            var settings = new MasonrySettings
            {
                Floors = true,
                Pillars = true
            };

            settings.All = false;

            Assert.That(settings.Floors, Is.EqualTo(false));
        }
    }
}
