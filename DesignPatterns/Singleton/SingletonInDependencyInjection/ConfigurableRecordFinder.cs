using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.SingletonInDependencyInjection
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase _database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            _database = database;
        }

        public int GetTotalPopulation(string[] names)
        {
            int result = 0;
            foreach (var name in names)
            {
                result += _database.GetPopulation(name);
            }
            return result;
        }
    }
}
