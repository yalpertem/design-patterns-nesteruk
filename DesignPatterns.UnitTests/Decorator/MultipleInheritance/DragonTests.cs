using DesignPatterns.Decorator.MultipleInheritance;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Decorator.MultipleInheritance
{
    [TestFixture]
    public class DragonTests
    {
        [Test]
        public void Fly_SetWeightBefore_SetsWeightAndReturns()
        {
            var dragon = new Dragon(new Bird(), new Lizard())
            {
                Weight = 123
            };
            var flied = dragon.Fly();
            Assert.That(flied, Is.EqualTo("Flying with weight 123"));
        }

        [Test]
        public void Crawl_SetWeightBefore_SetsWeightAndReturns()
        {
            var dragon = new Dragon(new Bird(), new Lizard())
            {
                Weight = 123
            };
            var crawled = dragon.Crawl();
            Assert.That(crawled, Is.EqualTo("Crawling with weight 123"));
        }
    }
}
