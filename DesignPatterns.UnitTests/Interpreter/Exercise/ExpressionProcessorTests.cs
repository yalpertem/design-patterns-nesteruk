using DesignPatterns.Interpreter.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Interpreter.Exercise
{
    [TestFixture]
    public class ExpressionProcessorTests
    {
        [Test]
        public void Calculate_ValidInputOfNumbers_CheckResult()
        {
            var ep = new ExpressionProcessor();
            var result = ep.Calculate("1+2+3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Calculate_ValidInputOfNumbersAndVariables_CheckResult()
        {
            var ep = new ExpressionProcessor();
            ep.Variables['x'] = 10;
            var result = ep.Calculate("1-2+3+x");
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Calculate_InvalidInputOfNumbersAndVariables_CheckResult()
        {
            var ep = new ExpressionProcessor();
            ep.Variables['x'] = 10;
            var result = ep.Calculate("1+3+xy");
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
