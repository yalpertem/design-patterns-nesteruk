using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.MediatorBrokerChain
{
    public class Query
    {
        public string CreatureName { get; set; }
        public Argument WhatToQuery { get; set; }
        public int Value { get; set; }

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }

        public enum Argument
        {
            Attack, Defense
        }


    }
}
