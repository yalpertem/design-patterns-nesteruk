using DesignPatterns.Factories.AbstractFactoryMethodPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.UnitTests.Factories.AbstractFactoryMethodPattern
{
    [TestFixture]
    public class FooTests
    {
        [Test]
        public async Task CreateAsync_InitWithValue_SetsTheValue()
        {
            var foo = await Foo.CreateAsync("test");
            Assert.That(foo.Bar, Is.EqualTo("test"));
        }
    }
}
