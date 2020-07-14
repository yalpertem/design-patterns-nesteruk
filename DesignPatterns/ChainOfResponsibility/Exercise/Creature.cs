using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public abstract class Creature
    {
        protected Game _game;
        protected readonly int _baseAttack;
        protected readonly int _baseDefense;

        protected Creature(Game game, int baseAttack, int baseDefense)
        {
            _game = game;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
        }

        public virtual int Attack { get; set; }
        public virtual int Defense { get; set; }
        public abstract void Query(object source, StatQuery sq);

    }
}
