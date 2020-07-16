using Autofac;
using DesignPatterns.Mediator.Football;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.UnitTests.Mediator.Football
{
    [TestFixture]
    public class EventBrokerTests
    {
        [Test]
        public void fdsa()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var cb = new ContainerBuilder();
            cb.RegisterType<EventBroker>().SingleInstance();
            cb.RegisterType<FootballCoach>();
            cb.Register((c, p) =>
                new FootballPlayer(
                    c.Resolve<EventBroker>(),
                    p.Named<string>("name")));

            using (var c = cb.Build())
            {
                var coach = c.Resolve<FootballCoach>();
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));
                player1.Score();
                player1.Score();
                player1.AssaultReferee();
                player2.Score();
            }
            var expectedOutput = @"Coach: well done, John
Chris: good job John, it's goal no: 1
Coach: well done, John
Chris: good job John, it's goal no: 2
Coach: how could you,  John
Chris: see you John
Coach: well done, Chris
John: good job Chris, it's goal no: 1
";
            Assert.That(output.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}
