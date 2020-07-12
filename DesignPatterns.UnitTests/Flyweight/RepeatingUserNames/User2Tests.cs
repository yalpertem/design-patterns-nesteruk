using DesignPatterns.Flyweight.RepeatingUserNames;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Flyweight.RepeatingUserNames
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void TestUser()
        {
            var user2 = new User2("John Doe");
            Assert.That(user2.FullName, Is.EqualTo("John Doe"));
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private List<User2> GetDummyUsers()
        {
            var firstNames = Enumerable.Range(0, 100)
                            .Select(x => RandomString());
            var lastNames = Enumerable.Range(0, 100)
                .Select(x => RandomString());
            var users = new List<User2>();
            foreach (var firstName in firstNames)
            {
                foreach (var lastName in lastNames)
                {
                    users.Add(new User2($"{firstName} {lastName}"));
                }
            }
            return users;
        }

        private string RandomString()
        {
            Random rand = new Random();
            return new string(
                Enumerable.Range(0, 10)
                .Select(x => (char)('a' + rand.Next(0, 27)))
                .ToArray());
        }
    }
}
