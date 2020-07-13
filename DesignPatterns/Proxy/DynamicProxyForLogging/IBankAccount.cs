using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.DynamicProxyForLogging
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
        string ToString();
    }
}
