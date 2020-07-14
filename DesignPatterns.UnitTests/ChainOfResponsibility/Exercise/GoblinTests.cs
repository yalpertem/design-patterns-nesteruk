using DesignPatterns.ChainOfResponsibility.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.ChainOfResponsibility.Exercise
{
    [TestFixture]
    public class GoblinTests
    {
        [Test]
        public void Attack_CreateTwoGoblins_ValidateAttackValue()
        {
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            Assert.That(goblin.Attack, Is.EqualTo(1));
        }

        [Test]
        public void Attack_CreateTwoGoblins_ValidateDefenseValue()
        {
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            Assert.That(goblin.Defense, Is.EqualTo(2));
        }

        [Test]
        public void Attack_CreateTwoGoblinsAndAKing_ValidateAttackValue()
        {
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);
            Assert.That(goblin.Attack, Is.EqualTo(2));
        }

        [Test]
        public void Attack_CreateTwoGoblinsAndAKing_ValidateDefenseValue()
        {
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);
            Assert.That(goblin.Defense, Is.EqualTo(3));
        }
    }
}
