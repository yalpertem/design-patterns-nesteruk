using Autofac;
using DesignPatterns.NullObj.BankLog;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.NullObj.BankLog
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ConstructWithNullLog_PreventException()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<BankAccount>();
            cb.RegisterType<NullLog>().As<ILog>();
            using (var c = cb.Build())
            {
                var ba = c.Resolve<BankAccount>();
                ba.Deposit(100);
            }
        }

        [Test]
        public void Deposit_ConstructWithDynamicNullLog_PreventException()
        {
            var log = Null<ILog>.Instance;
            var ba = new BankAccount(log);
            ba.Deposit(100);
        }
    }
}
