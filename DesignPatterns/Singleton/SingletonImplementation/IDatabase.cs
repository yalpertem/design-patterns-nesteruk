using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.SingletonImplementation
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
