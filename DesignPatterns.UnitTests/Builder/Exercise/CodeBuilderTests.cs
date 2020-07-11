using DesignPatterns.Builder.Exercise;
using NUnit.Framework;
using System;

namespace DesignPatterns.UnitTests.Builder.Exercise
{
    [TestFixture]
    public class CodeBuilderTests
    {
        [Test]
        public void AddField_GiveTwoFields_GenerateIndentedCode()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            var code = cb.ToString();
            var expectedResult =
@"public class Person
{
  public string Name;
  public int Age;
}";
            Assert.That(code, Is.EqualTo(expectedResult));
            Console.WriteLine(code);
        }
    }
}