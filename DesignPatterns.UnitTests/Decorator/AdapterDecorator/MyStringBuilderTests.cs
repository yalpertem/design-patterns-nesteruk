using DesignPatterns.Decorator.AdapterDecorator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Decorator.AdapterDecorator
{
    [TestFixture]
    public class MyStringBuilderTests
    {
        [Test]
        public void PlusOperator_AddTwoStrings_ReturnsConcatenatedResult()
        {
            MyStringBuilder msb = "hello";
            msb += " world";
            Assert.That(msb.ToString(), Is.EqualTo("hello world"));
        }
    }
}
