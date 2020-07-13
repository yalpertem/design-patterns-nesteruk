using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.MethodChain
{
    public class CreatureModifier
    {
        protected Creature _creature;
        protected CreatureModifier _next; //LL

        public CreatureModifier(Creature creature)
        {
            _creature = creature;
        }

        public void Add(CreatureModifier cm)
        {
            if (_next != null)
            {
                _next.Add(cm);
            }
            else
            {
                _next = cm;
            }
        }

        public virtual void Handle() => _next?.Handle();
    }
}
