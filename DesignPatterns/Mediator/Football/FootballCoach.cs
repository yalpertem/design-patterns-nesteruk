using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class FootballCoach : Actor
    {
        public FootballCoach(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerScoredEvent>()
                .Subscribe(pe =>
                {
                    if (pe.GoalsScored < 3)
                    {
                        Console.WriteLine($"Coach: well done, {pe.Name}");
                    }
                });

            broker.OfType<PlayerSentOffEvent>()
                .Subscribe(pe =>
                {
                    if (pe.Reason == "violence")
                    {
                        Console.WriteLine($"Coach: how could you,  {pe.Name}");
                    }
                });
        }
    }
}
