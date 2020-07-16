using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.UsingMediatR
{
    public class PongResponse
    {
        public DateTime? Timestamp { get; set; }

        public PongResponse(DateTime timestamp)
        {
            Timestamp = timestamp;
        }
    }
}
