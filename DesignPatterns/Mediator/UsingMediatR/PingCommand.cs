using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.UsingMediatR
{
    public class PingCommand : IRequest<PongResponse>
    {
    }
}
