using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class Actor
    {
        protected EventBroker _broker;

        public Actor(EventBroker broker)
        {
            _broker = broker;
        }
    }
}
