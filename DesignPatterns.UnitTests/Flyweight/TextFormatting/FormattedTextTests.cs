using DesignPatterns.Flyweight.TextFormatting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Flyweight.TextFormatting
{
    [TestFixture]
    public class FormattedTextTests
    {
        [Test]
        public void Capitalize_AString_ValidateOutput()
        {
            var formattedText = new FormattedText("This is a brave new world");
            formattedText.Capitalize(10, 15);
            var expectedOutput = "This is a BRAVE new world";
            Assert.That(formattedText.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}
