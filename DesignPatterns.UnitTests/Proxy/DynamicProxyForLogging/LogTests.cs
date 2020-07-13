using DesignPatterns.Proxy.DynamicProxyForLogging;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.DynamicProxyForLogging
{
    [TestFixture]
    public    class LogTests
    {
        [Test]
        public void ToString_MakeSomeOperations_CheckMethodCallCounts()
        {
            var ba = Log<BankAccount>.As<IBankAccount>();
            ba.Deposit(100);
            ba.Withdraw(50);
            var result = ba.ToString();
            var expectedResult = @"Deposit called 1 times.
Withdraw called 1 times.

_balance: 50";

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
