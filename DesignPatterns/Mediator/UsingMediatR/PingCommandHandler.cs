using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.UsingMediatR
{
    public class PingCommandHandler : IRequestHandler<PingCommand, PongResponse>
    {
        public async Task<PongResponse> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new PongResponse(DateTime.UtcNow))
                .ConfigureAwait(false);
        }
    }
}
