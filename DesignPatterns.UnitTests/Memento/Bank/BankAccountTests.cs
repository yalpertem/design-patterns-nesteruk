using DesignPatterns.Memento.Bank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Memento.Bank
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Restore_BackToAnOldMemento_ValidateBalance()
        {
            var ba = new BankAccount(100);
            var m1 = ba.Deposit(30);
            ba.Deposit(20);
            ba.Restore(m1);
            Assert.That(ba.ToString(), Is.EqualTo($"balance:130"));
        }
    }
}
