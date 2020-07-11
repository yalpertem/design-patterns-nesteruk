using DesignPatterns.Singleton.Exercise;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Singleton.Monostate
{
    [TestFixture]
    public class SingletonTesterTests
    {
        [Test]
        public void IsSingleton_PassASingleton_ReturnsTrue()
        {
            var isSingleton = SingletonTester.IsSingleton(
                SingletonTesterData.GetSingletonObject);
            Assert.That(isSingleton, Is.EqualTo(true));
        }

        [Test]
        public void IsSingleton_PassANonSingleton_ReturnsFalse()
        {
            var isSingleton = SingletonTester.IsSingleton(
                SingletonTesterData.GetNonSingletonObject);
            Assert.That(isSingleton, Is.EqualTo(false));
        }
    }
}