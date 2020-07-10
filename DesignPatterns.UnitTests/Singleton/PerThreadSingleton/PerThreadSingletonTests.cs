using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PerThreadSingletonClass = DesignPatterns.Singleton.PerThreadSingleton.PerThreadSingleton;

namespace DesignPatterns.UnitTests.Singleton.PerThreadSingleton
{
    [TestFixture]
    public class PerThreadSingletonTests
    {
        [Test]
        public void Instance_CreateMultipleInstancesInSeparateThreads_ValidateTheyHaveDifferentThreadId()
        {
            int id1 = 1, id2 = 1;
            var t1 = Task.Factory.StartNew(() =>
            {
                id1 = PerThreadSingletonClass.Instance.Id;
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                id2 = PerThreadSingletonClass.Instance.Id;
            });
            Task.WaitAll(t1, t2);
            Assert.That(id1, Is.Not.EqualTo(id2));
        }
        public void Instance_CreateMultipleInstancesInSameThread_ValidateTheyHaveSameThreadId()
        {
            int id1 = 1, id2 = 2;
            var t = Task.Factory.StartNew(() =>
            {
               id1 = PerThreadSingletonClass.Instance.Id;
               id2 = PerThreadSingletonClass.Instance.Id;
            });
            Task.WaitAll(t);
            Assert.That(id1, Is.EqualTo(id2));
        }
    }
}
