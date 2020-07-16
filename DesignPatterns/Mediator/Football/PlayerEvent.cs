using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class PlayerEvent
    {
        public string Name { get; set; }

        public PlayerEvent(string name)
        {
            Name = name;
        }
    }
}
