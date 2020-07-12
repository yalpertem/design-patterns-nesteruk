using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.PropertyProxy
{
    public class Creature
    {
        private readonly Property<int> _agility = new Property<int>();

        public int Agility
        {
            get => _agility.Value;
            set => _agility.Value = value;
        }
    }
}
