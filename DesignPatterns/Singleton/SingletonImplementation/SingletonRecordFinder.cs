using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.SingletonImplementation
{
    public class SingletonRecordFinder
    {
        /// <summary>
        /// When you want to test this method you have to touch external resources.
        /// Since SingletonDatabase.Instance is hardcoded here, you cannot inject another data source.
        /// That's why Singletons make it hard for writing tests.
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public int GetTotalPopulation(string[] names)
        {
            int result = 0;
            foreach(var name in names)
            {
                result += SingletonDatabase.Instance.GetPopulation(name);
            }
            return result;
        }
    }
}
