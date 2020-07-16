using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class PlayerScoredEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }

        public PlayerScoredEvent(string name, int goalsScored)
            : base(name)
        {
            GoalsScored = goalsScored;
        }
    }
}
