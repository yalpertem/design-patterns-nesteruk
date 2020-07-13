using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.MediatorBrokerChain
{
    public class IncreasedDefenseModifier : CreatureModifier
    {
        public IncreasedDefenseModifier(Game game, Creature creature) : base(game, creature)
        {
        }

        public override void Handle(object sender, Query q)
        {
            if (q.CreatureName == _creature.Name && q.WhatToQuery == Query.Argument.Defense)
            {
                q.Value += 3;
            }
        }
    }
}
