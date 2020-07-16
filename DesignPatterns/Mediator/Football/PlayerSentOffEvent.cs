using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }

        public PlayerSentOffEvent(string name, string reason)
            : base(name)
        {
            Reason = reason;
        }
    }
}
