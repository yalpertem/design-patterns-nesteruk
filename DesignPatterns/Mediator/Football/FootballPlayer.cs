using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; }

        public FootballPlayer(EventBroker broker, string name)
            : base(broker)
        {
            Name = name;

            broker.OfType<PlayerScoredEvent>()
                .Where(x => x.Name != Name)
                .Subscribe(ps =>
                    Console.WriteLine($"{Name}: good job {ps.Name}, it's goal no: {ps.GoalsScored}")
                );

            broker.OfType<PlayerSentOffEvent>()
                .Where(x => x.Name != Name)
                .Subscribe(ps =>
                    Console.WriteLine($"{Name}: see you {ps.Name}")
                );
        }

        public void Score()
        {
            GoalsScored++;
            _broker.Publish(new PlayerScoredEvent(Name, GoalsScored));
        }

        public void AssaultReferee()
        {
            _broker.Publish(new PlayerSentOffEvent(Name, "violence"));
        }
    }
}
