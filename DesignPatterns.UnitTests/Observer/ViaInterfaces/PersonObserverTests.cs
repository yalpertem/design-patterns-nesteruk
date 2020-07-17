using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Observer.ViaInterfaces;
using System.IO;

namespace DesignPatterns.UnitTests.Observer.WeakEvent
{
    [TestFixture]
    public class PersonObserverTests
    {
        [Test]
        public void Constructor_()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var po = new PersonObserver();
            var expectedOutput = "Doctor goes to 123 London";
            Assert.That(output.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}
