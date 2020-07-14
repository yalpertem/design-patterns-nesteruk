using DesignPatterns.Command.Bank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Command.Bank
{
    [TestFixture]
    public class MoneyTransferCommandTests
    {
        [Test]
        public void Call_TransferSmallerAmountThanBalance_ValidateFromBalance()
        {
            var from = new BankAccount();
            from.Deposit(100);
            var to = new BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 70);
            mtc.Call();

            Assert.That(from.Balance, Is.EqualTo(30));
        }

        [Test]
        public void Call_TransferSmallerAmountThanBalance_ValidateToBalance()
        {
            var from = new BankAccount();
            from.Deposit(100);
            var to = new BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 70);
            mtc.Call();

            Assert.That(to.Balance, Is.EqualTo(70));
        }

        [Test]
        public void Undo_TransferSmallerAmountThanBalance_ValidateFromBalance()
        {
            var from = new BankAccount();
            from.Deposit(100);
            var to = new BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 70);
            mtc.Call();
            mtc.Undo();

            Assert.That(from.Balance, Is.EqualTo(100));
        }

        [Test]
        public void Undo_TransferSmallerAmountThanBalance_ValidateToBalance()
        {
            var from = new BankAccount();
            from.Deposit(100);
            var to = new BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 70);
            mtc.Call();
            mtc.Undo();

            Assert.That(to.Balance, Is.EqualTo(0));
        }
    }
}
