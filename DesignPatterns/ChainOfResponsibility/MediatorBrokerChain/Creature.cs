using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.MediatorBrokerChain
{
    public class Creature
    {
        private readonly Game _game;
        private readonly int _attack, _defense;
        public string Name { get; set; }

        public Creature(Game game, string name, int attack, int defense)
        {
            _game = game;
            _attack = attack;
            _defense = defense;
            Name = name;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, _attack);
                _game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, _defense);
                _game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(_attack)}: {_attack}, {nameof(_defense)}: {_defense}";
        }
    }
}
