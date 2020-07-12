using DesignPatterns.Proxy.ValueProxy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.ValueProxy
{
    [TestFixture]
    public class PercentageTests
    {
        [Test]
        public void AddOperator_AddTwoPercentage_DisplayCorrectResult()
        {
            var total = 2.Percent() + 3.Percent();
            Assert.That(total.ToString(), Is.EqualTo("5%"));
        }

        [Test]
        public void MultiplyOperator_MultiplyFloatWithPercentage_ReturnCorrectResult()
        {
            var total = 10f * 5.Percent();
            Assert.That(total, Is.EqualTo(0.5f));
        }
    }
}
