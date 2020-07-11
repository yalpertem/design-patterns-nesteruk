using DesignPatterns.Singleton.SingletonInDependencyInjection;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Singleton.SingletonInDependencyInjection
{
    [TestFixture]
    public class ConfigurableRecordFinderTests
    {
        [Test]
        public void GetTotalPopulation_CalculateForSomeInputs_ReturnTheSumCorrectly()
        {
            var finder = new ConfigurableRecordFinder(new DummyDatabase());
            var total = finder.GetTotalPopulation(new string[] { "alpha", "gama" });
            Assert.That(total, Is.EqualTo(4));
        }
    }
}