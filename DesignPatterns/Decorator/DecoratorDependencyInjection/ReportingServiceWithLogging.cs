using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DecoratorDependencyInjection
{
    public class ReportingServiceWithLogging : IReportingService
    {
        private readonly IReportingService _decorated;

        public ReportingServiceWithLogging(IReportingService decorated)
        {
            _decorated = decorated;
        }

        public string Report()
        {
            return $"[LOG]{_decorated.Report()}[/LOG]";
        }
    }
}
