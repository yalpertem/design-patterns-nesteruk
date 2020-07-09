using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Singleton.SingletonInDependencyInjection
{
    public class OrdinaryDatabase : IDatabase
    {
        private readonly Dictionary<string, int> _capitals;

        public OrdinaryDatabase()
        {
            Console.WriteLine("Init db");
            Count++;
            _capitals = File.ReadAllLines(@"Singleton\SingletonInDependencyInjection\capitals.txt")
                .Batch(2).ToDictionary(
                x => x.ElementAt(0).Trim(),
                x => int.Parse(x.ElementAt(1))
                );
        }

        public static int Count { get; private set; }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
