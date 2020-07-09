using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.SingletonInDependencyInjection
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
