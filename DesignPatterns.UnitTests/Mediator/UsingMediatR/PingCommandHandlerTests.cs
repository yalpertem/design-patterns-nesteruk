using Autofac;
using DesignPatterns.Mediator.UsingMediatR;
using MediatR;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.UnitTests.Mediator.UsingMediatR
{
    [TestFixture]
    public class PingCommandHandlerTests
    {
        [Test]
        public async Task Handle_WhenPingCommandEventIsHappened_SetsPongResponseTimestamp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MediatR.Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();
            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(PingCommand).Assembly)
                .AsImplementedInterfaces();

            var container = builder.Build();
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());

            Assert.That(response.Timestamp.HasValue, Is.EqualTo(true));

        }
    }
}
