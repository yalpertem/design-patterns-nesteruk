using Autofac;
using DesignPatterns.Decorator.DecoratorDependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Decorator.DecoratorDependencyInjection
{
    [TestFixture]
    public class ReportingServiceWithLoggingTests
    {
        [Test]
        public void Report_DecorateWithAutofac_ReturnsLogWithDecoradedService()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            cb.RegisterDecorator<IReportingService>(
                (context, service) =>
                new ReportingServiceWithLogging(service), "reporting");

            using (var c = cb.Build())
            {
                var service = c.Resolve<IReportingService>();
                var result = service.Report();
                var expectedResult = "[LOG]Here is your report[/LOG]";
                Assert.That(result, Is.EqualTo(expectedResult));
            }

        }
    }
}
