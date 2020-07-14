using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game, 3, 3)
        {
        }

        public override void Query(object source, StatQuery sq)
        {
            if (!ReferenceEquals(source, this) && sq.Statistic == Statistic.Attack)
            {
                sq.Result++; // every goblin gets +1 attack
            }
            else base.Query(source, sq);
        }
    }

}
