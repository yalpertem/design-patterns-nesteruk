using DesignPatterns.Mediator.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MyMediator = DesignPatterns.Mediator.Exercise.Mediator;

namespace DesignPatterns.UnitTests.Mediator.Exercise
{
    [TestFixture]
    public class ParticipantTests
    {
        [Test]
        public void Say_GiveAnIncrementValue_DoesNotChangeItsOwnValue()
        {
            var mediator = new MyMediator();
            var p1 = new Participant(mediator);
            p1.Say(5);
            Assert.That(p1.Value, Is.EqualTo(0));
        }

        [Test]
        public void Say_GiveAnIncrementValue_ChangesOthersValue()
        {
            var mediator = new MyMediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);
            p1.Say(5);
            Assert.That(p2.Value, Is.EqualTo(5));
        }


        [Test]
        public void Say_CallMethodMultipleTimes_AddsAllValues()
        {
            var mediator = new MyMediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);
            p1.Say(5);
            p1.Say(4);
            p1.Say(4);
            Assert.That(p2.Value, Is.EqualTo(13));
        }
    }
}
