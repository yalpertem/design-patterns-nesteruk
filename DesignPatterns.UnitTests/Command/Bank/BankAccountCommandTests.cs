﻿using DesignPatterns.Command.Bank;
using MoreLinq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Command.Bank
{
    [TestFixture]
    public class BankAccountCommandTests
    {
        [Test]
        public void Call_CreateAFewCommandsAndCall_SetsCorrectBalance()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 20),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 10)
            };
            commands.ForEach(x => x.Call());

            Assert.That(ba.Balance, Is.EqualTo(70));
        }


        [Test]
        public void Call_CreateAFewFailedCommandsAndCall_SetsCorrectBalance()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 20),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
            };
            commands.ForEach(x => x.Call());

            Assert.That(ba.Balance, Is.EqualTo(80));
        }

        [Test]
        public void Undo_CreateAFewCommandsAndCall_SetsCorrectBalance()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 20),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 10)
            };
            commands.ForEach(x => x.Call());
            Enumerable.Reverse(commands).ForEach(x => x.Undo());

            Assert.That(ba.Balance, Is.EqualTo(0));
        }


        [Test]
        public void Undo_CreateAFewFailedCommandsAndCall_SetsCorrectBalance()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 20),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
            };
            commands.ForEach(x => x.Call());
            Enumerable.Reverse(commands).ForEach(x => x.Undo());

            Assert.That(ba.Balance, Is.EqualTo(0));
        }
    }
}
