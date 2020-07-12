using DesignPatterns.Flyweight.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Flyweight.Exercise
{

    [TestFixture]
    public class SentenceTests
    {
        [Test]
        public void ToString_CapitalizeSomeWords_ReturnsExpected()
        {
            var sentence = new Sentence("hello world");
            sentence[1].Capitalize = true;
            var expectedOutput = "hello WORLD";
            Assert.That(sentence.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}
