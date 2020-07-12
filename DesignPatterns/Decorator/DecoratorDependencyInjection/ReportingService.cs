using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.DecoratorDependencyInjection
{
    public class ReportingService : IReportingService
    {
        public string Report()
        {
            return "Here is your report";
        }
    }
}
