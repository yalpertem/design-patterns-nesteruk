using DesignPatterns.ChainOfResponsibility.MediatorBrokerChain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.ChainOfResponsibility.MediatorBrokerChain
{
    [TestFixture]
    public class CreatureModifierTests
    {
        [Test]
        public void Handle_AddSomeDoubleAttackModifiers_CheckIfApplied()
        {
            var game = new Game();
            var goblin = new Creature(game, "Strong Goblin", 3, 5);

            using(new DoubleAttackModifier(game, goblin))
            {
                var attack = goblin.Attack;
                Assert.That(attack, Is.EqualTo(6));
            }
        }

    }
}
