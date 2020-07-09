using DesignPatterns.Factories.AbstractFactoryPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Factories.AbstractFactoryPattern
{
    [TestFixture]
    public class HotDrinkMachineTests
    {
        [Test]
        public void MakeDrink_MakeCoffee_ReturnValueIsNotNull()
        {
            var hotDrinkMachine = new HotDrinkMachine();
            var drink = hotDrinkMachine.MakeDrink(AvailableDrink.Coffee, 100);
            Assert.That(drink, Is.Not.Null);
        }

        [Test]
        public void MakeDrink_MakeTea_ReturnValueIsNotNull()
        {
            var hotDrinkMachine = new HotDrinkMachine();
            var drink = hotDrinkMachine.MakeDrink(AvailableDrink.Tea, 100);
            Assert.That(drink, Is.Not.Null);
        }
    }
}
