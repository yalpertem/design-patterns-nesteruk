using DesignPatterns.Decorator.CustomStringBuilder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Decorator.CustomStringBuilder
{
    [TestFixture]
    public class CodeBuilderTests
    {
        [Test]
        public void AppendLine_AppendFewLines_CreatesRightString()
        {
            var cb = new CodeBuilder();
            cb.AppendLine("public class CodeBuilder")
                .AppendLine("{").AppendLine("}");
            var result = cb.ToString();

            var expectedResult = @"public class CodeBuilder
{
}
";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
