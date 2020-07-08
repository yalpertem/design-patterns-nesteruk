using DesignPatterns.Builder.FluentBuilderPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Builder.FluentBuilderPattern
{
    [TestFixture]
    public class PersonJobBuilderTests
    {
        [Test]
        public void WorksAsA_SomeJob_SetsTheJob()
        {
            var person = Person.New
                .WorksAsA("Software Developer")
                .Build();

            Assert.That(person.Position, Is.EqualTo("Software Developer"));
        }
    }
}
