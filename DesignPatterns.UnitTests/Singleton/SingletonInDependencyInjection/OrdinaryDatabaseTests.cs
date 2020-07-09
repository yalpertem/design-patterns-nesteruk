using Autofac;
using DesignPatterns.Singleton.SingletonInDependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace DesignPatterns.UnitTests.Singleton.SingletonInDependencyInjection
{
    [TestFixture]
    public class OrdinaryDatabaseTests
    {
        [Test]
        public void GetTotalPopulation_InitializedViaAutofac_ReturnsTotalPopulation()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            cb.RegisterType<ConfigurableRecordFinder>();

            using(var c = cb.Build())
            {
                var rf = c.Resolve<ConfigurableRecordFinder>();
                var total = rf.GetTotalPopulation(new string[] { "Seoul" });
                Assert.That(total, Is.EqualTo(9838892));
            }
        }
    }
}
