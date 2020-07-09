using DesignPatterns.Singleton.SingletonInDependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Singleton.SingletonInDependencyInjection
{
    public class DummyDatabase : IDatabase
    {
        private Dictionary<string, int> _pairs =
            new Dictionary<string, int>() {
            { "alpha", 1 },
            { "beta", 2 },
            { "gama", 3 }
            };

        public int GetPopulation(string name)
        {
            return _pairs[name];
        }
    }
}
