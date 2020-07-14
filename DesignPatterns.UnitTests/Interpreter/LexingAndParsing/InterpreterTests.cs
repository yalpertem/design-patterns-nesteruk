using DesignPatterns.Interpreter.LexingAndParsing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Interpreter.LexingAndParsing
{
    [TestFixture]
    public class InterpreterTests
    {
        [Test]
        public void Parse_AShortExpression_ValidateResult()
        {
            var input = "(13+4)-(12+1)";
            var tokens = CustomInterpreter.Lex(input);
            var parsed = CustomInterpreter.Parse(tokens);
            Assert.That(parsed.Value, Is.EqualTo(4));
        }
    }
}
