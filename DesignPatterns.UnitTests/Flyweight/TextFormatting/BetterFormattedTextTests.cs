using DesignPatterns.Flyweight.TextFormatting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Flyweight.TextFormatting
{
    [TestFixture]
    public class BetterFormattedTextTests
    {
        [Test]
        public void Capitalize_AString_ValidateOutput()
        {
            var formattedText = new BetterFormattedText("This is a brave new world");
            formattedText.GetRange(10, 15).Capitalize = true;
            var expectedOutput = "This is a BRAVE new world";
            Assert.That(formattedText.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}
