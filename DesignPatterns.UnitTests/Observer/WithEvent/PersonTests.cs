using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Observer.WithEvent;
using System.IO;

namespace DesignPatterns.UnitTests.Observer.WithEvent
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void CatchACold_MethodObservesTheFallsIllEvent_ValidateThatItsCalled()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var person = new Person();
            person.FallsIll += CallDoctor;
            person.CatchACold(); //invokes the event
            var expectedOutput = "Doctor to 123 London Road";

            Assert.That(output.ToString(), Is.EqualTo(expectedOutput));
        }

        private void CallDoctor(object sender, FallsIllEventArgs e)
        {
            Console.Write($"Doctor to {e.Address}");
        }
    }
}
