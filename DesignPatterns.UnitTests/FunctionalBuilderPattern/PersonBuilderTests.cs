﻿using DesignPatterns.FunctionalBuilderPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.FunctionalBuilderPattern
{
    [TestFixture]
    public class PersonBuilderTests
    {
        [Test]
        public void Called_GiveAName_SetsTheName()
        {
            var person = new PersonBuilder()
                .Called("Yigitalp")
                .Build();

            Assert.That(person.Name, Is.EqualTo("Yigitalp"));
        }
    }
}
