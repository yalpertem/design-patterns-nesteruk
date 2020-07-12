using DesignPatterns.Decorator.MultipleInheritanceDefault;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Decorator.MultipleInheritanceDefault
{
    [TestFixture]
    public class DragonTests
    {
        [Test]
        public void Fly_CastToBird_GetFlyResult()
        {
            var dragon = new Dragon() { Age = 15 };
            string result = null;
            if (dragon is IBird bird)
            {
                result = bird.Fly();
            }
            Assert.That(result, Is.EqualTo("I am flying"));
        }

        [Test]
        public void Crawl_CastToBird_GetFlyResult()
        {
            var dragon = new Dragon() { Age = 5 };
            string result = null;
            if (dragon is ILizard lizard)
            {
                result = lizard.Crawl();
            }
            Assert.That(result, Is.EqualTo("I am crawling."));
        }
    }
}
