using DesignPatterns.ChainOfResponsibility.MethodChain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.ChainOfResponsibility.MethodChain
{
    [TestFixture]
    public class CreatureModifierTests
    {
        [Test]
        public void Handle_AddSomeDoubleAttackModifiers_CheckIfApplied()
        {
            var creature = new Creature("Test", 100, 100);
            var cm = new CreatureModifier(creature);
            cm.Add(new DoubleAttackModifier(creature));
            cm.Add(new DoubleAttackModifier(creature));
            cm.Handle();

            var attack = creature.Attack;
            Assert.That(attack, Is.EqualTo(400));
        }

        [Test]
        public void Handle_AddNoBonusesModifier_CheckIfFurtherModifiersAreNotApplied()
        {
            var creature = new Creature("Test", 100, 100);
            var cm = new CreatureModifier(creature);
            cm.Add(new DoubleAttackModifier(creature));
            cm.Add(new NoBonusesModifier(creature));
            cm.Add(new DoubleAttackModifier(creature));
            cm.Add(new DoubleAttackModifier(creature));
            cm.Handle();

            var attack = creature.Attack;
            Assert.That(attack, Is.EqualTo(200));
        }
    }
}
