using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.MediatorBrokerChain
{
    public abstract class CreatureModifier : IDisposable
    {
        protected Game _game;
        protected Creature _creature;

        public CreatureModifier(Game game, Creature creature)
        {
            _game = game;
            _creature = creature;
            _game.Queries += Handle;
        }

        public abstract void Handle(object sender, Query q);

        public void Dispose()
        {
            _game.Queries -= Handle;
        }
    }
}
