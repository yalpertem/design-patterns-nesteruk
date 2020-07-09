using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Singleton.SingletonImplementation
{
    public class SingletonDatabase : IDatabase
    {
        private readonly Dictionary<string, int> _capitals;
        private static readonly Lazy<SingletonDatabase> _instance = 
            new Lazy<SingletonDatabase>(() =>
        {
            Count++;
            return new SingletonDatabase();
        });

        private SingletonDatabase()
        {
            Console.WriteLine("Init db");
            _capitals = File.ReadAllLines(@"Singleton\SingletonImplementation\capitals.txt")
                .Batch(2).ToDictionary(
                x => x.ElementAt(0).Trim(),
                x => int.Parse(x.ElementAt(1))
                );
        }

        public static SingletonDatabase Instance => _instance.Value;
        public static int Count { get; private set; }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
